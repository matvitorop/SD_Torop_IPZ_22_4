using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS
{
    public class Product
    {
        public Money price;

        internal string name;

        internal string description;

        public Product(Money price, string name, string description)
        {
            this.price = price;
            this.name = name;
            this.description = description;
        }

        public double getPrice()
        {
            return (double)price.getMainPart() + (double)price.getFractionalPart() / 100;
        }

        public string getName()
        {
            return name;
        }
        public string getDescription()
        {
            return description;
        }

        public bool setPrice(int mainPart, int fractPart)
        {
            price.setMainPart(mainPart);
            price.setFractionalPart(fractPart);

            return true;
        }
        public bool setName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
                return true;
            }
            return false;
        }
        public bool setDescription(string description)
        {   
            this.description = description;
            return true;
        }

        public void ReducePrice(double amount)
        {

            double newPrice = getPrice() - amount;
            if (newPrice >= 0)
            {
                setPrice((int)newPrice, (int)((newPrice - (int)newPrice) * 100));
            }

            //НЕПОТРІБНИЙ КОД, СПРОЩЕНИЙ ЗА ДОПОМОГОЮ ПРИНЦИПУ KISS:

            //if (getPrice() - subtractor < 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    double result = Math.Round(getPrice() - subtractor, 2);
            //
            //    price.setMainPart((int)result);
            //
            //    double fp = Math.Round(result - (int)result, 2) * 100;
            //    int fractionalPart = (int)fp;
            //
            //
            //
            //    price.setFractionalPart(fractionalPart);
            //
            //    return true;
            //}
        }
    }
}
