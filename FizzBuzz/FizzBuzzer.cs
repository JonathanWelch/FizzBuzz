namespace FizzBuzz;

public class FizzBuzzer : IFizzBuzzer
{
    public string Generate(int number)
    {
        return number.ToString();
    }
}