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
    public partial class BeheerTool : Form
    {
        public SqlDbConnection con;

        public BeheerTool()
        {
            InitializeComponent();
            GetInfo();
        }

        private void BeheerTool_Load(object sender, EventArgs e)
        {

        }

        DataTable table = new DataTable();
    

        private void GetInfo()
        {
        /*    con = new SqlDbConnection();
          MySqlDataAdapter ada    = new MySqlDataAdapter(con.SqlQuery("SELECT `id_product`,`Naam`,`Prijs`,`AantalGekocht`,`Voorraad`  FROM snoepmachine.producten"));

            DataSet ds = new DataSet();
            adapter.Fill(ds, "producten");
            dataGridView1.DataSource = ds.Tables["producten"];
         

                dataGridView1.DataSource = ds.Tables["producten"];


            }

    */
        }

    }
}
