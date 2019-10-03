using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_Layer;
namespace TicketSaleApp4RealNoVirus
{
    public partial class DataForm : Form
    {
        public int i;
        public DataForm(int param)
        {
            InitializeComponent();
            switch (param)
            {
                case 0:
                    i = 0;
                    break;
                case 1:
                    i = 1;
                    break;
                case 2:
                    i = 2;
                    break;
                case 3:
                    i = 3;
                    break;
                case 4:
                    i = 4;
                    break;
                case 5:
                    i = 5;
                    break;
                case 6:
                    i = 6;
                    break;
                case 7:
                    i = 7;
                    break;
                case 8:
                    i = 8;
                    break;
                default:
                    break;
            }
        }

        private void Data_Load(object sender, EventArgs e)
        {
            Bll bll = new Bll();
            switch (i)
            {
                case 0:
                    dataGridView1.DataSource = bll.GetCustomer();
                    dataGridView1.AutoGenerateColumns = true;
                    break;
                default:
                    break;
            }
            

        }
    }
}
