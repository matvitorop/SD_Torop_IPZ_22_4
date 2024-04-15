# Software design Lab №4 
## Author: Torop Matvii, IPZ-22-4

- This lab was maded to use behavioral patterns of programming, that can make a code more readable and cleaner
- All patterns was separated on their own libary of classes
- So `patterns of programming`, with which I worked:
  - [x] **Chain of Responsibility**
  - [ ] **Mediator**
  - [ ] **Observer**
  - [ ] **Strategy**
  - [ ] **Momento**
### Chain of Responsibility
The main idea of this pattern is to `forward the problem to another class if the current one cannot solve it`. At first, I made [base interface](./CoR/IHandler.cs) and [base abstract handler](./CoR/BaseHandler.cs).
If handler containing next handler, and haven`t any solution, it starts own next handler. If it hadn't any next handlers, it prints default response. [Every handler had it's own logic](./CoR/HandlerLvl1.cs). 
