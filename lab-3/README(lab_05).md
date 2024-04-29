# Software design Lab №5 
## Author: Torop Matvii, IPZ-22-4

- This lab was maded to use behavioral patterns of programming, that can make a code more readable and cleaner
- All patterns was separated on their own libary of classes
- So `patterns of programming`, with which I worked:
  - [x] **Iterator**
  - [x] **Command**
  - [x] **State**
  - [x] **Template method**
  - [x] **Visitor**
### Iterator
Iterator pattern helps in accessing elements of a collection sequentially without exposing its underlying structure. It defines an interface for accessing elements and concrete implementations for different 
collections, decoupling client code from collection implementations. For this I made [NodeIterator](./Composite/NodeIterator.cs) that implements `Iterator` and can searching child classes in depth or in width
step by step.
### Command
Command pattern encapsulates requests as objects, allowing parameterization of clients with queues, requests, and operations. It defines a command interface with an execute method, and concrete command classes 
implement this interface, enabling separation of sender and receiver of requests. I made [AddChildCommand](./Composite/AddChildCommand.cs) and [AddClassCommand](./Composite/AddClassCommand.cs) that `keeping HTML element` and realizing some logic in `method Execute` from [Interface ICommand](./Composite/ICommand.cs). Then I made class [Invoker](./Composite/Invoker.cs) that has some logicof executing methods from list of OCommand.
### State
State pattern allows an object to alter its behavior when its internal state changes. It defines state objects representing different states and contexts using these states. This pattern helps in managing object
behavior changes at runtime without using large conditional statements. In my case, I have abstract class [NodeState](./Composite/NodeState.cs) that keeping obkect-context. Then I made classes like [SelfClosingState](./Composite/SelfClosingState.cs) that keeping some logic of method `Handle` and Invoking it in defferent places in [LightElementNode](./Composite/LightElementNode.cs#L118) to make the behavior different. 
### Template method
Template Method pattern defines the skeleton of an algorithm in a superclass but allows subclasses to override specific steps without changing its structure. It uses an abstract class with a template method and 
abstract methods for customizable steps, promoting code reusability and algorithm variations. The main part - `Template method` that keeping logic sequence of making methods, like in [LightNode](./Composite/LightNode.cs#L22-36). All what remained to do, is create a logic inside methods from `ILifeCycleHooks`. Example in [LightElementNode](./Composite/LightElementNode.cs#L147-L175).
### Visitor
Visitor pattern represents an operation to be performed on elements of an object structure without changing the classes. It defines a visitor interface with methods for each element type and concrete visitor 
classes implementing this interface to perform operations. This promotes extensibility and maintains separation of concerns. Class [Visitor](./Composite/DefaultVisitor.cs) must have logic for every type of classes, that can be inserted into it. Visitable class must have [accept method](./Composite/LightElementNode.cs#L142-L145) to identify for Visitor. 
