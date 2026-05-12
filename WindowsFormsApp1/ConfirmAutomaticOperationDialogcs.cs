using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConfirmAutomaticOperationDialogcs : Form
    {
        public ConfirmAutomaticOperationDialogcs(bool is_sale )
        {
            InitializeComponent();
            this.lb_promt.Text = is_sale ? "Список акций к продаже" : "Список акций к покупке";
            

            this.lb_under.Text = is_sale ? "Стоимость продажи" : "Стоимость покупки";
        }

        public object datasourse
        {
            set
            {
                this.actionsBS.DataSource = value;
                this.dgv_AList.DataSource = this.actionsBS;

            }
                
        }

        public decimal total
        {
            set{this.lb_Total.Text = value.ToString();}
        }

        public decimal totalBalic
        {
            set { this.lb_TotalBalic.Text = value.ToString(); }
        }

        public bool no_money { set {
                
                if (value)
                {
                    this.lb_nedostachSRV.Visible = true;
                    this.btn_OK.Enabled = false;
                }
            } }

    }
}
