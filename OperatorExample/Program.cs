using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1;
            m1.Value = 25.14M;
            m1.Code = Currency.EUR;

            Money m2 = new Money(45.1M, Currency.EUR);

            var sum = m1 + m2;

            Console.WriteLine("{0} {1}", sum.Value, sum.Code.ToString());

        }
    }
}
