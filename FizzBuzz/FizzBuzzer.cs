namespace FizzBuzz;

public class FizzBuzzer : IFizzBuzzer
{
    public string Generate(int number)
    {
        if (number % 5 == 0) return "Buzz";

        return number % 3 == 0 ? "Fizz" : number.ToString();
    }
}