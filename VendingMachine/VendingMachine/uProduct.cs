using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class uProduct : UserControl
    {
        private Snoepmachine _parent;
        public uProduct(Snoepmachine parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        
        private string Aantal;
        private string Nummer;
        private string Prijs;
        public string ProductAantal
        {
            set
            {
                Aantal = value;
                label8.Text = "Aantal " + Aantal;
            }
            get
            {
                return Aantal;
            }

        }
        public string ProductNummer
        {
            set
            {
                Nummer = value;
                label7.Text = Nummer;
            }
            get
            {
                return Aantal;
            }

        }

        public string ProductPrijs
        {
            set
            {
                Prijs = value;
                label1.Text = "€" + Prijs;
            }
            get
            {
                return Prijs;
            }

        }

        public Image afbeelding
        {
            get
            {
                return pictureBox1.Image;


            }
            set
            {
                pictureBox1.Image = value;
            }
        }

    }
}
