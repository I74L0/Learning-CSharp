Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"\nHello, {name}, on {currentDate:d} at {currentDate:t}!");