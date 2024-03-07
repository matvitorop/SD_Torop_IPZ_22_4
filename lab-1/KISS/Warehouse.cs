using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS
{
    public class Warehouse
    {
        internal Product product;
        internal int amount;
        internal string unit;
        internal DateTime lastDelivery;

        public Warehouse(Product product, int amount, string unit, DateTime lastDelivery)
        {
            this.product = product;
            this.amount = amount;
            this.unit = unit;
            this.lastDelivery = lastDelivery;
        }

        public string Unit
        {
            get { return unit; }
            set
            {
                if (value == "kg" || value == "l")
                {
                    unit = value;
                }
            }
        }

        public int Amount
        {
            get { return amount; }
            set
            {
                if (value >= 0)
                {
                    amount = value;
                }
            }
        }

        public DateTime LastDelivery
        {
            get { return lastDelivery; }
            set
            {
                if (value >= lastDelivery)
                {
                    lastDelivery = value;
                }
            }
        }

        public Product Product
        {
            get { return product; }
        }

        public void SetProduct(Product newProduct)
        {
            product = newProduct;
        }
    }
}
