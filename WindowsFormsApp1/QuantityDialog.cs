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
    public partial class QuantityDialog : Form
    {
        public QuantityDialog()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

        }

        public int Quantity
        {
            get
            {
                return Convert.ToInt32(this.tb_Quantity.Text);
            }
        }
    }


}
