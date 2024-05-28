
# Unity Best Practices

<img src="https://github.com/SamuelAsherRivello/unity-best-practices/blob/main/Unity/Assets/UnityBestPractices/Shared/Documentation/Images/Screenshot_v1.png?raw=true" width="500" />

**Details**

Here is a complete overview of **Design Patterns** and related topics for Unity. 

The repo is complete with code samples.

Enjoy!

## Table of Contents

1. [Design Principles](#design-principles)
1. [Design Patterns](#design-patterns)
1. [Features](#features)
1. [Tooling](#tooling)
1. [Contact](#contact)

## Design Principles

**Theory**

**S.O.L.I.D. Principles** make software designs more understandable, easier to maintain and easier to extend. As a software engineer, these 5 principles are essential to know! (See <a href="https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4">ITNext.io</a>)

**List**

| Name                        | Description                           | Code Sample Complete |
|-----------------------------|---------------------------------------|----------|
| **S**ingle Responsibility   | One reason to change.                 |  ✅      |
| **O**pen/Closed             | Open for extension, closed for modification. |    ✅      |
| **L**iskov Substitution     | Subtypes must be substitutable for their base types. |    ✅      |
| **I**nterface Segregation   | No client should be forced to depend on interfaces they do not use. |    ✅      |
| **D**ependency Inversion    | High-level modules should not depend on low-level ones; both should depend on abstractions. |  ✅        |


## Design Patterns

**Theory**

These patterns provide solutions to common design problems and are a foundational part of software design knowledge. There are 3 types.

* **Behavioral Patterns** - Design patterns to deal with object-object communication. (See <a href="https://en.wikipedia.org/wiki/Behavioral_pattern">Wikipedia</a>)
* **Creational Patterns** - Design patterns to deal with object creation. (See <a href="https://en.wikipedia.org/wiki/Creational_pattern">Wikipedia</a>)
* **Structural Patterns** - Design patterns to deal with object-object relationships. (See <a href="https://en.wikipedia.org/wiki/Structural_pattern">Wikipedia</a>)

**List**

| Type           | Name                    | Description                          | Code Sample Complete |
|----------------|-------------------------|--------------------------------------|----------|
|                |                         |                                      |          |
| Behavioral      |                         |                                      |          |
|                | Chain of Responsibility | Passes request among a chain of objects. |    ❌      |
|                | Command                 | Encapsulates a request as an object. |    ✅       |
|                | Interpreter             | Provides a language interpreter.     |    ❌      |
|                | Iterator                | Sequentially access elements in a collection. |    ❌      |
|                | Mediator                | Centralized external communications. |    ❌      |
|                | Memento                 | Capture and restore object's internal state. |     ✅      |
|                | Observer                | Notify changes to its state.         |    ❌      |
|                | State                   | Alter behavior when its state changes. |     ✅      |
|                | Strategy                | Encapsulates algorithms using strategy pattern. |    ✅      |
|                | Template Method         | Defer exact steps to subclasses.     |      ❌    |
|                | Visitor                 | Add new operations without altering a class. |    ❌      |
|                |                         |                                      |          |
| Creational     |                         |                                      |          |
|                | Abstract Factory        | Creates families of related objects. |      ❌    |
|                | Builder                 | Separates object construction from its representation. |   ❌       |
|                | Factory Method          | Creates objects without specifying the exact class to create. |  ✅         |
|                | Prototype               | Clone or copy initialized instances. |    ❌      |
|                | Singleton               | Ensures a class has one instance.    |    ✅       |
|                |                         |                                      |          |
|  Structural    |                         |                                      |          |
|                | Adapter                 | Matches interfaces of different classes. |   ❌       |
|                | Bridge                  | Separates an object’s interface from its implementation. |   ❌       |
|                | Composite               | Tree structure of simple and composite objects. |   ❌       |
|                | Decorator               | Adds responsibilities to objects dynamically. |  ✅        |
|                | Facade                  | Simplified interface to a subsystem. |   ✅       |
|                | Flyweight               | Reuses objects by sharing common state. |     ✅     |
|                | Proxy                   | Represents another object.           |     ❌     |


## Features

* **Editor Scripting** - Unity lets you extend the editor with your own custom inspectors and Editor Windows and you can define how properties are displayed in the inspector with custom Property Drawers. See <a href="https://docs.unity3d.com/Manual/ExtendingTheEditor.html">Unity Docs</a> for more.

## Tooling

* **Unit Testing** - Software testing where individual units/ components of a software are tested. The purpose is to validate that each unit of the software performs as designed. A unit is the smallest testable part of any software. See <a href="https://docs.unity3d.com/Manual/testing-editortestsrunner.html">Unity Docs</a> for more.

Created By
=============

- Samuel Asher Rivello 
- Over 25 years XP with game development (2024)
- Over 11 years XP with Unity (2024)

Contact
=============

- Twitter - <a href="https://twitter.com/srivello/">@srivello</a>
- Git - <a href="https://github.com/SamuelAsherRivello/">Github.com/SamuelAsherRivello</a>
- Resume & Portfolio - <a href="http://www.SamuelAsherRivello.com">SamuelAsherRivello.com</a>
- LinkedIn - <a href="https://Linkedin.com/in/SamuelAsherRivello">Linkedin.com/in/SamuelAsherRivello</a> <--- Say Hello! :)


License
=============

Provided as-is under MIT License | Copyright © 2024 Rivello Multimedia Consulting, LLC


