# Software design Lab №1 
## Author: Torop Matvii, IPZ-22-4

- This lab was maded to use programming principles, that can improve understanding of clean and understandable code for all programmers.
- To demonstrate SOLID principles more cleanly, i made 5 separate catalogs for them in. Also, I made KISS, YAGNI and DRY principles in 1 class library `/KISS`, because, in my case they didn't interfere with each other.
- So `programming principles`, with which I worked:
  - [x] **Single responsibility**
  - [x] **Open/closed**
  - [x] **Liskov substitution**
  - [x] **Interface segregation**
  - [x] **Dependency inversion**
  - [x] **Keep it simple, stupid**
  - [x] **You aren`t gonna need it**
  - [x] **Don`t repeat yourself**
### [Single responsibility](./Single%20Resposibility)
Do demonstrate this principle of programming, I had to follow the rule that each class should do one task, so methods, that make another sphere field of activity, I put in another class with static methods. For example, for class `Money`, i made class [MoneyDefaultOperations](./Single%20Resposibility/MoneyDefaultOperations.cs#L11-L14), that print default info about class Money. Also, I did the same for class `Reporting`, where was placed methods for [Generating the report about warehouse](./Single%20Resposibility/ReportingManager.cs#L11), because another methods in `Reporting` works as simple get/set methods and for [Product](./Single%20Responsibility/ProductDefaultOperations.cs#L15), where I placed method for reducing the price of product.
### [Open/closed](./OpenClosed)
Main feature of this principle - class must be able to expansion, not for changing. So I developed interface `IMoney` with void method [PrintAmount](./OpenClosed/Money.cs#L5) due to different currency has self name of a `bill` and `kopeck`. Than i made abstarct class `Money` and then i can imitating this class by different currency, as [GBP](./OpenClosed/MoneyGBP.cs), [USD](./OpenClosed/MoneyUSD.cs) and [UAH](./OpenClosed/MoneyUAH.cs) and realizing new features for each currency. Also for this method i can link [ReportGenerators](./OpenClosed/IReportGenerate.cs#L9-L48), but this sctructure i suitable for `DIP principle`
### [Liskov substitution](./LiskovSP)
With this principle, a child class should complement, not change, the behavior of the parent class, so i showed it child class `LostedProduct`, that [working as](./LiskovSP/LostedProduct.cs) `Product` but have it`s own mathods, that just [expand features](./LiskovSP/LostedProduct.cs#L13-L22). 
### Interface segregation
Objects must not depend on methods they do not use. In this case, 3 interfaces instead of 1, that have `method of reporting` in [Console](./InterfaceSP/IReportConsole), [File](./InterfaceSP/IReportFile) or [Server](./InterfaceSP/IReportServer) and then i using interface that i need for specific class. 
### [Dependency inversion](./DependencyIP)
Higher entity mustn't depends on lower methods or features. It should be the other way around. So I made in [IReportGenerate](./DependencyIP/IReportGenerate.cs) few classes, that using interface `IReportGenerate` and then i created [ReportClient](./DependencyIP/IReportGenerate.cs#L50-L63) that using class with the parent class as an interface that we define in just [one piece of code](./DependencyIP/Reporting.cs#L73-L77). In this case, we do not depend on which class will be used.
### [Keep it simple, stupid](./KISS)
With this principle, code must be very simple, so, for example, i changed fields access on `internal` so, somewhere it can be easier to write the code, and simplified method [ReducePrice](./KISS/Product.cs#L82-L100). Also all `get/set methods` was changed on `properties` to make class more readable.
### [You aren`t gonna need it](./KISS)
In class mustn't be functionality that is not used, so i `deleted bool type` of get/set methods (properties). This principle is linked with previous, because both of them trying to make the code more easy and more readable, so transformig get/set methods into properties is also YAGNI impact.  
### [Don`t repeat yourself](./KISS)
This principle speaks for itself. From the beginning, method [FindWarehouse](./KISS/Reporting.cs#L52-L55) was created to `not copy code for finding elements in list`. Moreover, I made method [IsValidString](./KISS/Product.cs#L25-L28) to not copy string validation in methods.

**_Hope this code tutorial was useful for understanding structure of this solution. Please, send feedback for additional questions :)_**
