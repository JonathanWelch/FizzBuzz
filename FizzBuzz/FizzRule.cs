namespace FizzBuzz;

public class FizzRule : IFizzBuzzRule
{
    public bool Applies(int number) => number % 3 == 0;
    public string GetResult(int number) => "Fizz";
}