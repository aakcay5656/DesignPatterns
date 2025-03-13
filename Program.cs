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
using DesignPatterns.OopPrinciples.Composition;

var car = new Car();
car.StartCar();


