using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Resposibility
{
    public class ReportingManager
    {
        public static void GenerateInventoryReport(Reporting reporting)
        {
            Console.WriteLine("Inventory Report:");
            foreach (Warehouse warehouse in reporting.getWarehouseList())
            {
                Console.WriteLine($"Product: {warehouse.product.getName()}, Amount: {warehouse.getAmount()}, Unit: {warehouse.getUnit()}, Last Delivery: {warehouse.getlastDelivery()}");
            }
        }

    }
}
