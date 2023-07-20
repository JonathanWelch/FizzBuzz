// See https://aka.ms/new-console-template for more information
using FizzBuzz;
using System.Reflection;

var rules = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => typeof(IFizzBuzzRule).IsAssignableFrom(t) && !t.IsInterface)
    .Select(t => (IFizzBuzzRule)Activator.CreateInstance(t)!)
    .OrderByDescending(rule => rule.GetType().Name)
    .ToList();

var fizzBuzzWriter = new FizzBuzzWriter(Console.Out, new FizzBuzzer(rules));

fizzBuzzWriter.Write(1, 100);
Console.ReadLine();
