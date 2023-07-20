using FizzBuzz;

namespace FizzBuzzTests.Unit;

[TestFixture]
public class FizzBuzzerTests
{
    [Test]
    public void CanGenerateFizzBuzzFromNumber()
    {
        var fizzBuzzer = new FizzBuzzer();

        var fizzBuzzed = fizzBuzzer.Generate(1);

        Assert.That(fizzBuzzed, Is.EqualTo("1"));
    }
}