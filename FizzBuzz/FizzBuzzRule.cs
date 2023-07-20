namespace FizzBuzz;

public class FizzBuzzRule : IFizzBuzzRule
{
    public bool Applies(int number) => number % 3 == 0 && number % 5 == 0;
    public string GetResult(int number) => "Fizzbuzz";
}