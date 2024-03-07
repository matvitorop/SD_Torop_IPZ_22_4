using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public interface IReportGenerate
    {
        void GenerateInventoryReport (Reporting reporting, string target);
    }

    public class TextReport : IReportGenerate
    {
        public void GenerateInventoryReport(Reporting reporting, string target) 
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
        public void GenerateInventoryReport(Reporting reporting, string target)
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
        public void GenerateInventoryReport(Reporting reporting , string target)
        {
            Console.WriteLine("Inventory Report in JSON:");
            foreach (Warehouse warehouse in reporting.getWarehouseList())
            {
                Console.WriteLine($"Product: {warehouse.product.getName()}, Amount: {warehouse.getAmount()}, Unit: {warehouse.getUnit()}, Last Delivery: {warehouse.getlastDelivery()}");
            }
        }
    }

    public class ReportClient : IReportGenerate
    {
        public void GenerateInventoryReport(Reporting reporting, string target)
        {
            if(target == "text")
            {
                TextReport textReport = new TextReport();
                textReport.GenerateInventoryReport(reporting, "text");
            }else if(target == "pdf")
            {
                PDFReport pdfReport = new PDFReport();
                pdfReport.GenerateInventoryReport(reporting, "pdf");
            }
            else
            {
                JSONReport jsonReport = new JSONReport();
                jsonReport.GenerateInventoryReport(reporting, "json");
            }


        }
    }
}
