using Single_Resposibility;
using System.Data.SqlTypes;
using OpenClosed;
using LiskovSP;
using InterfaceSP;
using DependencyIP;
using KISS;

//====================================ВИКОРИСТАНННЯ ПРИНЦИПУ SINGLE RESPONSIBILITY====================================
Console.WriteLine("\n\nВИКОРИСТАНННЯ ПРИНЦИПУ SINGLE RESPONSIBILITY");
//КЛАС Money
Single_Resposibility.Money money = new Single_Resposibility.Money(30, 15);
Single_Resposibility.MoneyDefaultOperations.PrintAmount(money);

money.setMainPart(10);
money.setFractionalPart(20);

Single_Resposibility.MoneyDefaultOperations.PrintAmount(money);

//КЛАС Product
Single_Resposibility.Product product = new Single_Resposibility.Product(money, "Манго", "Смачна та поживна їжа");
Single_Resposibility.Product product1 = new Single_Resposibility.Product(money, "Банан", "Смачний та корисний фрукт");

Console.WriteLine(product.getName());

Single_Resposibility.ProductDefaultOperations.ReducePrice(product, 9.15);

Console.WriteLine(product.getPrice());

//КЛАС Warehouse
Single_Resposibility.Warehouse warehouse = new Single_Resposibility.Warehouse(product, 10, "kg", DateTime.Now);

if (warehouse.setDelivery(DateTime.Now))
{
    Console.WriteLine("Successfull delivery update");
}

//КЛАС Reporting

Single_Resposibility.Reporting mainreport = new Single_Resposibility.Reporting();
mainreport.RegisterIncoming(product, 10, "kg", DateTime.Now);
mainreport.RegisterIncoming(product1, 12, "kg", DateTime.Now);

Single_Resposibility.ReportingManager.GenerateInventoryReport(mainreport);





//====================================ВИКОРИСТАНННЯ ПРИНЦИПУ OPEN-CLOSED principle====================================

//СТВОРЕННЯ ДОЧІРНІХ КЛАСІВ З КОНКРЕТНОЮ ВАЛЮТОЮ
Console.WriteLine("\n\nВИКОРИСТАНННЯ ПРИНЦИПУ OPEN-CLOSED principle");
OpenClosed.MoneyGBP moneyGBP = new OpenClosed.MoneyGBP(25, 34);
OpenClosed.MoneyUSD moneyUSD = new OpenClosed.MoneyUSD(50, 12);
OpenClosed.MoneyUAH moneyUAH = new OpenClosed.MoneyUAH(100, 15);

moneyGBP.PrintAmount();
moneyUSD.PrintAmount();
moneyUAH.PrintAmount();


OpenClosed.Money money_second = new OpenClosed.MoneyUSD(30, 15);
OpenClosed.Product product_second = new OpenClosed.Product(money_second, "Манго", "Смачна та поживна їжа");
OpenClosed.Product product1_second = new OpenClosed.Product(money_second, "Банан", "Смачний та корисний фрукт");

OpenClosed.Reporting report_second = new OpenClosed.Reporting();

report_second.RegisterIncoming(product_second, 10, "kg", DateTime.Now);
report_second.RegisterIncoming(product1_second, 12, "kg", DateTime.Now);

//ПЕРЕВІРКА ВИКЛАДЕННЯ РЕПОРТУ З ВИКОРИСТАННЯМ ПРИНЦИПУ
report_second.GenerateInventoryReport();
report_second.GenerateInventoryReport();




//====================================ВИКОРИСТАНННЯ ПРИНЦИПУ LISKOV Substitution principle====================================
Console.WriteLine("\n\nВИКОРИСТАНННЯ ПРИНЦИПУ LISKOV Substitution principle");
//ВИКОРИСТАННЯ ДОЧІРНЬОГО КЛАСУ ВІД Product З ДОТРИМАННЯМ ПРИНЦИПУ
LiskovSP.Money money_third = new LiskovSP.Money(30, 15);
LiskovSP.Money money1_third = new LiskovSP.Money(30, 15);

LiskovSP.Product product_third = new LiskovSP.Product(money_third, "Манго", "Смачна та поживна їжа");
LiskovSP.LostedProduct product1_third = new LiskovSP.LostedProduct(money1_third, "Банан", "Жовтий і довгий фрукт");

product_third.ReducePrice(9.30);

product1_third.reducingWithInfo(40.30);
product1_third.reducingWithInfo(4.30);

Console.WriteLine(product_third.getPrice());
Console.WriteLine(product1_third.getPrice());

//====================================ВИКОРИСТАНННЯ ПРИНЦИПУ INTERFACES Sergregation principle====================================
Console.WriteLine("\n\nВИКОРИСТАНННЯ ПРИНЦИПУ INTERFACES Sergregation principle");

InterfaceSP.Money money_fourth = new InterfaceSP.Money(100, 15);

InterfaceSP.Product product_fourth = new InterfaceSP.Product(money_fourth, "Манго", "Смачна та поживна їжа");
InterfaceSP.Product product1_fourth = new InterfaceSP.Product(money_fourth, "Банан", "Смачний та корисний фрукт");

InterfaceSP.Reporting report_fourth = new InterfaceSP.Reporting();

report_fourth.RegisterIncoming(product_fourth, 10, "kg", DateTime.Now);
report_fourth.RegisterIncoming(product1_fourth, 12, "kg", DateTime.Now);

report_fourth.ReportToConsole();


//====================================ВИКОРИСТАНННЯ ПРИНЦИПУ DEPENDENCY inversion principle====================================
Console.WriteLine("\n\nВИКОРИСТАНННЯ ПРИНЦИПУ DEPENDENCY inversion principle");
DependencyIP.Money money_fifth = new DependencyIP.Money(100, 15);

DependencyIP.Product product_fifth = new DependencyIP.Product(money_fifth, "Манго", "Смачна та поживна їжа");
DependencyIP.Product product1_fidth = new DependencyIP.Product(money_fifth, "Банан", "Смачний та корисний фрукт");

DependencyIP.Reporting report_fifth = new DependencyIP.Reporting();

report_fifth.RegisterIncoming(product_fifth, 10, "kg", DateTime.Now);
report_fifth.RegisterIncoming(product1_fidth, 12, "kg", DateTime.Now);

report_fifth.GenerateInventoryReport();


//====================================ВИКОРИСТАНННЯ ПРИНЦИПУ KEEP IT SIMPLE, STUPID====================================
Console.WriteLine("\n\nВИКОРИСТАНННЯ ПРИНЦИПУ KEEP IT SIMPLE, STUPID");

KISS.Money money_sixth = new KISS.Money(100, 15);

KISS.Product product_sixth = new KISS.Product(money_sixth, "Манго", "Смачна та поживна їжа");
KISS.Product product1_sixth = new KISS.Product(money_sixth, "Банан", "Смачний та корисний фрукт");
product1_sixth.ReducePrice(10.30);
Console.WriteLine(product1_sixth.getPrice());

KISS.Reporting report_sixth = new KISS.Reporting();

report_sixth.RegisterIncoming(product_sixth, 10, "kg", DateTime.Now);
report_sixth.RegisterIncoming(product1_sixth, 12, "kg", DateTime.Now);

report_sixth.GenerateInventoryReport();