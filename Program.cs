//Encapsulation

/*
using DesignPatterns.OopPrinciples.Encapsulation;

BadBankAccount badAccount = new BadBankAccount();
badAccount.balance = -100;

BankAccount bankAccount = new BankAccount(100);

bankAccount.Deposit(1000);
bankAccount.withDraw(950);

System.Console.WriteLine(bankAccount.Balance);
*/

//Abstraction
/*
using BankingApp.UnitsTests;
using DesignPatterns.OopPrinciples.Abstraction;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

EmailService emailService = new EmailService();

emailService.SendEmail();
*/

// Inheritance
/*
using DesignPatterns.OopPrinciples.Inheritance;

var car = new Car();
var bike = new Bike();

//Shared
car.Brand = "Nissan";
car.Start();
car.Stop();

//Unique
car.numberOfDoors = 4;
*/

// Polymorphism

/*
using DesignPatterns.OopPrinciples.Polymorphism;

List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(new Car { Brand = "Toyota" , Model = "Camty" , numberOfDoors = 4, numberOfWheels = 4, Year = 2020});
vehicles.Add(new Motorcycle { Brand = "Harley Davidson", Model = "Sportster", numberOfWheels = 2, Year = 2021 });

foreach (var item in vehicles)
{
    item.Start();
}
*/

//Coupling
/*
using DesignPatterns.OopPrinciples.Coupling;

var order = new Order(new EmailSender());
order.PlaceOrder();

var order1 = new Order(new SMSsender());
order1.PlaceOrder();
*/

// Composition
/*
using DesignPatterns.OopPrinciples.Composition;

var car = new Car();
car.StartCar();
*/

// Single Responsibility Principle (SRP):

// " A class should have only one reason to change , meaning that it should have only one responsibility or purpose. "
/*
using DesignPatterns.SOLID.S;

User user = new User();
user.Email = "asfasf@gmail.com";
user.Username = "life";

UserServices userServices = new UserServices();

userServices.Register(user);
*/


// Open/Closed Principle (OCP):

// "Software entities ( classes , functions , modeules , etc.) should be open for extention but closed for modification. "

/*
using DesignPatterns.SOLID.O;

Circle circle = new Circle();

circle.Radius = 5;

Console.WriteLine(circle.CalculateArea()); 
*/

// Liskov Substitution Principle (LSP):

// " Objects of superclass should be replaceable with objects of its subclass  without affecting the correctness of the program. "
/*
using DesignPatterns.SOLID.L;

var rect = new Square();

rect.Width = 5;
rect.Height = 10;

Console.WriteLine("Expected Area 5 * 10 = 50");

Console.WriteLine($" Calculate Area : {rect.Area}");

Shape rectangle = new Rectangle { Width = 5  ,Height=10};
Console.WriteLine($"Area of tehe rectangle: {rectangle.Area}");

Shape square = new Square { sideLength = 5 };
Console.WriteLine($"Area of tehe square: {square.Area}");
*/



// Interface Segregation Principle (ISP):

// " Clients should not be forced to depend on interfaces they do not use. "
/*
using DesignPatterns.SOLID.I;

var circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"Area of the circle : {circle.Area()}");

var sphere = new Sphere();
sphere.Radius = 5;
Console.WriteLine($"Area of the sphere : {sphere.Area()}");
Console.WriteLine($"Area of the Valume : {sphere.Valume()}");
*/


// Dependency Inversion Principle (DIP):

// "High-Level modules should not depend on low-level modeules. Both should depend on abstractions"
/*
using DesignPatterns.SOLID.D;

var car = new Car(new Engine());
*/



// Design Patterns 

// There are three  main group of design patterns:

// - Creational: the different ways to create objects.
// - Structural: the relationships between those objects.
// - Behavioral: the interaction of communication between those objects.


// Behavioral Design Patterns

