using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Resposibility
{
    public class Reporting
    {
        private List<Warehouse> warehouseList;

        public Reporting()
        {
            warehouseList = new List<Warehouse>();
        }
        //ОСКІЛЬКИ ДАНІ ФУНКЦІЇ ПРАЦЮЮТЬ ЯК ПОВНОЦІННІ GET/SET, СЕНСУ СТВОРЮВАТИ ДЛЯ НИХ ОКРЕМИЙ КЛАС НЕМАЄ
        public List<Warehouse> getWarehouseList()
        {
            return warehouseList;
        }

        public void RegisterIncoming(Product product, int amount, string unit, DateTime deliveryDate)
        {
            Warehouse existingWarehouse = FindWarehouse(product);

            if (existingWarehouse != null)
            {
                existingWarehouse.setAmount(existingWarehouse.getAmount() + amount);
                existingWarehouse.setDelivery(deliveryDate);
            }
            else
            {
                Warehouse newWarehouse = new Warehouse(product, amount, unit, deliveryDate);
                warehouseList.Add(newWarehouse);
            }
        }

        public void RegisterOutgoing(Product product, int amount)
        {
            Warehouse existingWarehouse = FindWarehouse(product);

            if (existingWarehouse != null)
            {
                int newAmount = existingWarehouse.getAmount() - amount;
                if (newAmount >= 0)
                {
                    existingWarehouse.setAmount(newAmount);
                }
                else
                {
                    Console.WriteLine("Not enough quantity in stock to fulfill the outgoing request.");
                }
            }
            else
            {
                Console.WriteLine("Product not found in the warehouse.");
            }
        }

        private Warehouse FindWarehouse(Product product)
        {
            foreach (Warehouse warehouse in warehouseList)
            {
                if (warehouse.getProduct().Equals(product))
                {
                    return warehouse;
                }
            }
            return null;
        }
    }
}
