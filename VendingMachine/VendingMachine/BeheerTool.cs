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

namespace VendingMachine
{
    public partial class BeheerTool : Form
    {

        public SqlDbConnection con;

        public BeheerTool()
        {
            InitializeComponent();
            mySqlConnection();
        }

        private void mySqlConnection()
        {

            con = new SqlDbConnection();
            con.SqlQuery("SELECT * FROM `producten`");
            dataGridView1.DataSource = con.QueryEx();


        }

        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(" Naam LIKE '{0}%'", searchTextBox.Text);

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            con = new SqlDbConnection();
            string NieuwVoorraad = textBoxVoorraad.Text;
            string Product = searchTextBox.Text;
            con.SqlQuery("UPDATE `producten` SET `Voorraad`=@Voorraad WHERE `Naam` =@produc");
            con.Cmd.Parameters.Add("@Voorraad", NieuwVoorraad);
            con.Cmd.Parameters.Add("@product", Product);
            con.NonQueryEx();
            mySqlConnection();

        }
    }
}
