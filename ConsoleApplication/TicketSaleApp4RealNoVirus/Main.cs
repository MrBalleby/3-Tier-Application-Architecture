using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSaleApp4RealNoVirus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(0);
            form.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(1);
            form.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(2);
            form.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(3);
            form.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(4);
            form.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(5);
            form.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(6);
            form.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(7);
            form.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm(8);
            form.ShowDialog();
        }
    }
}
