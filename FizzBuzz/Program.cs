// See https://aka.ms/new-console-template for more information
using FizzBuzz;

var fizzBuzzWriter = new FizzBuzzWriter(Console.Out, new FizzBuzzer());

fizzBuzzWriter.Write(1, 100);
Console.ReadLine();
