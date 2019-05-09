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
        public decimal muntWaarde;
        public decimal huidigeSaldo;
        public Snoepmachine _Form1;

        public SaldoOpwaarderen(Snoepmachine form1)
        {
            InitializeComponent();
            _Form1 = form1;
            labelHuidigeSaldo.Text = _Form1.labelSaldoUser.Text;
        }

        private void ButtonOpwaarderen_Click(object sender, EventArgs e)
        {
            labelHuidigeSaldo.Text = textBoxSaldo.Text;
            _Form1.labelSaldoUser.Text = "" + labelHuidigeSaldo.Text;
            MessageBox.Show("Saldo is opgewaardeerd");
            this.Close();

        }

        private void button_Click(object sender, EventArgs e)
        {
            ConvertCurrency convert = new ConvertCurrency();

            Button button = (Button)sender;

            muntWaarde = decimal.Parse(button.Text);

            huidigeSaldo = huidigeSaldo + muntWaarde;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gebruiker\Desktop\Sound\Coin.wav");
            player.Play();

            if (textBoxSaldo.Text == "0")
            {
                textBoxSaldo.Text = "";
            }

            if (textBoxSaldo.Text.Contains("€"))
            {
                textBoxSaldo.Text = convert.ConvertCurrencyToInt(textBoxSaldo.Text).ToString();
            }


            textBoxSaldo.Text = (Convert.ToDecimal(huidigeSaldo) / 100).ToString("C");
        }



        private void TextBoxSaldo_TextChanged(object sender, EventArgs e)
        {

            if (textBoxSaldo.Text == "0")
            {
                MessageBox.Show("Kies een munt");
            }

            if (textBoxSaldo.Text == "€ 5,00")
            {
                MessageBox.Show("U heeft het maximale saldo van € 5,00 bereikt");
                button10Cent.Enabled = false;
                button20Cent.Enabled = false;
                button50Cent.Enabled = false;
                button1Euro.Enabled = false;
                button2Euro.Enabled = false;
                textBoxSaldo.Enabled = false;
            }

            if (textBoxSaldo.Text == "€ 6,00" || textBoxSaldo.Text == "€ 5,10")
            {
                MessageBox.Show("U bent over het maximale saldo gegaan");
                MessageBox.Show("2 euro is teruggestort");
                muntWaarde = 0;
                huidigeSaldo = 400;
                textBoxSaldo.Text = ("€ 4,00");
            }
        }
        private void formcLOSEd()
        {
            _Form1.Getinfo();
        }
    }
}
