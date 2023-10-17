# Design Patterns For Unity

<img src="https://github.com/SamuelAsherRivello/UnityDesignPatterns/blob/master/Unity/Assets/3rdParty/RMC/Shared/Documentation/Images/Screenshot_v1.png?raw=true" width="500" />

**Details**

I created this for my own educational purposes as well as using it for training others in the classroom.

Enjoy!

## Design Principles

### Theory

**SOLID Principles** - The intention of these SOLID principles is to make software designs more understandable, easier to maintain and easier to extend. As a software engineer, these 5 principles are essential to know! See <a href="https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4">IT Next Docs</a> for more.

### List

| Name                        | Description                           | Complete |
|-----------------------------|---------------------------------------|----------|
| **S**ingle Responsibility   | One reason to change.                 |  ✅      |
| **O**pen/Closed             | Open for extension, closed for modification. |    ❌      |
| **L**iskov Substitution     | Subtypes must be substitutable for their base types. |    ❌      |
| **I**nterface Segregation   | No client should be forced to depend on interfaces they do not use. |    ❌      |
| **D**ependency Inversion    | High-level modules should not depend on low-level ones; both should depend on abstractions. |  ❌        |


## Design Patterns

### Theory

It is a series of small demos. Each shows one design pattern.

* **Creational Patterns** - Design patterns that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. The basic form of object creation could result in design problems or in added complexity to the design. Creational design patterns solve this problem by somehow controlling this object creation. See <a href="https://en.wikipedia.org/wiki/Creational_pattern">Wikipedia</a> for more.
* **Structural Patterns** - Design patterns that ease the design by identifying a simple way to realize relationships among entities. See <a href="https://en.wikipedia.org/wiki/Structural_pattern">Wikipedia</a> for more.
* **Behavioral Patterns** - Design patterns that identify common communication patterns among objects and realize these patterns. By doing so, these patterns increase flexibility in carrying out this communication. See <a href="https://en.wikipedia.org/wiki/Behavioral_pattern">Wikipedia</a> for more.

### List

| Type           | Name                    | Description                          | Complete |
|----------------|-------------------------|--------------------------------------|----------|
|                |                         |                                      |          |
| Creational     |                         |                                      |          |
|                | Singleton               | Ensures a class has one instance.    |    ❌      |
|                | Factory Method          | Creates objects without specifying the exact class to create. |  ❌        |
|                | Abstract Factory        | Creates families of related objects. |      ❌    |
|                | Prototype               | Clone or copy initialized instances. |    ❌      |
|                | Builder                 | Separates object construction from its representation. |   ❌       |
|                |                         |                                      |          |
|  Structural    |                         |                                      |          |
|                | Adapter                 | Matches interfaces of different classes. |   ❌       |
|                | Bridge                  | Separates an object’s interface from its implementation. |   ❌       |
|                | Composite               | Tree structure of simple and composite objects. |   ❌       |
|                | Decorator               | Adds responsibilities to objects dynamically. |  ❌        |
|                | Facade                  | Simplified interface to a subsystem. |   ❌       |
|                | Flyweight               | Reuses objects by sharing common state. |     ❌     |
|                | Proxy                   | Represents another object.           |     ❌     |
|                |                         |                                      |          |
| Behavioral      |                         |                                      |          |
|                | Chain of Responsibility | Passes request among a chain of objects. |    ❌      |
|                | Command                 | Encapsulates a request as an object. |    ❌      |
|                | Interpreter             | Provides a language interpreter.     |    ❌      |
|                | Iterator                | Sequentially access elements in a collection. |    ❌      |
|                | Mediator                | Centralized external communications. |    ❌      |
|                | Memento                 | Capture and restore object's internal state. |     ❌     |
|                | Observer                | Notify changes to its state.         |    ❌      |
|                | State                   | Alter behavior when its state changes. |     ❌     |
|                | Strategy                | Encapsulates algorithms using strategy pattern. |    ❌      |
|                | Template Method         | Defer exact steps to subclasses.     |      ❌    |
|                | Visitor                 | Add new operations without altering a class. |    ❌      |


## Features

* **Editor Scripting** - Unity lets you extend the editor with your own custom inspectors and Editor Windows and you can define how properties are displayed in the inspector with custom Property Drawers. See <a href="https://docs.unity3d.com/Manual/ExtendingTheEditor.html">Unity Docs</a> for more.



## Tooling

* **Unit Testing** - Software testing where individual units/ components of a software are tested. The purpose is to validate that each unit of the software performs as designed. A unit is the smallest testable part of any software. See <a href="https://docs.unity3d.com/Manual/testing-editortestsrunner.html">Unity Docs</a> for more.

Created By
=============

- Samuel Asher Rivello 
- Over 20 years XP with game development (2020)
- Over 8 years XP with Unity (2020)

Contact
=============

- Twitter - <a href="https://twitter.com/srivello/">@srivello</a>
- Resume & Portfolio - <a href="http://www.SamuelAsherRivello.com">SamuelAsherRivello.com</a>
- Git - <a href="https://github.com/SamuelAsherRivello/">Github.com/SamuelAsherRivello</a>
- LinkedIn - <a href="https://Linkedin.com/in/SamuelAsherRivello">Linkedin.com/in/SamuelAsherRivello</a> <--- Say Hello! :)
