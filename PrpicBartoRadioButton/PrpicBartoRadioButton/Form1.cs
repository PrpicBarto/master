using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrpicBartoRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzbor_Click(object sender, EventArgs e)
        {

            //odabir prijevoza

            textBox1.Clear();
            if (rbtnAvion.Checked)
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            else if (rbtnAuto.Checked)
                textBox1.Text = "Odabrali ste prijevoz autobusom.";
            else if (rbtnSluzb.Checked)
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            else
            {
                // kada je prazno
                MessageBox.Show("Odaberite tip prijevoza.");
                return;
            }

        }

        private void oProgramu_Click(object sender, EventArgs e)
        {
            // o programu

            oProgramu message = new oProgramu();
            message.Show();
        }
    }
}
