namespace FizzBuzz;

public class BuzzRule : IFizzBuzzRule
{
    public bool Applies(int number) => number % 5 == 0;
    public string GetResult(int number) => "Buzz";
}