using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Resposibility
{
    public class MoneyDefaultOperations
    {
        public static void PrintAmount(Money money)
        {
            Console.WriteLine($"Total summ = {money.getMainPart()}.{money.getfractionalPart()}");
        }
    }
}
