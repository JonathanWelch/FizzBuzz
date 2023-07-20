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

    [Test]
    public void CanGenerateFizzBuzzFromAnotherNumber()
    {
        var fizzBuzzer = new FizzBuzzer();

        var fizzBuzzed = fizzBuzzer.Generate(2);

        Assert.That(fizzBuzzed, Is.EqualTo("2"));
    }

    [Test]
    public void CanGenerateFizz()
    {
        var fizzBuzzer = new FizzBuzzer();

        var fizzBuzzed = fizzBuzzer.Generate(3);

        Assert.That(fizzBuzzed, Is.EqualTo("Fizz"));
    }

    [Test]
    public void CanGenerateBuzz()
    {
        var fizzBuzzer = new FizzBuzzer();

        var fizzBuzzed = fizzBuzzer.Generate(5);

        Assert.That(fizzBuzzed, Is.EqualTo("Buzz"));
    }

}