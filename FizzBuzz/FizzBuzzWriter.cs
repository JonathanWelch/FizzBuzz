namespace FizzBuzz;

public class FizzBuzzWriter
{
    private readonly TextWriter _writer;
    private readonly IFizzBuzzer _fizzBuzzer;

    public FizzBuzzWriter(TextWriter writer, IFizzBuzzer fizzBuzzer)
    {
        _writer = writer;
        _fizzBuzzer = fizzBuzzer;
    }

    public void Write(int startValue, int endValue)
    {
        for (var i = startValue; i <= endValue; i++)
        {
            _writer.WriteLine(_fizzBuzzer.Generate(i));
        }
    }
}