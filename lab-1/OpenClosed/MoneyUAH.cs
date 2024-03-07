using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class MoneyUAH : Money
    {
        public MoneyUAH(int mainPart, int fractionalPart) : base(mainPart, fractionalPart)
        {
        }
        public override void PrintAmount() // Override the method from the base class
        {
            Console.WriteLine($"Total summ = {getMainPart()} hryvnas and {getFractionalPart()} kopiyok");
        }
    }
}
