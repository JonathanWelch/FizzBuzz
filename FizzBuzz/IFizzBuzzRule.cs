namespace FizzBuzz;

public interface IFizzBuzzRule
{
    bool Applies(int number);
    string GetResult(int number);
}