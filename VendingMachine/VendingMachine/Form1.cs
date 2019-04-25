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
    public partial class Form1 : Form
    {
        public SqlDbConnection con;
        Image returnImage;
        List<uProduct> Productenlist;
        List<string> idProducten;
        string name;
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

                //byte[] myImage = (byte[])dr[5];
                

                string id = dr[1].ToString();
                string Prijs = dr[2].ToString();
                string Nummer = dr[8].ToString();
                string Aantal = dr[4].ToString();

                proitem.ProductPrijs = Prijs;
                proitem.ProductNummer = Nummer;
                proitem.ProductAantal = Aantal;
                //Image img1 = byteArrayToImage(myImage);
                //proitem.afbeelding = img1;
                //pictureBox1.Image = new Bitmap(new MemoryStream(myImage));
                Productenlist.Add(proitem);
                idProducten.Add(id);
          
            }
                flowLayoutPanel1.Controls.AddRange(Productenlist.ToArray());
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return returnImage;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            SetProduct();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BeheerTool Beheerder = new BeheerTool();
            Beheerder.ShowDialog();
     
        }
    }
}
