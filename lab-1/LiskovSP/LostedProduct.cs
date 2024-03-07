using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSP
{
    public class LostedProduct : Product
    {
        public LostedProduct(Money price, string name, string description): base(price, name, description) { }
        
        public void reducingWithInfo(double substract)
        {
            if (ReducePrice(substract))
            {
                Console.WriteLine("Reuducing the price was successful");
            }
            else
            {
                Console.WriteLine("Error. There is some problem in reducing the price. Perhaps, substract is bigger than price");
            }
        } 
    }
}
