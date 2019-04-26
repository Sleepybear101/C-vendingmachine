using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class SaldoOpwaarderen : Form
    {
        public decimal huidigeSaldo;
        public Snoepmachine _Form1;

        public SaldoOpwaarderen(Snoepmachine form1)
        {
            InitializeComponent();
            _Form1 = form1;
        }

        private void ButtonOpwaarderen_Click(object sender, EventArgs e)
        {
            labelHuidigeSaldo.Text = textBoxSaldo.Text;
            _Form1.labelSaldoUser.Text = "" + labelHuidigeSaldo.Text;
            MessageBox.Show("Saldo is opgewaardeerd");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            var muntWaarde = decimal.Parse(button.Text);

            huidigeSaldo = huidigeSaldo + muntWaarde;

            if (textBoxSaldo.Text == "0")
            {
                textBoxSaldo.Text = "";
            }

        }
    }
}
