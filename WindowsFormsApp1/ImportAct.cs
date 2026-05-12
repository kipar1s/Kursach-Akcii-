using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class ImportAct : Form
    {
        public ImportAct()
        {
            InitializeComponent();
        }

        public async void getData()
        {
            //Подготовка к скачиванию акций - инициализация сетевых объектов
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
            client.Timeout = TimeSpan.FromSeconds(30);

            int maxRetries = 3;
            int delayMs = 5000;
            string data = null;

            for (int attempt = 1; attempt <= maxRetries; attempt++)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(@"https://quote.rbc.ru/v5/ajax/catalog/get-tickers?type=share&sort=blue_chips&limit=200&offset=0");
                    
                    if (!response.IsSuccessStatusCode)
                    {
                        if ((int)response.StatusCode == 429)
                        {
                            MessageBox.Show($"Превышен лимит запросов. Попытка {attempt} из {maxRetries}. Подождите {delayMs/1000} сек...", 
                                "Ожидание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            await Task.Delay(delayMs);
                            delayMs *= 2;
                            continue;
                        }
                        response.EnsureSuccessStatusCode();
                    }

                    data = await response.Content.ReadAsStringAsync();
                    break;
                }
                catch (HttpRequestException ex) when (ex.Message.Contains("429") || (ex.InnerException != null && ex.InnerException.Message.Contains("429")))
                {
                    if (attempt < maxRetries)
                    {
                        MessageBox.Show($"Слишком много запросов. Попытка {attempt} из {maxRetries}. Подождите {delayMs/1000} сек...", 
                            "Ожидание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        await Task.Delay(delayMs);
                        delayMs *= 2;
                    }
                }
            }

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Не удалось загрузить данные. Попробуйте позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var parsedData = JsonSerializer.Deserialize<List<Action>>(data);

            foreach (var item in parsedData)
            {
                this.dataGridView1.Rows.Add(item.company.title, item.title, item.price, item.currency);
                AddActions(item.title, item.company.title, item.currency);
                AddActionInSale(item.title, item.company.title, item.currency, item.price);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.getData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taskActionsBDDataSet.Actions". При необходимости она может быть перемещена или удалена.
            this.actionsTableAdapter.Fill(this.taskActionsBDDataSet.Actions);

        }

        // Скачивание инф об акциях на конкретную дату в таблицу ActionInSale

        private void AddActionInSale(string title, string company, string currency, decimal? price)
        {
            //Получение id акций из таблицы Actions
            int? action_id = AddActions(title, company, currency);

            //Сохранение курса акций на сегодня в таблицу ActionInSale
            this.actionsInSaleTableAdapter.Insert(action_id, price, DateTime.Now);


        }

        // СКачивания  обобщенной информации об акциях в таблицу Actions 
        private int? AddActions(string title, string company, string currency)
        {


            //ПРоверка существрования акции 
            this.actionsTableAdapter.Fill(this.taskActionsBDDataSet.Actions);

            int? action_id;
            var query_result = from action in this.taskActionsBDDataSet.Actions.AsEnumerable()
                               where action.Title == title &&
                                     action.Company == company &&
                                     action.Currency == currency
                               select action;

            if (query_result.Count() > 0)
            {
                action_id = query_result.First().ID;     // Акция есть 
            }
            else
            {
                //Акции нет 
                //Добавление акции
                this.actionsTableAdapter.Insert(title, company, currency);

                //Получение её id
                action_id = this.actionsTableAdapter.GetLastInsertID();
            }
            return action_id;



        }
    }


    //Классы для представления на языке C# данных, скачанных с веб-сайта
    public class Company
    {
        public string title { get; set; }
    }
    public class Action
    {
        public Company company { get; set; }
        public string title { get; set; }
        public decimal? price { get; set; }
        public string currency { get; set; }
    }
}



