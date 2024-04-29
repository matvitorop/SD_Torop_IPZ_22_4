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
implement this interface, enabling separation of sender and receiver of requests.
### State
State pattern allows an object to alter its behavior when its internal state changes. It defines state objects representing different states and contexts using these states. This pattern helps in managing object
behavior changes at runtime without using large conditional statements.
### Template method
Template Method pattern defines the skeleton of an algorithm in a superclass but allows subclasses to override specific steps without changing its structure. It uses an abstract class with a template method and 
abstract methods for customizable steps, promoting code reusability and algorithm variations.
### Visitor
Visitor pattern represents an operation to be performed on elements of an object structure without changing the classes. It defines a visitor interface with methods for each element type and concrete visitor 
classes implementing this interface to perform operations. This promotes extensibility and maintains separation of concerns.
