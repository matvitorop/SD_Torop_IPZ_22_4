using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyIP
{
    public interface IReportGenerate
    {
        void GenerateInventoryReport(Reporting reporting);
    }

    public class TextReport : IReportGenerate
    {
        public void GenerateInventoryReport(Reporting reporting)
        {
            Console.WriteLine("Inventory Report in Text:");
            foreach (Warehouse warehouse in reporting.getWarehouseList())
            {
                Console.WriteLine($"Product: {warehouse.product.getName()}, Amount: {warehouse.getAmount()}, Unit: {warehouse.getUnit()}, Last Delivery: {warehouse.getlastDelivery()}");
            }
        }
    }

    public class PDFReport : IReportGenerate
    {
        public void GenerateInventoryReport(Reporting reporting)
        {
            Console.WriteLine("Inventory Report in PDF:");
            foreach (Warehouse warehouse in reporting.getWarehouseList())
            {
                Console.WriteLine($"Product: {warehouse.product.getName()}, Amount: {warehouse.getAmount()}, Unit: {warehouse.getUnit()}, Last Delivery: {warehouse.getlastDelivery()}");
            }
        }
    }

    public class JSONReport : IReportGenerate
    {
        public void GenerateInventoryReport(Reporting reporting)
        {
            Console.WriteLine("Inventory Report in JSON:");
            foreach (Warehouse warehouse in reporting.getWarehouseList())
            {
                Console.WriteLine($"Product: {warehouse.product.getName()}, Amount: {warehouse.getAmount()}, Unit: {warehouse.getUnit()}, Last Delivery: {warehouse.getlastDelivery()}");
            }
        }
    }

    public class ReportClient
    {
        private readonly IReportGenerate reportGenerator;

        public ReportClient(IReportGenerate reportGenerator)
        {
            this.reportGenerator = reportGenerator;
        }

        public void GenerateInventoryReport(Reporting reporting)
        {
            reportGenerator.GenerateInventoryReport(reporting);
        }
    }
}
