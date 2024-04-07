# Software design Lab №3 
## Author: Torop Matvii, IPZ-22-4

- This lab was maded to use structural patterns of programming, that can make a code more readable and cleaner
- All patterns was separated on their own libary of classes
- So `patterns of programming`, with which I worked:
  - [x] **Adapter**
  - [x] **Decorator**
  - [x] **Bridge**
  - [ ] **Proxy**
  - [ ] **Composer**
  - [ ] **LightWeight**
### Adapter
This pattern must make `target class` (old class) and `adaptee class` (new class) adjacent to each other. It useful when they have different data types. I made target class [Logger](./Adapter/Logger.cs) , that print in console text with different context and color. Then, I made [FileWriter](./Adapter/FileWriter.cs) that working as commands `Write` and `WriteLine` on C#. After this, i made [FileWriterAdapter](./Adapter/FileWriterAdapter.cs) that `imatates Logger` and takes `FileWriter as a field`. In the end, I overriding methods from `Logger`, combining them with `FileWriter` methods and adding [old functionality](./Adapter/FileWriterAdapter.cs#L22) for example.  
### Decorator
Logic of decorator pattern - to create additional fuctionality for created or already used object. To create this logic, we must create decorator, that `have the same parent data type` as objects to modify. We can imagine this like new object, that enhances previous class and aggregates previous class to fill object, that we must improve. In my example, I created 3 classes (Palladin, Mage and Warrior) that implement [interface IHero](./Decorator/IHero.cs). Then i made [base decorator](./Decorator/HeroBaseDecorator.cs) that keeps IHero type object and have [virtual method for enhancing](./Decorator/HeroBaseDecorator.cs#L18-L21) and after that I made 2 decorators, that have their own logic. For example, decorator [WeaponDecorator](./Decorator/WeaponDecorator.cs). Also, as they `averyone have parent class IHero` they can [overlap one by one](./patterns_test/Program.cs#L29-L30) and with this we improve the functionality when we wont. 
### Bridge
Bridge pattern is useful to davide big functionality of massive classes. Unfortunately, or luckily, this example is not huge to represent all functionality of this structural pattern. So I made class [Shape](./Bridge/Shape.cs) that `will be parent class` for different shapes. Besides, this class keeping object with major type [IRender](./Bridge/IRender.cs) that can include different types of rendering. Then, I made classes that implement `interface IRander` [RasterRender](./Bridge/RasterRender.cs) and [VectorRender](./Bridge/VectorRender.cs) with their own logic. At the end, i made 3 shapes, that inheritate class `Shape` and `using methods from IRender` to do some logic. Example you can see [here](./Bridge/Circle.cs#L15-L18). As the result we can adding different types of rendering for shapes, and can changing them when we want. Also this pattern reminds me an old music player, where you need change a disc to hear another music.
