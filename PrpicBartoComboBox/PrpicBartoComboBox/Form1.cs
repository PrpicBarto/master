using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrpicBartoComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //odabir

            string choice = comboBox1.SelectedItem.ToString();
            txtIspis.Text = "Odabrali ste: " + choice;
        }

        private void oProgramuStrip_Click(object sender, EventArgs e)
        {

            // o programu

            oProgramu message = new oProgramu();
            message.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
