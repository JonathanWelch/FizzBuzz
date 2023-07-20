using FizzBuzz;

namespace FizzBuzzTests.Unit;

[TestFixture]
public class FizzBuzzerTests
{
    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("Fizz", 3)]
    [TestCase("Buzz", 5)]
    public void CanGenerateFizzBuzzFromNumber(string expected, int number)
    {
        var fizzBuzzer = new FizzBuzzer();
        var fizzBuzzed = fizzBuzzer.Generate(number);

        Assert.That(fizzBuzzed, Is.EqualTo(expected));
    }

}