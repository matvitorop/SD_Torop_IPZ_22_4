# Software design Lab №4 
## Author: Torop Matvii, IPZ-22-4

- This lab was maded to use behavioral patterns of programming, that can make a code more readable and cleaner
- All patterns was separated on their own libary of classes
- So `patterns of programming`, with which I worked:
  - [x] **Chain of Responsibility**
  - [ ] **Mediator**
  - [ ] **Observer**
  - [x] **Strategy**
  - [ ] **Momento**
### Chain of Responsibility
The main idea of this pattern is to `forward the problem to another class if the current one cannot solve it`. At first, I made [base interface](./CoR/IHandler.cs) and [base abstract handler](./CoR/BaseHandler.cs).
If handler containing next handler, and haven`t any solution, it starts own next handler. If it hadn't any next handlers, it prints default response. [Every handler had it's own logic](./CoR/HandlerLvl1.cs). 
### Strategy
Very simple pattern, where `context class` choosing from wich `strategy class` using businnes logic. In my realization, I made general interface [IImageLoading](./Strategy/IImageLoading.cs) whic has method `Load`, then I made 2 classes that implementing this class with their own logic. For example, class [InetImageLoad](./Strategy/InetImageLoad.cs), that must download image from the internet. After this, in program, with of some algorithms, program is [choosing wich of logic it will use](./patterns_test/Program.cs#L35-L44). This pattern is similar to `Bridge`, due to both of them can changing their logic by changing class with this logic.  
