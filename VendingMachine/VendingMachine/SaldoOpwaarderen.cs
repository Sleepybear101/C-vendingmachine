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
        int counter = 0;

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
            counter++;
            labelCount.Text = counter.ToString();

            Button button = (Button)sender;

            var muntWaarde = decimal.Parse(button.Text);

            huidigeSaldo = huidigeSaldo + muntWaarde;

            if (textBoxSaldo.Text == "0")
            {
                textBoxSaldo.Text = "";
            }

            if (counter >5)
            {
                MessageBox.Show("U heeft het maximale aantal munten bereikt");
                button10Cent.Enabled = false;
                button20Cent.Enabled = false;
                button50Cent.Enabled = false;
                button1Euro.Enabled = false;
                button2Euro.Enabled = false;

            }

            textBoxSaldo.Text = huidigeSaldo.ToString("C");
        }

        private void TextBoxSaldo_TextChanged(object sender, EventArgs e)
        {

            if (textBoxSaldo.Text == "€ 5,00" )
            {
                MessageBox.Show("U heeft het maximale saldo van € 5,00 bereikt");
                button10Cent.Enabled = false;
                button20Cent.Enabled = false;
                button50Cent.Enabled = false;
                button1Euro.Enabled = false;
                button2Euro.Enabled = false;
                textBoxSaldo.Enabled = false;
            }

            if (textBoxSaldo.Text == "€ 6,00")
            {
                MessageBox.Show("Saldo hoger dan € 5,00 euro is niet toegestaan ");
                textBoxSaldo.Text = "€ 5,00";
            }
        }
    }
}
