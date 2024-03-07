# Software design Lab №1 
## Author: Torop Matvii

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
### Single responsibility
Do demonstrate this principle of programming, I had to follow the rule that each class should do one task, so methods, that make another sphere field of activity, I put in another class with static methods. For example, for class `Money`, i made class [MoneyDefaultOperations](./SingleResponsibility/MoneyDefaultOperations.cs#L11-L14), that print default info about class Money. Also, I did the same for class `Reporting`, where was placed methods for [Generating the report about warehouse](./ReportingMenager.cs#L11), because another methods in `Reporting` works as simple get/set methods and for [Product](./ProductDefaultOperations.cs#L15), where I placed method for reducing the price of product.
### Open/closed
Main feature of this principle - class must be able to expansion, not for changing. So I developed interface `IMoney` with void method [PrintAmount](./Open)


### Liskov substitution
### Interface segregation
### Dependency inversion
### Keep it simple, stupid
### You aren`t gonna need it
### Don`t repeat yourself
