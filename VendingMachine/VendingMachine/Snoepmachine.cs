using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VendingMachine
{
    public partial class Snoepmachine : Form
    {
        public Snoepmachine()
        {
            InitializeComponent();
            pnlProduct.Controls.Clear();
            uNummerPad2.OnUserControlButtonClicked += new uNummerPad.ButtonClickedEventHandler(uNummerPad2_OnUserControlButtonClicked);
             Getinfo();
        }

        SqlDbConnection con;
        public string Nummer;
        public string Prijs;
        public string id;
        public string Aantal;
        public Image Img1;

        private TextBox focusedTextbox = null;

        Image returnImage;
        List<uProduct> Productenlist;
        List<string> idProducten;

        public double prijsProduct;
        public string Voorraadl;
        public double HuidigeSaldo;
        public void Getinfo()
        {
            SqlDbConnection con = new SqlDbConnection();
            Productenlist = new List<uProduct>();
            idProducten = new List<string>();
            con.SqlQuery("SELECT * FROM `producten` INNER JOIN `systeem` ON producten.id_product=systeem.Product");

            foreach (DataRow dr in con.QueryEx().Rows)
            {
                uProduct proitem = new uProduct(this);

                byte[] myImage = (byte[])dr[5];

                Prijs = dr[2].ToString();
                Nummer = dr[8].ToString();
                Aantal = dr[4].ToString();

                proitem.ProductPrijs = Prijs;
                proitem.ProductNummer = Nummer;
                proitem.ProductAantal = Aantal;

                Img1 = byteArrayToImage(myImage);
                proitem.afbeelding = Img1;

                Productenlist.Add(proitem);

                idProducten.Add(Nummer);
            }
            pnlProduct.Controls.AddRange(Productenlist.ToArray());
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true); //Exception occurs here
            }
            catch
            {
            }

            return returnImage;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            BeheerTool Beheerder = new BeheerTool();
            Beheerder.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxNummer;
            textBoxNummer.Focus();
            labelSaldoUser.Text = "€ 0,00";
        }
      
    private void textBoxNummer_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }

        private void ButtonOpwaarderenSaldo_Click(object sender, EventArgs e)
        {
            var myForm = new SaldoOpwaarderen(this);
            myForm.Show();
        }

        protected void uNummerPad2_OnUserControlButtonClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (focusedTextbox != null)
            {
                if (b.Text == "Back")
                {
                    if (focusedTextbox.Text.Length > 1)
                    {
                        focusedTextbox.Text = focusedTextbox.Text.Substring(0, focusedTextbox.Text.Length - 1);
                    }
                    else
                    {
                        focusedTextbox.Text = string.Empty;
                    }
                }
                else
                {
                    if (MyGlobal.bTouch)
                        focusedTextbox.Text = b.Text;
                    else
                    {
                        MyGlobal.bTouch = false;
                        focusedTextbox.Text += b.Text;
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (labelSaldoUser.Text == "€ 0,00")
            {
                string message = "Om wisselgeld terug te krijgen moet u eerst uw saldo verhogen. Wilt u uw Saldo verhogen?";
                string title = "Uw saldo is leeg";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var myForm = new SaldoOpwaarderen(this);
                    myForm.Show();
                }
            }

            else
            {
                labelWisselgeld.Text = labelSaldoUser.Text;
                labelSaldoUser.Text = "€ 0,00";
                labelWisselgeld.Text = "€ 0,00";
                MessageBox.Show("Wisselgeld is teruggestort");

            }

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            SqlDbConnection con = new SqlDbConnection();

            if (idProducten.Contains(textBoxNummer.Text))
            {
                MessageBox.Show("product gevonden met het zelfde productnummer");

                con.SqlQuery("SELECT `Prijs`, `Id_product`, `Voorraad` FROM `producten` INNER JOIN `systeem` ON producten.id_product=systeem.Product where `Productnummer` = 'A12' ");
               
                     foreach (DataRow dr in con.QueryEx().Rows)
                      {
                  
                          prijsProduct = Convert.ToDouble(dr[0]);
                          HuidigeSaldo = Convert.ToDouble(labelSaldoUser.Text);
                          HuidigeSaldo =-  prijsProduct  ;
                      }
                
            }
            else
            {
                MessageBox.Show("Geen product gevonden met het zelfde productnummer");
            }
        }
    }
}
