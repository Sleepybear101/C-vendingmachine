using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ConvertCurrency
    {
        public int ConvertCurrencyToInt(string currencyValue)
        {
            var currentBalanceWithoutCurrency = currencyValue.Substring(2, currencyValue.Length - 2);

            var decimalCurrentBalanceWithoutCurrency = decimal.Parse(currentBalanceWithoutCurrency);

            var decimalToIntCurrentBalanceWithoutCurrency = decimalCurrentBalanceWithoutCurrency * 100;

            var intCurrentBalance = decimal.ToInt32(decimalToIntCurrentBalanceWithoutCurrency);

            int currentBalanceValue = Int32.Parse(intCurrentBalance.ToString());

            return currentBalanceValue;
        }

        internal object CurrencyToInt(string text)
        {
            throw new NotImplementedException();
        }
    }
}
