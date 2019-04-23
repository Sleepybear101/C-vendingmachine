using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        public SqlDbConnection con;
        List<uProduct> Productenlist;
        List<string> idProducten;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetProduct()
        {
            con = new SqlDbConnection();
            flowLayoutPanel1.Controls.Clear();

            Productenlist = new List<uProduct>();
            idProducten = new List<string>();
            con.SqlQuery("SELECT * FROM `producten` INNER JOIN `systeem` ON producten.id_product=systeem.Product");
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                uProduct proitem = new uProduct(this);

                byte[] myImage = (byte[])dr[5];

                string id = dr[1].ToString();
                string Prijs = dr[2].ToString();
                string Nummer = dr[8].ToString();
                string Aantal = dr[4].ToString();

                proitem.ProductPrijs = Prijs;
                proitem.ProductNummer = Nummer;
                proitem.ProductAantal = Aantal;
                //proitem.afbeelding = new Bitmap(new MemoryStream(myImage));
                //pictureBox1.Image = new Bitmap(new MemoryStream(myImage));
                Productenlist.Add(proitem);
                idProducten.Add(id);
              // Image newImage = byteArrayToImage(image);

            }
                flowLayoutPanel1.Controls.AddRange(Productenlist.ToArray());

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
 MessageBox.Show("Show");
            SetProduct();
        }
    }
}