/*
 Behavioral design patterns focus on how objects interact with each other and how they communicate to accomplish specific task. these patterns address communication,
responsibility, and algorithmmic issues in object-oriented software design. They help in defining clear and efficient communication mechanisms between objects and classes.

These patterns help in making the desing more flexible, extensible, and maintainable by promoting better communication and separation of concerns between objects and 
classes in the System.Each pattern addresses specific desing issiues and provides a standartdized solution to common problems encountered in sofware development.

 */


// Memento Design Pattern

// The Memento Pattern is used to restore an object to a previous state. 
/*
using DesignPatterns.DesignPatters.Behavioral.Memento;
using System;

var editor = new Editor();
var history = new History(editor);

history.Backup();
editor.Title = "Test";
history.Backup();
editor.Content = "Hello there, my name is abdullah";
history.Backup();
editor.Title = "The life of a dev: my memento";
history.Backup();

history.ShowHistory();

Console.WriteLine();

Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");

history.Undo();
Console.WriteLine();
history.ShowHistory();
Console.WriteLine();


Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");

history.Undo();
Console.WriteLine();
history.ShowHistory();
Console.WriteLine();


Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");

history.Undo();
Console.WriteLine();
history.ShowHistory();
Console.WriteLine();

Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");


history.Undo();
Console.WriteLine();
history.ShowHistory();
Console.WriteLine();

Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");
*/

// State Design Pattern
/*
using DesignPatterns.DesignPatters.Behavioral.State;

var doc = new Document();

doc.State = DocumentStates.Moderation;
doc.CurrentUserRole = UserRoles.Admin;

Console.WriteLine(doc.State);

doc.Publish();

Console.WriteLine(doc.State);
*/

/*
using DesignPatterns.DesignPatters.Behavioral.State.GoodSolution;

var doc = new Document(UserRoles.Admin);
Console.WriteLine(doc.State);

doc.Publish();
Console.WriteLine(doc.State);


doc.Publish();
Console.WriteLine(doc.State);
*/


// Strategy Pattern

// the Strategy Pattern is used to pass different algorithms, or behaviors, to behaviors, to an object.

/*
 First , let's consider an application that stores videos. Before storing a video , the video needs to be compressed using  
a spesific compression algorithm, such as MOV or MP4, then, if necessary, apply an overlay to the video, such as black and white or blur.
 */

/*
using DesignPatterns.DesignPatters.Behavioral.Strategy.GoodSoluition;

var videoStore = new VideoStorage(new CompressorMOV(),new OverlaysBlackAndWhite());

videoStore.Store("/videos/theFall-2006");

videoStore.SetCompressor(new CompressorMP4());
videoStore.SetOverlay(new OverlayBlur());
videoStore.Store("/videos/theThing-1982");
*/


// Iterator Pattern 

/* 
 
 The Iterator Pattern provides a way of iterating over an object without having to expose the object's internal structure, which may change in the future.
 Changing the internals of an object should not affect its consumers.
 */
/*
using DesignPatterns.DesignPatters.Behavioral.Iterator.GoodSolution;

ShoppingList list = new ShoppingList();

list.Push("Apple");
list.Push("Milk");
list.Push("Steak");


var iterator = list.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}
*/

// Command Pattern 

/*
    The Command Pattern is a behavioral design pattern that encapsulates a request as an object, allowing you to parameterize clients with quesuses, requests, or operations.
    It enables you to decouple the sender from the receiver , providing flexibility in the execution of commands and supporting undoable operations.
 */

/*
using DesignPatterns.DesignPatters.Behavioral.Command;

var light = new Light();
var remoteControl = new RemoteControl(light);

remoteControl.PressButton(true);
remoteControl.PressButton(false);
*/


using DesignPatterns.DesignPatters.Behavioral.Command.GoodSolution;


var light = new Light();

var remoteControl = new RemoteControl(new TurnOnCommand(light));
remoteControl.PressButton();

remoteControl.SetCommend(new TurnOffCommand(light));
remoteControl.PressButton();

remoteControl.SetCommend(new TurnDimCommand(light));
remoteControl.PressButton();