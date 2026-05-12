using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entites;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        IEnumerable<ActionInSale> actions_in_sale;        
        IEnumerable<ActionOwned> actions_owned;
        decimal usd_rate = 1.0M;
        public MainForm()
        {
            InitializeComponent();
            UpdateActionsInSale();
            UpdateActionsOwned();
            UpdateWallet();
            timer1.Start();
        }

        private void импортДанныхИзСетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportActDialog import_dialog = new ImportActDialog();
            import_dialog.ShowDialog();
        }

        //Обновление данных 
        public void UpdateActionsInSale()
        {
            //Загрузка данных из таблицы Actions
            this.actionsTableAdapter.Fill(this.taskActionsBDDataSet.Actions);

            //Загрузка данных из таблицы ActionsInSale
            this.actionsInSaleTableAdapter.Fill(this.taskActionsBDDataSet.ActionsInSale);

            //Представление данных из Actions  в виде словаря
            var actions = this.taskActionsBDDataSet.Actions.ToDictionary(action => action.ID);
                        
            //LINQ запрос формаулирующий для отображения анных из таблицы 
            actions_in_sale = MyUtilities.Clone<IEnumerable<ActionInSale>>( 
                from action_in_sale in this.taskActionsBDDataSet.ActionsInSale.AsEnumerable()
                                  
                                  group action_in_sale by action_in_sale.ActionsID into action_group
                                  let action_id = action_group.Key
                                  let prices = from  action_group_items in action_group
                                              orderby action_group_items.StockDate descending
                                              select action_group_items.Price

                                  let price_one = prices.FirstOrDefault()
                                  let price_two = prices.Skip(1).FirstOrDefault()
                                  let price_three = prices.Skip(2).FirstOrDefault()
                                  let price_three_usd = price_three /usd_rate
                                    // Линейная экстраполяция по МНК (прогноз на 1 шаг вперед)
                                    // Формула: Forecast = (4*P_latest + P_middle - 2*P_oldest) / 3
                                    let forecast = (4 * price_one + price_two - 2 * price_three) / 3m

                                    // Расчеты для отображения
                                    let current_price_usd = price_one / usd_rate
                                    let forecast_usd = forecast / usd_rate
                                    let dynamic = forecast - price_one

                select new ActionInSale
                                  {        
                                      ActionID = action_id,
                                      Title = actions[action_id].Title,
                                      Company = actions[action_id].Company,
                                      Currency = actions[action_id].Currency,
                                      PriceOne = price_one,
                                      PriceTwo = price_two,
                                      PriceThree = price_three,
                                      PriceThreeUSD = price_three_usd,
                                      Forecast = forecast,
                                      ForecastUSD = forecast_usd,
                                      Dynamic = dynamic

                              });
            //вывод сформированных данных в таблицу 
            this.actionsInSalebindingSource.DataSource = actions_in_sale;  
            this.dGV_ActionsInSale.DataSource= this.actionsInSalebindingSource;

        }

        private void btn_BuyManual_Click(object sender, EventArgs e)
        {
            QuantityDialog quantity_dialog = new QuantityDialog();
            if(quantity_dialog.ShowDialog() == DialogResult.OK)
            {
                //0. ПОлучить ID Акции
                var action_id = ((ActionInSale)this.actionsInSalebindingSource.Current).ActionID;
                var action_price = ((ActionInSale)this.actionsInSalebindingSource.Current).PriceThree;
                
                //ПРоверка наличия средств на балансе
                var row = ((DataRowView)this.walletBindingSource.Current).Row;
                var column = taskActionsBDDataSet.Wallet.Columns["Amount"];
                decimal amount = Convert.ToDecimal(row[column]);

                if(amount < action_price * quantity_dialog.Quantity)
                {
                    MessageBox.Show("Недостаточно средств");
                    return;
                }

                //1.Добавиление или изменение записи в таблице ActionsOwned

                //опередилить если  уже акция в базе
                var action_owned = from a in this.taskActionsBDDataSet.ActionsOwned1.AsEnumerable()
                                   where a.ActionsID == action_id
                                   select a;
                if (action_owned.Count() == 0)
                {//ЕСли первая покупка - добавить
                    this.actionsOwnedTableAdapter.FirstBuy(action_id, quantity_dialog.Quantity);

                }
                else
                {
                    this.actionsOwnedTableAdapter.IncreaseQuantity(quantity_dialog.Quantity, action_id);

                }




                //Если покупка не первая - изменние записи

                //2.Уменьшить кол-во средств в кошельке (Wallet)
                this.walletTableAdapter.DecreaseAmount(action_price*quantity_dialog.Quantity);

                UpdateWallet();
                UpdateActionsOwned();
            }
        }

        public void UpdateActionsOwned()
        {
            //Подгрузка данных из табл ActionsOwned
            this.actionsOwnedTableAdapter.Fill(this.taskActionsBDDataSet.ActionsOwned1);

            //Загрузка данных из таблицы Actions
            this.actionsTableAdapter.Fill(this.taskActionsBDDataSet.Actions);
            //Представление данных из Actions  в виде словаря
            var actions = this.taskActionsBDDataSet.Actions.ToDictionary(action => action.ID);

            actions_owned = MyUtilities.Clone<IEnumerable<ActionOwned>>                
                (from action_owned in this.taskActionsBDDataSet.ActionsOwned1.AsEnumerable()
                            select new ActionOwned
                            {
                                ActionID = action_owned.ActionsID,
                                Title = actions[action_owned.ActionsID].Title,
                                Company = actions[action_owned.ActionsID].Company,
                                Corrunce = actions[action_owned.ActionsID].Currency,
                                Quantity = action_owned.Quantity,
                            });
            this.actionOwnedBindingSource.DataSource = actions_owned;
        }

        public void UpdateWallet()
        {
            this.walletTableAdapter.Fill(this.taskActionsBDDataSet.Wallet);
        }

        private void btn_SellManual_Click(object sender, EventArgs e)
        {
            QuantityDialog quantity_dialog = new QuantityDialog();
            if(quantity_dialog.ShowDialog() == DialogResult.OK)
            {
                UpdateActionsOwned();
                UpdateActionsInSale();
                //0. ПОлучить ID Акции
                var action_id = ((ActionOwned)this.actionOwnedBindingSource.Current).ActionID;

                this.actionsOwnedTableAdapter.Fill(this.taskActionsBDDataSet.ActionsOwned1);
                //ПРОверка, что продаваемое кол-во акций есть в собственности 
                var actions_owned = from action_owned in this.taskActionsBDDataSet.ActionsOwned1.AsEnumerable()
                                    where action_owned.ActionsID == action_id &&
                                          action_owned.Quantity >= quantity_dialog.Quantity
                                    select action_owned;
                if(actions_owned.Count() == 0)
                {
                    MessageBox.Show("Попытка продажи несуществующих акций");
                    return;
                }

                //0.1 ПОлучить цены на сегодня Акции
                UpdateActionsInSale();
                var price = (from action_in_sale in actions_in_sale
                             where action_in_sale.ActionID == action_id
                             select action_in_sale.PriceThree).FirstOrDefault();

                if(quantity_dialog.Quantity < actions_owned.First().Quantity)
                {
                    //Если продается кол-во меньшее, чем имеется

                    //УМеншаем кол-во Quantity в табл ActionsOwned
                    this.actionsOwnedTableAdapter.DecreaseQuantity(action_id, quantity_dialog.Quantity);
                }
                else
                {
                    //Если продается кол-во равное, что имеем 
                    //Удаление соотв строки из таблицы ActionsOwned
                    this.actionsOwnedTableAdapter.LastSell(action_id);
                }

                this.walletTableAdapter.IncreaseQuantity(quantity_dialog.Quantity * price);
                UpdateWallet();
                UpdateActionsOwned();
            }
        }

        void SellActions(int action_id, decimal action_price, int action_quantity)
        {
            UpdateActionsOwned();
            UpdateActionsInSale();

            this.actionsOwnedTableAdapter.Fill(this.taskActionsBDDataSet.ActionsOwned1);
            //ПРОверка, что продаваемое кол-во акций есть в собственности 
            var actions_owned = from action_owned in this.taskActionsBDDataSet.ActionsOwned1.AsEnumerable()
                                where action_owned.ActionsID == action_id &&
                                      action_owned.Quantity >= action_quantity
                                select action_owned;
            if (actions_owned.Count() == 0)
            {
                MessageBox.Show("Попытка продажи несуществующих акций");
                return;
            }

            //0.1 ПОлучить цены на сегодня Акции
            UpdateActionsInSale();
            var price = (from action_in_sale in actions_in_sale
                         where action_in_sale.ActionID == action_id
                         select action_in_sale.PriceThree).FirstOrDefault();

            if (action_quantity < actions_owned.First().Quantity)
            {
                //Если продается кол-во меньшее, чем имеется
                //УМеншаем кол-во Quantity в табл ActionsOwned
                this.actionsOwnedTableAdapter.DecreaseQuantity(action_id, action_quantity);
            }
            else
            {
                //Если продается кол-во равное, что имеем 
                //Удаление соотв строки из таблицы ActionsOwned
                this.actionsOwnedTableAdapter.LastSell(action_id);
            }
            
            this.walletTableAdapter.IncreaseQuantity(action_quantity * price);
            UpdateWallet();
            UpdateActionsOwned();
        }
        private void btn_BuyAuto_Click(object sender, EventArgs e)
        {
            UpdateActionsInSale();
            //Запрос списка акций рекомендуемых к покупке 
            var actions_to_buy = actions_in_sale
                                    .Where(a =>a.PriceOne > 0 && a.PriceTwo > 0 && a.PriceThree>0)
                                    .OrderByDescending(a => a.Dynamic)
                                    .Take(10)
                                    .Select((a, idx) => new
                                    {
                                        ActionID = a.ActionID,
                                        Title =a.Title,
                                        Company = a.Company,
                                        Currency = a.Currency,
                                        Dynamic = a.Dynamic,
                                        Price = a.PriceThree,
                                        Quantity = 10 - idx,
                                        Cost = (10 - idx) * a.PriceThree
                                    });

            var total = actions_to_buy.Sum(a=>a.Cost);

            ConfirmAutomaticOperationDialogcs cao_dialog = new ConfirmAutomaticOperationDialogcs(false);
            cao_dialog.datasourse = actions_to_buy;
            cao_dialog.total = total;
            cao_dialog.totalBalic = this.taskActionsBDDataSet.Wallet[0].Amount;
            cao_dialog.no_money = this.taskActionsBDDataSet.Wallet[0].Field<Decimal>("Amount") < total;
            if(cao_dialog.ShowDialog() == DialogResult .OK)
            {
                foreach(var action_to_buy in actions_to_buy)
                    BayAction(action_to_buy.ActionID, action_to_buy.Price, action_to_buy.Quantity);
            }

            
        }


        //Покупка
        void BayAction(int action_id, decimal action_price, int action_quantity)
        {
            //0. ПОлучить wtys Акции
            //var action_price = ((ActionInSale)this.actionsInSalebindingSource.Current).PriceThree;

            //ПРоверка наличия средств на балансе
            var row = ((DataRowView)this.walletBindingSource.Current).Row;
            var column = taskActionsBDDataSet.Wallet.Columns["Amount"];
            decimal amount = Convert.ToDecimal(row[column]);

            if (amount < action_price * action_quantity)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }

            //1.Добавиление или изменение записи в таблице ActionsOwned

            //отпередилит ьесли дли уже акция в базе
            var action_owned = from a in this.taskActionsBDDataSet.ActionsOwned1.AsEnumerable()
                               where a.ActionsID == action_id
                               select a;
            if (action_owned.Count() == 0)
            {//ЕСли первая покупка - добавить
                this.actionsOwnedTableAdapter.FirstBuy(action_id, action_quantity);

            }
            else
            {
                this.actionsOwnedTableAdapter.IncreaseQuantity(action_quantity, action_id);

            }




            //Если покупка не первая - изменние записи

            //2.Уменьшить кол-во средств в кошельке (Wallet)
            this.walletTableAdapter.DecreaseAmount(action_price * action_quantity);

            UpdateWallet();
            UpdateActionsOwned();

        }

        private void btn_SellAuto_Click(object sender, EventArgs e)
        {
            UpdateActionsInSale();
            UpdateActionsOwned();
            UpdateWallet();
            this.actionsTableAdapter.Fill(this.taskActionsBDDataSet.Actions);
            this.actionsOwnedTableAdapter.Fill(taskActionsBDDataSet.ActionsOwned1);
            this.actionsInSaleTableAdapter.Fill(taskActionsBDDataSet.ActionsInSale);
            var actions_to_sell = from action_in_sale in actions_in_sale
                                  join action_owned in actions_owned on
                                  action_in_sale.ActionID equals action_owned.ActionID
                                  orderby action_in_sale.Dynamic ascending
                                  where action_in_sale.Dynamic < 0
                                  select new
                                  {
                                      ActionID = action_owned.ActionID,
                                      Company = action_owned.Company,
                                      Title = action_owned.Title,
                                      Currency = action_in_sale.Currency,
                                      Dynamic = action_in_sale.Dynamic,
                                      Price = action_in_sale.PriceThree,
                                      Quantity = action_owned.Quantity / 2,
                                      Cost = action_in_sale.PriceThree * (action_owned.Quantity / 2),
                                  };
            if (actions_to_sell.Count() == 0)
            {
                MessageBox.Show("В собственности отсуттвует акции , удовлетворяющие критериям автоматичсекйо продажи (с отрицательно динамикой) ");

                return;
            }

            var  total = actions_to_sell.Sum(a=>a.Cost);    


            ConfirmAutomaticOperationDialogcs cao_dialog = new ConfirmAutomaticOperationDialogcs(true);
            cao_dialog.datasourse = actions_to_sell;
            cao_dialog.total = total;
            if (cao_dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var action_to_sell in actions_to_sell)
                    SellActions(action_to_sell.ActionID, action_to_sell.Price, action_to_sell.Quantity);
            }
            RefreshAllData();
            MessageBox.Show("Автоматическая продажа завершена");
            ;


        }

        

        // Единый метод для обновления всех таблиц на форме
        private void RefreshAllData()
        {
            // 1. Перечитываем данные из физической БД в память (DataSet)
            this.actionsTableAdapter.Fill(this.taskActionsBDDataSet.Actions);
            this.actionsInSaleTableAdapter.Fill(this.taskActionsBDDataSet.ActionsInSale);
            this.actionsOwnedTableAdapter.Fill(this.taskActionsBDDataSet.ActionsOwned1);
            this.walletTableAdapter.Fill(this.taskActionsBDDataSet.Wallet);

            // 2. Пересчитываем LINQ-запросы (вызываем ваши методы)
            UpdateActionsInSale();
            UpdateActionsOwned();
            UpdateWallet();

            // 3. Заставляем Grid-ы перерисоваться
            this.actionsInSalebindingSource.ResetBindings(false);
            this.actionOwnedBindingSource.ResetBindings(false);
            this.walletBindingSource.ResetBindings(false);
        }

        // Функция для очистки базы от пустых или ошибочных записей
        public void CleanupDatabase()
        {
            try
            {
                // 1. Выполняем удаление в физической БД
                this.actionsOwnedTableAdapter.CleanupOwned();

                // 2. Сразу обновляем данные в памяти (DataSet), чтобы Grid это увидел
                this.actionsOwnedTableAdapter.Fill(this.taskActionsBDDataSet.ActionsOwned1);

                // 3. Пересчитываем LINQ-список для отображения
                UpdateActionsOwned();

                // 4. Уведомляем BindingSource, что данные изменились
                this.actionOwnedBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при очистке таблицы: " + ex.Message);
            }
        }

        int tick_stste = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick_stste > 1) return;
            
            timer1.Stop();
            
            switch (tick_stste)
            {
                case 0:
                    {
                        DownloadUSDRateDialog usd_dialog = new DownloadUSDRateDialog();
                        usd_dialog.ShowDialog();
                        usd_rate = usd_dialog.usd_rate;
                        lb_USD_Rate.Text = usd_rate.ToString();
                        break;
                    }
                case 1: 
                    {
                        UpdateActionsInSale();
                        UpdateActionsOwned();
                        break; 
                    }
            }
            tick_stste++;
            
            if (tick_stste <= 1)
            {
                timer1.Start();
            }
        }
    }

}
