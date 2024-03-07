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

        protected string name;

        protected string description;

        public Product(Money price, string name, string description)
        {
            this.price = price;
            this.name = name;
            this.description = description;
        }
        
        //ЗМІНА ПОВТОРЮВАНОГО КОДУ З ВИКОРИСТАННЯМ DRY
        private bool IsValidString(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        //СПРОЩЕНИЙ НЕПОТРІБНИЙ ФУНКЦІОНАЛ GET/SET ЗА ДОПОМОГОЮ YAGNI
        public double Price
        {
            get { return (double)price.MainPart + (double)price.FractionalPart / 100; }
            set 
            { 
                price.MainPart = (int)value;
                price.FractionalPart = (int)((value - (int)value) * 100);
            }
        }
        

        //СПРОЩЕНИЙ НЕПОТРІБНИЙ ФУНКЦІОНАЛ GET/SET ЗА ДОПОМОГОЮ YAGNI
        public string Name
        {
            get { return name; }
            set
            {
                if (IsValidString(value))
                {
                    this.name = value;   
                }
            }
        }
        
        //СПРОЩЕНИЙ НЕПОТРІБНИЙ ФУНКЦІОНАЛ GET/SET ЗА ДОПОМОГОЮ YAGNI
        public string Description
        {
            get { return description; }
            set
            {
                if (IsValidString(value))
                {
                    this.description = value;
                }
            }
        }

        //СПРОЩЕНИЙ НЕПОТРІБНИЙ ФУНКЦІОНАЛ GET/SET ЗА ДОПОМОГОЮ YAGNI
        public void ReducePrice(double amount)
        {

            double newPrice = Price - amount;
            if (newPrice >= 0)
            {
                Price  = newPrice;

                //setPrice((int)newPrice, (int)((newPrice - (int)newPrice) * 100));
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
