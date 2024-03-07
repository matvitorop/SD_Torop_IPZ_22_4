namespace KISS
{
    public class Reporting
    {
        private List<Warehouse> warehouseList;

        public Reporting()
        {
            warehouseList = new List<Warehouse>();
        }

        public List<Warehouse> GetWarehouseList()
        {
            return warehouseList;
        }

        public void RegisterIncoming(Product product, int amount, string unit, DateTime deliveryDate)
        {
            Warehouse existingWarehouse = FindWarehouse(product);

            if (existingWarehouse != null)
            {
                existingWarehouse.Amount += amount;
                existingWarehouse.LastDelivery = deliveryDate;
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
                existingWarehouse.Amount -= amount;
                if (existingWarehouse.Amount < 0)
                {
                    throw new InvalidOperationException("Not enough quantity in stock to fulfill the outgoing request.");
                }
            }
            else
            {
                throw new InvalidOperationException("Product not found in the warehouse.");
            }
        }

        //ВИКОРИСТАННЯ ПРИНЦИПУ DRY
        private Warehouse FindWarehouse(Product product)
        {
            return warehouseList.FirstOrDefault(warehouse => warehouse.Product.Equals(product));
        }

        //ЗМІНА ПОВТОРЮВАНОГО КОДУ З ВИКОРИСТАННЯМ DRY
        private void PrintInventoryLine(string productName, int amount, string unit, DateTime lastDelivery)
        {
            Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-20}", productName, amount, unit, lastDelivery);
        }

        public void GenerateInventoryReport()
        {
            Console.WriteLine("Inventory Report:");
            Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-20}", "Product", "Amount", "Unit", "Last Delivery");
            foreach (Warehouse warehouse in warehouseList)
            {
                PrintInventoryLine(warehouse.Product.Name, warehouse.Amount, warehouse.Unit, warehouse.LastDelivery);
            }
        }
    }
}
