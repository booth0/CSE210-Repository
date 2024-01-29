namespace Learning02;

using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        var cars = new List<Car>();
 
        
        var owner = new Owner();
        owner.name = "Bob";
        owner.phone = "222-2222";
        var car = new Car("Honda", "Civic", 10, 30, owner);
        car.owner = owner;
        cars.Add(car);

    
        // car.make = "Toyota";
        // car.model = "Corolla";
        // car.gallons = 12;
        // car.milesPerGallon = 35;
        owner = new Owner();
        owner.name = "Sarah";
        owner.phone = "333-2222";
        car = new Car("Toyota", "Corolla", 12, 35, owner);
        car.owner = owner;
        cars.Add(car);

        foreach (var c in cars) {
            c.Display();
            int range = c.TotalRange();
        }
    }
}

