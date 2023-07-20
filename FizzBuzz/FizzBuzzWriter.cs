namespace FizzBuzz;

public class FizzBuzzWriter
{
    private readonly IFizzBuzzer _fizzBuzzer;

    public FizzBuzzWriter(TextWriter writer, IFizzBuzzer fizzBuzzer)
    {
        _fizzBuzzer = fizzBuzzer;
    }

    public void Write(int startValue, int endValue)
    {
        for (var i = startValue; i <= endValue; i++)
        {
            _fizzBuzzer.Generate(i);
        }
    }
}