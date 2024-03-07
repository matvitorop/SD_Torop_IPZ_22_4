using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Single_Resposibility
{
    public class ProductDefaultOperations
    {
        public static bool ReducePrice(Product product, double subtractor)
        {
            if (product.getPrice() - subtractor <0)
            {
                return false;
            }
            else
            {
                double result = Math.Round(product.getPrice() - subtractor, 2);

                product.price.setMainPart((int)result);

                double fp = Math.Round(result - (int)result, 2) * 100;
                int fractionalPart = (int)fp;



                product.price.setFractionalPart(fractionalPart);

                return true;
            }    
        }

    }
}
