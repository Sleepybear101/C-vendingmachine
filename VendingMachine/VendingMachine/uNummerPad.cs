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
    public partial class uNummerPad : UserControl
    {

        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler OnUserControlButtonClicked;

        public uNummerPad()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
      
          

            Button btnNumber = sender as Button;
            switch (btnNumber.Text)
            {
                case "0":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "1":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "2":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "3":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "4":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "5":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "6":
                    OnUserControlButtonClicked(btnNumber, e);
                    break;
                case "7":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "8":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "9":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "A":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "B":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "C":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "D":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "E":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;
                case "Back":
                    OnUserControlButtonClicked(btnNumber, e);
                    MyGlobal.bTouch = false;
                    break;

            
            }
       }
    }
}
