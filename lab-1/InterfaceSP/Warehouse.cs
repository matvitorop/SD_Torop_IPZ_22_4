using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSP
{
    public class Warehouse
    {
        public Product product;

        private int amount;

        private string unit;

        private DateTime lastDelivery;

        public Warehouse(Product product, int amount, string unit, DateTime lastDelivery)
        {
            this.product = product;
            this.amount = amount;
            this.unit = unit;
            this.lastDelivery = lastDelivery;
        }

        public string getUnit()
        {
            return unit;
        }
        public int getAmount()
        {
            return amount;
        }
        public Product getProduct()
        {
            return product;
        }
        public DateTime getlastDelivery()
        {
            return lastDelivery;
        }

        public bool setUnit(string unit)
        {
            if (unit == "kg" || unit == "l")
            {
                this.unit = unit;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool setAmount(int amount)
        {
            if (amount >= 0)
            {
                this.amount = amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setDelivery(DateTime delivery)
        {
            if (delivery >= lastDelivery)
            {
                lastDelivery = delivery;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
