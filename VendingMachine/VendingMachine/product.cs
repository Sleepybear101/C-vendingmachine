using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VendingMachine
{
    class product
    {


    }
}

/*
   public class GetProduct 
    {
        SqlDbConnection con;
        public string Nummer;
        public string Prijs;
        public string id;
        public string Aantal;
        public Image Img1;

        Image returnImage;
        List<uProduct> Productenlist;
        List<string> idProducten;
        public DataRow dr;


        public void AlleProduct()
        {
            SqlDbConnection con = new SqlDbConnection();
            Productenlist = new List<uProduct>();
            idProducten = new List<string>();
            con.SqlQuery("SELECT * FROM `producten` INNER JOIN `systeem` ON producten.id_product=systeem.Product");
            foreach (DataRow dr in con.QueryEx().Rows)
            {
             uProduct proitem = new uProduct(this);

                byte[] myImage = (byte[]) dr[5];


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
        */