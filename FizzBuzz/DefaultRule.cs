namespace FizzBuzz;

public class DefaultRule : IFizzBuzzRule
{
    public bool Applies(int number) => true;
    public string GetResult(int number) => number.ToString();
}