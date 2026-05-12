namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортДанныхИзСетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGV_ActionsInSale = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Buy = new System.Windows.Forms.GroupBox();
            this.btn_BuyAuto = new System.Windows.Forms.Button();
            this.btn_BuyManual = new System.Windows.Forms.Button();
            this.dgv_ActionsOwned = new System.Windows.Forms.DataGridView();
            this.gb_Sale = new System.Windows.Forms.GroupBox();
            this.btn_SellAuto = new System.Windows.Forms.Button();
            this.btn_SellManual = new System.Windows.Forms.Button();
            this.gb_Wallet = new System.Windows.Forms.GroupBox();
            this.label_Wallet = new System.Windows.Forms.Label();
            this.walletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskActionsBDDataSet = new WindowsFormsApp1.TaskActionsBDDataSet();
            this.lb_USD_Rate = new System.Windows.Forms.Label();
            this.gb_CursUSD = new System.Windows.Forms.GroupBox();
            this.actionsInSaleTableAdapter = new WindowsFormsApp1.TaskActionsBDDataSetTableAdapters.ActionsInSaleTableAdapter();
            this.actionsTableAdapter = new WindowsFormsApp1.TaskActionsBDDataSetTableAdapters.ActionsTableAdapter();
            this.actionsOwnedTableAdapter = new WindowsFormsApp1.TaskActionsBDDataSetTableAdapters.ActionsOwned1TableAdapter();
            this.walletTableAdapter = new WindowsFormsApp1.TaskActionsBDDataSetTableAdapters.WalletTableAdapter();
            this.actionsInSalebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corrunceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionOwnedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionInSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceThreeUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForecastUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dynamic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ActionsInSale)).BeginInit();
            this.gb_Buy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ActionsOwned)).BeginInit();
            this.gb_Sale.SuspendLayout();
            this.gb_Wallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskActionsBDDataSet)).BeginInit();
            this.gb_CursUSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionsInSalebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionOwnedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionInSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сервисToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1499, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортДанныхИзСетиToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // импортДанныхИзСетиToolStripMenuItem
            // 
            this.импортДанныхИзСетиToolStripMenuItem.Name = "импортДанныхИзСетиToolStripMenuItem";
            this.импортДанныхИзСетиToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.импортДанныхИзСетиToolStripMenuItem.Text = "Импорт данных из сети";
            this.импортДанныхИзСетиToolStripMenuItem.Click += new System.EventHandler(this.импортДанныхИзСетиToolStripMenuItem_Click);
            // 
            // dGV_ActionsInSale
            // 
            this.dGV_ActionsInSale.AutoGenerateColumns = false;
            this.dGV_ActionsInSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ActionsInSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.PriceThreeUSD,
            this.dataGridViewTextBoxColumn8,
            this.ForecastUSD,
            this.Dynamic});
            this.dGV_ActionsInSale.DataSource = this.actionInSaleBindingSource;
            this.dGV_ActionsInSale.Location = new System.Drawing.Point(12, 58);
            this.dGV_ActionsInSale.Name = "dGV_ActionsInSale";
            this.dGV_ActionsInSale.RowHeadersWidth = 51;
            this.dGV_ActionsInSale.RowTemplate.Height = 24;
            this.dGV_ActionsInSale.Size = new System.Drawing.Size(1459, 286);
            this.dGV_ActionsInSale.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Акции в продаже";
            // 
            // gb_Buy
            // 
            this.gb_Buy.Controls.Add(this.btn_BuyAuto);
            this.gb_Buy.Controls.Add(this.btn_BuyManual);
            this.gb_Buy.Location = new System.Drawing.Point(12, 360);
            this.gb_Buy.Name = "gb_Buy";
            this.gb_Buy.Size = new System.Drawing.Size(266, 70);
            this.gb_Buy.TabIndex = 3;
            this.gb_Buy.TabStop = false;
            this.gb_Buy.Text = "Покупка";
            // 
            // btn_BuyAuto
            // 
            this.btn_BuyAuto.Location = new System.Drawing.Point(108, 21);
            this.btn_BuyAuto.Name = "btn_BuyAuto";
            this.btn_BuyAuto.Size = new System.Drawing.Size(152, 43);
            this.btn_BuyAuto.TabIndex = 8;
            this.btn_BuyAuto.Text = "Автоматически";
            this.btn_BuyAuto.UseVisualStyleBackColor = true;
            this.btn_BuyAuto.Click += new System.EventHandler(this.btn_BuyAuto_Click);
            // 
            // btn_BuyManual
            // 
            this.btn_BuyManual.Location = new System.Drawing.Point(6, 21);
            this.btn_BuyManual.Name = "btn_BuyManual";
            this.btn_BuyManual.Size = new System.Drawing.Size(96, 43);
            this.btn_BuyManual.TabIndex = 0;
            this.btn_BuyManual.Text = "Вручную";
            this.btn_BuyManual.UseVisualStyleBackColor = true;
            this.btn_BuyManual.Click += new System.EventHandler(this.btn_BuyManual_Click);
            // 
            // dgv_ActionsOwned
            // 
            this.dgv_ActionsOwned.AutoGenerateColumns = false;
            this.dgv_ActionsOwned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ActionsOwned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.corrunceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgv_ActionsOwned.DataSource = this.actionOwnedBindingSource;
            this.dgv_ActionsOwned.Location = new System.Drawing.Point(12, 444);
            this.dgv_ActionsOwned.Name = "dgv_ActionsOwned";
            this.dgv_ActionsOwned.RowHeadersWidth = 51;
            this.dgv_ActionsOwned.RowTemplate.Height = 24;
            this.dgv_ActionsOwned.Size = new System.Drawing.Size(1459, 207);
            this.dgv_ActionsOwned.TabIndex = 4;
            // 
            // gb_Sale
            // 
            this.gb_Sale.Controls.Add(this.btn_SellAuto);
            this.gb_Sale.Controls.Add(this.btn_SellManual);
            this.gb_Sale.Location = new System.Drawing.Point(815, 354);
            this.gb_Sale.Name = "gb_Sale";
            this.gb_Sale.Size = new System.Drawing.Size(267, 70);
            this.gb_Sale.TabIndex = 5;
            this.gb_Sale.TabStop = false;
            this.gb_Sale.Text = "Продажа";
            // 
            // btn_SellAuto
            // 
            this.btn_SellAuto.Location = new System.Drawing.Point(108, 22);
            this.btn_SellAuto.Name = "btn_SellAuto";
            this.btn_SellAuto.Size = new System.Drawing.Size(152, 43);
            this.btn_SellAuto.TabIndex = 9;
            this.btn_SellAuto.Text = "Автоматически";
            this.btn_SellAuto.UseVisualStyleBackColor = true;
            this.btn_SellAuto.Click += new System.EventHandler(this.btn_SellAuto_Click);
            // 
            // btn_SellManual
            // 
            this.btn_SellManual.Location = new System.Drawing.Point(6, 21);
            this.btn_SellManual.Name = "btn_SellManual";
            this.btn_SellManual.Size = new System.Drawing.Size(96, 43);
            this.btn_SellManual.TabIndex = 0;
            this.btn_SellManual.Text = "Вручную";
            this.btn_SellManual.UseVisualStyleBackColor = true;
            this.btn_SellManual.Click += new System.EventHandler(this.btn_SellManual_Click);
            // 
            // gb_Wallet
            // 
            this.gb_Wallet.Controls.Add(this.label_Wallet);
            this.gb_Wallet.Location = new System.Drawing.Point(311, 360);
            this.gb_Wallet.Name = "gb_Wallet";
            this.gb_Wallet.Size = new System.Drawing.Size(218, 70);
            this.gb_Wallet.TabIndex = 6;
            this.gb_Wallet.TabStop = false;
            this.gb_Wallet.Text = "Баланс";
            // 
            // label_Wallet
            // 
            this.label_Wallet.AutoSize = true;
            this.label_Wallet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.walletBindingSource, "Amount", true));
            this.label_Wallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Wallet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Wallet.Location = new System.Drawing.Point(7, 22);
            this.label_Wallet.Name = "label_Wallet";
            this.label_Wallet.Size = new System.Drawing.Size(64, 25);
            this.label_Wallet.TabIndex = 0;
            this.label_Wallet.Text = "label2";
            // 
            // walletBindingSource
            // 
            this.walletBindingSource.DataMember = "Wallet";
            this.walletBindingSource.DataSource = this.taskActionsBDDataSet;
            // 
            // taskActionsBDDataSet
            // 
            this.taskActionsBDDataSet.DataSetName = "TaskActionsBDDataSet";
            this.taskActionsBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_USD_Rate
            // 
            this.lb_USD_Rate.AutoSize = true;
            this.lb_USD_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_USD_Rate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_USD_Rate.Location = new System.Drawing.Point(7, 22);
            this.lb_USD_Rate.Name = "lb_USD_Rate";
            this.lb_USD_Rate.Size = new System.Drawing.Size(64, 25);
            this.lb_USD_Rate.TabIndex = 0;
            this.lb_USD_Rate.Text = "label2";
            // 
            // gb_CursUSD
            // 
            this.gb_CursUSD.Controls.Add(this.lb_USD_Rate);
            this.gb_CursUSD.Location = new System.Drawing.Point(570, 360);
            this.gb_CursUSD.Name = "gb_CursUSD";
            this.gb_CursUSD.Size = new System.Drawing.Size(218, 70);
            this.gb_CursUSD.TabIndex = 7;
            this.gb_CursUSD.TabStop = false;
            this.gb_CursUSD.Text = "Курс доллара";
            // 
            // actionsInSaleTableAdapter
            // 
            this.actionsInSaleTableAdapter.ClearBeforeFill = true;
            // 
            // actionsTableAdapter
            // 
            this.actionsTableAdapter.ClearBeforeFill = true;
            // 
            // actionsOwnedTableAdapter
            // 
            this.actionsOwnedTableAdapter.ClearBeforeFill = true;
            // 
            // walletTableAdapter
            // 
            this.walletTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 100;
            this.timer1.Enabled = false;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ActionID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ActionID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn10.HeaderText = "Название";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn11.HeaderText = "Компания";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // corrunceDataGridViewTextBoxColumn
            // 
            this.corrunceDataGridViewTextBoxColumn.DataPropertyName = "Corrunce";
            this.corrunceDataGridViewTextBoxColumn.HeaderText = "Валюта";
            this.corrunceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corrunceDataGridViewTextBoxColumn.Name = "corrunceDataGridViewTextBoxColumn";
            this.corrunceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // actionOwnedBindingSource
            // 
            this.actionOwnedBindingSource.DataSource = typeof(WindowsFormsApp1.Entites.ActionOwned);
            // 
            // actionInSaleBindingSource
            // 
            this.actionInSaleBindingSource.DataSource = typeof(WindowsFormsApp1.Entites.ActionInSale);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ActionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ActionID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn3.HeaderText = "Компания";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Currency";
            this.dataGridViewTextBoxColumn4.HeaderText = "Currency";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PriceOne";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена позавчера";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PriceTwo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена вчера";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PriceThree";
            this.dataGridViewTextBoxColumn7.HeaderText = "Цена сегодня";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // PriceThreeUSD
            // 
            this.PriceThreeUSD.DataPropertyName = "PriceThreeUSD";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.PriceThreeUSD.DefaultCellStyle = dataGridViewCellStyle1;
            this.PriceThreeUSD.HeaderText = "Цена сегодня в $";
            this.PriceThreeUSD.MinimumWidth = 6;
            this.PriceThreeUSD.Name = "PriceThreeUSD";
            this.PriceThreeUSD.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Forecast";
            this.dataGridViewTextBoxColumn8.HeaderText = "Прогноз";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // ForecastUSD
            // 
            this.ForecastUSD.DataPropertyName = "ForecastUSD";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ForecastUSD.DefaultCellStyle = dataGridViewCellStyle2;
            this.ForecastUSD.HeaderText = "Прогноз в $";
            this.ForecastUSD.MinimumWidth = 6;
            this.ForecastUSD.Name = "ForecastUSD";
            this.ForecastUSD.Width = 125;
            // 
            // Dynamic
            // 
            this.Dynamic.DataPropertyName = "Dynamic";
            this.Dynamic.HeaderText = "Динамика";
            this.Dynamic.MinimumWidth = 6;
            this.Dynamic.Name = "Dynamic";
            this.Dynamic.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 672);
            this.Controls.Add(this.gb_CursUSD);
            this.Controls.Add(this.gb_Wallet);
            this.Controls.Add(this.gb_Sale);
            this.Controls.Add(this.dgv_ActionsOwned);
            this.Controls.Add(this.gb_Buy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_ActionsInSale);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Симуляция покупки и продажи файлов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ActionsInSale)).EndInit();
            this.gb_Buy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ActionsOwned)).EndInit();
            this.gb_Sale.ResumeLayout(false);
            this.gb_Wallet.ResumeLayout(false);
            this.gb_Wallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskActionsBDDataSet)).EndInit();
            this.gb_CursUSD.ResumeLayout(false);
            this.gb_CursUSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionsInSalebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionOwnedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionInSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортДанныхИзСетиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGV_ActionsInSale;
        private System.Windows.Forms.Label label1;
        private TaskActionsBDDataSet taskActionsBDDataSet;
        private TaskActionsBDDataSetTableAdapters.ActionsInSaleTableAdapter actionsInSaleTableAdapter;
        private TaskActionsBDDataSetTableAdapters.ActionsTableAdapter actionsTableAdapter;
        private System.Windows.Forms.GroupBox gb_Buy;
        private System.Windows.Forms.Button btn_BuyManual;
        private System.Windows.Forms.DataGridView dgv_ActionsOwned;
        private System.Windows.Forms.GroupBox gb_Sale;
        private System.Windows.Forms.Button btn_SellManual;
        private System.Windows.Forms.GroupBox gb_Wallet;
        private System.Windows.Forms.Label label_Wallet;
        private System.Windows.Forms.Label lb_USD_Rate;
        private System.Windows.Forms.GroupBox gb_CursUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forecastDataGridViewTextBoxColumn;
        private TaskActionsBDDataSetTableAdapters.ActionsOwned1TableAdapter actionsOwnedTableAdapter;
        private System.Windows.Forms.BindingSource actionsInSalebindingSource;
        private System.Windows.Forms.BindingSource actionInSaleBindingSource;
        private TaskActionsBDDataSetTableAdapters.WalletTableAdapter walletTableAdapter;
        private System.Windows.Forms.BindingSource walletBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn corrunceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource actionOwnedBindingSource;
        private System.Windows.Forms.Button btn_BuyAuto;
        private System.Windows.Forms.Button btn_SellAuto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceThreeUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForecastUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dynamic;
    }
}