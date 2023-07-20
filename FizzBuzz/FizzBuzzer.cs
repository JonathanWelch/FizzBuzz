namespace FizzBuzz;

public class FizzBuzzer : IFizzBuzzer
{
    private readonly List<IFizzBuzzRule> _rules;

    public FizzBuzzer(List<IFizzBuzzRule> rules)
    {
        _rules = rules;
    }

    public string Generate(int number)
    {
        var result = _rules.FirstOrDefault(rule => rule.Applies(number))?.GetResult(number);

        return result ?? throw new InvalidOperationException("No rule applies for the given number.");
    }
}