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
        public int Voorraadl;
        public double HuidigeSaldo;

        public byte[] myImage;
        //Ophalen van producten voor usercontrol
        public void Getinfo()
        {
            SqlDbConnection con = new SqlDbConnection();
            Productenlist = new List<uProduct>();
            idProducten = new List<string>();
            con.SqlQuery("SELECT * FROM `producten` INNER JOIN `systeem` ON producten.id_product=systeem.Product");

            foreach (DataRow dr in con.QueryEx().Rows)
            {
                uProduct proitem = new uProduct(this);

                myImage = (byte[])dr[4];

                Prijs = (Convert.ToDouble(dr[2]) / 100).ToString("C");
                Nummer = dr[7].ToString();
                Aantal = dr[3].ToString();

                proitem.ProductPrijs = Prijs;
                proitem.ProductNummer = Nummer;
                proitem.ProductAantal = Aantal;

                Img1 = byteArrayToImage(myImage);
                proitem.afbeelding = Img1;

                Productenlist.Add(proitem);

                idProducten.Add(Nummer);
            }
            pnlProduct.Controls.Clear();
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
        //Knop naar beheerdertool
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxNummer;
            textBoxNummer.Focus();
            labelSaldoUser.Text = "0,00";
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
        //Wisselgeld
        private void Button1_Click(object sender, EventArgs e)
        {
            if (labelSaldoUser.Text == "0,00" ||labelSaldoUser.Text == "€ 0,00")
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
                labelWisselgeldUser.Text = labelSaldoUser.Text;
                labelSaldoUser.Text = "€ 0,00";
                MessageBox.Show("Wisselgeld is teruggestort");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gebruiker\Desktop\Sound\Refund.wav");
                player.Play();
            }
        }

        // kopen van product
        private void Button16_Click_1(object sender, EventArgs e)
        {
            SqlDbConnection con = new SqlDbConnection();

            if (idProducten.Contains(textBoxNummer.Text))
            {
          
                con.SqlQuery("SELECT `Prijs`, `Id_product`, `Voorraad` ,`Afbeelding`FROM `producten` INNER JOIN `systeem` ON producten.id_product=systeem.Product where `Productnummer` =@nummer ");
                con.Cmd.Parameters.Add("@Nummer", textBoxNummer.Text);

                foreach (DataRow dr in con.QueryEx().Rows)
                {
                    ConvertCurrency convert = new ConvertCurrency();

                    prijsProduct = Convert.ToDouble(dr[0]);
                    Voorraadl = Convert.ToInt32(dr[2]);
                    Nummer = dr[1].ToString();
                    myImage = (byte[])dr[3];
                  
                    HuidigeSaldo = convert.ConvertCurrencyToInt(labelSaldoUser.Text);
                }

                if ( HuidigeSaldo >= prijsProduct )
                {
                    Voorraadl = Voorraadl - 1;
                    labelSaldoUser.Text = (Convert.ToDouble(HuidigeSaldo - prijsProduct) / 100).ToString("C");
                    con.SqlQuery("UPDATE `producten` SET `Voorraad`=@Voorraad WHERE `id_product`=@Nummer ");
                    con.Cmd.Parameters.Add("@Voorraad", Voorraadl);
                    con.Cmd.Parameters.Add("@Nummer", Nummer);

                    con.NonQueryEx();

                    con.SqlQuery("INSERT INTO `gekochtproduct`(`Product`, `Datetime`) VALUES (@Nummer,NOW())");
                    con.Cmd.Parameters.Add("@Nummer", Nummer);
                    con.NonQueryEx();
                    Img1 = byteArrayToImage(myImage);
                    button19.BackgroundImage = Img1;

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gebruiker\Desktop\Sound\Buy.wav");
                    player.Play();


                }
                else if(Voorraadl <= 0)
                {

                    MessageBox.Show("Voorraad te laag");
                } 
                else
                {
                    MessageBox.Show("Saldo te laag");
                }
            }
            else
            {
                MessageBox.Show("Geen product gevonden met het zelfde productnummer");
            }
            Getinfo();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BeheerTool Beheerder = new BeheerTool();
            Beheerder.ShowDialog();

        }

        private void Button19_Click(object sender, EventArgs e)
        {

            button19.BackgroundImage = null;
        }
    }
}
