# Software design Lab №2 
## Author: Torop Matvii, IPZ-22-4

- This lab was maded to use patterns of programming, that can improve understanding of clean and understandable code for all programmers.
- All patterns was separated on their own libary of classes and folders 
- So `patterns of programming`, with which I worked:
  - [x] **Factory method**
  - [x] **Abstract factory**
  - [x] **Singleton**
  - [x] **Prototype**
  - [x] **Builder**
### Factory method
In this pattern, I created abstract class Subscription, that describing behavior of subscription and [3 classes of different types of subscription](./Subscription/Subscriptions.cs#L19-L71) that `implement it`. Then I created `WebSite`, `MobileApp` and `ManagerCall` factories, that implement one interface `ISubscriptionFactoryMethod`, with [their own logic of creating](./Subscription/Factories.cs) of new subscriptions.
### Abstract factory
This pattern is similar to `Factory method` but have it`s own features. At first, i creating `interfaces of different gadgets` like smartphone, notebook, then i making [different gadgets](./AbstractFactory/Gadgets.cs#L18-L60) from different brands with different text in their method. At the second, i making factories by simmilar principle as gadgets, and in new factories, i [implement methods that returning gadgets by their father's type](./AbstractFactory/Factories.cs#L17-L50).
### Singleton
Principle of `Singleton`, that it mustn't be imitated and must be in one example. This is done with the help of `sealed type of class`, `field of class's type` and by method [GetInstance](./Singleton/Singleton.cs#L14-L27).
### Prototype
Prototype classes can cloning by themselfs and get attributes of this clones. So this class has constructor for [getting attributes of clones](./Prototypes/Prototypes.cs#L27-L38) and method for [returning themselfs](./Prototypes/Prototypes.cs#L40-L43) for another objescts with the same type.
### Builder
Builder was created for classes, that have really big structure, and can building them part by part. For [Person](./Builder/Person.cs) creating different builders as [HeroBuilder](./Builder/HeroBuilder.cs) and [EnemyBuilder](./Builder/EnemyBuilder.cs) that implement interface [IBuilder](./Builder/IBuilder.cs). Then, with help of class [Director](./Builder/Director.cs), we can creating different types of `Heroes`, by sending builders in `private` field with `builder type` and keeping an [fluent interface](./Builder/IBuilder.cs#L11-L16) at the same time. 

**_Hope this code tutorial was useful for understanding structure of this solution. Please, send feedback for additional questions :)_**
