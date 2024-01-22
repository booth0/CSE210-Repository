using System;

class Car {
public int milesPerGallon;
public int gallons;
public string make;
public string model;

    
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        var cars = new List<Car>();

        var car = new Car();
        car.make = "Honda";
        car.model = "Civic";
        car.gallons = 10;
        car.milesPerGallon = 30;
        cars.Add(car);

        car = new Car();
        car.make = "Toyota";
        car.model = "Corolla";
        car.gallons = 12;
        car.milesPerGallon = 35;
        cars.Add(car);

        foreach (var c in cars) {
            System.Console.WriteLine($"{c.make} {c.model}: Range={c.gallons * c.milesPerGallon}");
        }
    }
}