using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            uNummerPad1.OnUserControlButtonClicked += new uNummerPad.ButtonClickedEventHandler(uNummerPad1_OnUserControlButtonClicked);
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
        public DataRow dr;


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

                id = dr[1].ToString();
                Prijs = dr[2].ToString();
                Nummer = dr[8].ToString();
                Aantal = dr[4].ToString();

                proitem.ProductPrijs = Prijs;
                proitem.ProductNummer = Nummer;
                proitem.ProductAantal = Aantal;

                Img1 = byteArrayToImage(myImage);
                proitem.afbeelding = Img1;

                Productenlist.Add(proitem);

                idProducten.Add(id);
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

        protected void uNummerPad1_OnUserControlButtonClicked(object sender, EventArgs e)
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
    }
}
