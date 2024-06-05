// alias features 

using myInt32 = int;
// ok for nullable value type
using myNullableInt = int?;

// ok to alias string 
using myString = string;
// not ok to use nullable reference type
// using myNullableString = string?;

myInt32 salary = 10000;

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"My salary: {salary}!");

// optional lambda expression 
var CalculateTax = (int totalIncome, int taxRate = 1) => totalIncome * taxRate;
var CalculateTax2 = (int totalIncome, float taxRate = 0.4f) => totalIncome * taxRate;

Console.WriteLine($"Tax : {CalculateTax(5000)}!");

// primary constructor
class MyCar(int engine, int passengers)
{
    public int EngineCapability { get; set; } = engine;
    public int NumberPassengers { get; set; } = passengers;
}

