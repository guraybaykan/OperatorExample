using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
    public class DifferentCurrencyException : Exception
    {
        public string[] CurrencyCodes;

        public DifferentCurrencyException(params Currency[] codes)
        {
            CurrencyCodes = codes.Select(x => x.ToString()).ToArray();
        }

        public override string Message
        {
            get
            {
                return "Farklı dövizler arasında işlem yapılamaz.";
            }
        }
    }
}
