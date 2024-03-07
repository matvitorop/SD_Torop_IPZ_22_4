using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class MoneyGBP : Money
    {
        public MoneyGBP(int mainPart, int fractionalPart) : base(mainPart, fractionalPart)
        {

        }
        public override void PrintAmount()
        {
            Console.WriteLine($"Total summ = {getMainPart()} pounds and {getFractionalPart()} pence");
        }
    }
}
