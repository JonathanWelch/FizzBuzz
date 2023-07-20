namespace FizzBuzz;

public class FizzBuzzer : IFizzBuzzer
{
    public string Generate(int number)
    {
        if (number % 3 == 0 && number % 5 == 0) return "Fizzbuzz";

        if (number % 5 == 0) return "Buzz";

        return number % 3 == 0 ? "Fizz" : number.ToString();
    }
}