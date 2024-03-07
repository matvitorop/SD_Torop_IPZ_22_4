using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyIP
{
    public class Product
    {
        public Money price;

        private string name;

        private string description;

        public Product(Money price, string name, string description)
        {
            this.price = price;
            this.name = name;
            this.description = description;
        }

        public double getPrice()
        {
            return (double)price.getMainPart() + (double)price.getfractionalPart() / 100;
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
            this.name = name;
            return true;
        }
        public bool setDescription(string description)
        {
            this.description = description;
            return true;
        }

        public bool ReducePrice(double subtractor)
        {
            if (getPrice() - subtractor < 0)
            {
                return false;
            }
            else
            {

                double result = Math.Round(getPrice() - subtractor, 2);

                price.setMainPart((int)result);

                double fp = Math.Round(result - (int)result, 2) * 100;
                int fractionalPart = (int)fp;



                price.setFractionalPart(fractionalPart);

                return true;
            }
        }
    }
}
