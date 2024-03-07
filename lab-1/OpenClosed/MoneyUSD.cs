using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class MoneyUSD : Money
    {
        public MoneyUSD(int mainPart, int fractionalPart) : base(mainPart, fractionalPart)
        {
        }
        public override void PrintAmount() 
        {
            Console.WriteLine($"Total summ = {getMainPart()} dollars and {getFractionalPart()} cents");
        }
    }
}
