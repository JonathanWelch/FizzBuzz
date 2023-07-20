namespace FizzBuzz;

public class FizzBuzzer : IFizzBuzzer
{
    public string Generate(int number)
    {
        return number % 3 == 0 ? "Fizz" : number.ToString();
    }
}