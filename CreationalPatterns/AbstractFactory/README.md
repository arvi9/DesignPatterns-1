## Abstract Factory Design Pattern
### Creational Design Pattern

#### When to use?
When we have a program that uses a set of related/similar types of objects. Using this pattern allows us to create these objects using factories, without making our code reliant on concrete classes and without knowing the underlying abstraction of them, hence the name. This also makes it easy for us to add/extend new types of factories and classes without having to modify the code that uses them, so we abide by the Open Closed Principle rule.

#### Examples
- VehicleFactory > Car, Motorbike, Plane.
- DocumentFactory > Resume, Letter, Contract.
- SweetFactory > Lollipop, Gummy Bear, Baklava.
- GUIFactory > Windows, Mac, Linux.
- MobilePhoneFactory > Nokia, Samsung, Apple.
- ContinentFactory > Africa, Europe, America.
- We have a program that deals with vehicles (Cars and Motorbikes). Write your program to handle a generic VehicleClient that uses a VehicleFactory which can create both Car and Motorbike objects. This makes it easy to make our program compatible with Plane objects later on, as it is already written to handle the use of VehicleClients in the base class. The only logic that would have to be extended would not be in the core program logic itself but the VehicleClient class which is separate from our core program logic (Imagine that in a large real world application, the VehicleClient would for example be an imported foreign dependency within our core program).
