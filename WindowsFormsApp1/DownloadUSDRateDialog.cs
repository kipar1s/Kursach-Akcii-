using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{    
    public partial class DownloadUSDRateDialog : Form
    {
        public decimal _usd_rate;
        public DownloadUSDRateDialog()
        {
            InitializeComponent();
            IWFUSDD_async();
        }

        public decimal usd_rate { get { return _usd_rate; } }
        public async void IWFUSDD_async()
        {
            await this.getData();
            Close();
        }

        public async Task getData()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
            client.Timeout = TimeSpan.FromSeconds(30);

            int maxRetries = 3;
            int delayMs = 3000;
            string data = null;

            for (int attempt = 1; attempt <= maxRetries; attempt++)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(@"https://www.cbr-xml-daily.ru/daily_json.js");
                    
                    if (!response.IsSuccessStatusCode)
                    {
                        if (attempt < maxRetries)
                        {
                            await Task.Delay(delayMs);
                            delayMs *= 2;
                            continue;
                        }
                        response.EnsureSuccessStatusCode();
                    }

                    data = await response.Content.ReadAsStringAsync();
                    break;
                }
                catch
                {
                    if (attempt < maxRetries)
                    {
                        await Task.Delay(delayMs);
                        delayMs *= 2;
                    }
                }
            }

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Не удалось загрузить курс USD. Будет использован курс по умолчанию (1).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _usd_rate = 1.0M;
                return;
            }

            var parsedData = JsonSerializer.Deserialize<valuteRateRoot>(data);
            _usd_rate = parsedData.Valute.USD.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


    public class valute
    {
        public decimal Value { get; set; }
    }
    public class valutes
    {
        public valute USD { get; set; }
    }
    public class valuteRateRoot
    {
        public valutes Valute { get; set; }
    }


}
