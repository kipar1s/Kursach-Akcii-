namespace WindowsFormsApp1
{
    partial class ConfirmAutomaticOperationDialogcs
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
            this.lb_promt = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.actionsBS = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_AList = new System.Windows.Forms.DataGridView();
            this.lb_Total = new System.Windows.Forms.Label();
            this.lb_under = new System.Windows.Forms.Label();
            this.lb_nedostachSRV = new System.Windows.Forms.Label();
            this.lb_TotalBalic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_promt
            // 
            this.lb_promt.AutoSize = true;
            this.lb_promt.Location = new System.Drawing.Point(13, 13);
            this.lb_promt.Name = "lb_promt";
            this.lb_promt.Size = new System.Drawing.Size(224, 16);
            this.lb_promt.TabIndex = 1;
            this.lb_promt.Text = "Список акций к покупке/продаже";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(16, 532);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(413, 130);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(455, 597);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(390, 65);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // dgv_AList
            // 
            this.dgv_AList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AList.Location = new System.Drawing.Point(16, 32);
            this.dgv_AList.Name = "dgv_AList";
            this.dgv_AList.RowHeadersWidth = 51;
            this.dgv_AList.RowTemplate.Height = 24;
            this.dgv_AList.Size = new System.Drawing.Size(1055, 485);
            this.dgv_AList.TabIndex = 4;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Total.Location = new System.Drawing.Point(592, 532);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(43, 16);
            this.lb_Total.TabIndex = 5;
            this.lb_Total.Text = "Total";
            this.lb_Total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_under
            // 
            this.lb_under.AutoSize = true;
            this.lb_under.Location = new System.Drawing.Point(452, 532);
            this.lb_under.Name = "lb_under";
            this.lb_under.Size = new System.Drawing.Size(137, 16);
            this.lb_under.TabIndex = 6;
            this.lb_under.Text = "Стоимость покупки:";
            this.lb_under.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_nedostachSRV
            // 
            this.lb_nedostachSRV.AutoSize = true;
            this.lb_nedostachSRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_nedostachSRV.ForeColor = System.Drawing.Color.Red;
            this.lb_nedostachSRV.Location = new System.Drawing.Point(452, 562);
            this.lb_nedostachSRV.Name = "lb_nedostachSRV";
            this.lb_nedostachSRV.Size = new System.Drawing.Size(178, 16);
            this.lb_nedostachSRV.TabIndex = 7;
            this.lb_nedostachSRV.Text = "Недостаточно средств";
            this.lb_nedostachSRV.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_nedostachSRV.Visible = false;
            // 
            // lb_TotalBalic
            // 
            this.lb_TotalBalic.AutoSize = true;
            this.lb_TotalBalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TotalBalic.Location = new System.Drawing.Point(714, 532);
            this.lb_TotalBalic.Name = "lb_TotalBalic";
            this.lb_TotalBalic.Size = new System.Drawing.Size(82, 16);
            this.lb_TotalBalic.TabIndex = 8;
            this.lb_TotalBalic.Text = "Total Balic";
            this.lb_TotalBalic.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConfirmAutomaticOperationDialogcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 685);
            this.Controls.Add(this.lb_TotalBalic);
            this.Controls.Add(this.lb_nedostachSRV);
            this.Controls.Add(this.lb_under);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.dgv_AList);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lb_promt);
            this.Name = "ConfirmAutomaticOperationDialogcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение автоматической операции ";
            ((System.ComponentModel.ISupportInitialize)(this.actionsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_promt;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.BindingSource actionsBS;
        private System.Windows.Forms.DataGridView dgv_AList;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lb_under;
        private System.Windows.Forms.Label lb_nedostachSRV;
        private System.Windows.Forms.Label lb_TotalBalic;
    }
}