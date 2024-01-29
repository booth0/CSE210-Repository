namespace Learning02;
class Car {
public int milesPerGallon;
public int gallons;
public string make;
public string model;
public Owner owner;

public Car(string make, string model, int gallons, int milesPerGallon, Owner owner){
    this.make = make;
    this.model = model;
    this.gallons = gallons;
    this.milesPerGallon = milesPerGallon;
    this.owner = owner;
}


public int TotalRange() {
    return gallons * milesPerGallon;
}
public void Display(){
    System.Console.WriteLine($"{make} {model} {owner.name}: Range = {TotalRange()}");
}


    
}