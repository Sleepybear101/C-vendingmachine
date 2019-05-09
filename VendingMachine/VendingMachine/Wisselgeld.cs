using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Wisselgeld

    {
        public int TotaalMunten { get; set; }
        public int TienCent { get; set; }
        public int TwintigCent { get; set; }
        public int VijftigCent { get; set; }
        public int Euro { get; set; }
        public int TweeEuro { get; set; }

        public void SetTotaalMunten(int Totaalmunten)

        {
            TotaalMunten = Totaalmunten;

            TienCent = Totaalmunten / 10;
            TotaalMunten = Totaalmunten - (TienCent * 10);

            TwintigCent = Totaalmunten / 20;
            TotaalMunten = Totaalmunten - (TwintigCent * 20);

            VijftigCent = Totaalmunten / 50;
            TotaalMunten = Totaalmunten - (VijftigCent * 50);

                 Euro = Totaalmunten / 100;
            TotaalMunten = Totaalmunten - (Euro * 100);

            TweeEuro = Totaalmunten / 200;
            TotaalMunten = Totaalmunten - (TweeEuro * 200);

        }
    }
}
