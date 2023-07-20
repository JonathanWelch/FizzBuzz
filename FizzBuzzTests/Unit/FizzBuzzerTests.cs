using FizzBuzz;

namespace FizzBuzzTests.Unit;

[TestFixture]
public class FizzBuzzerTests
{
    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("Fizz", 3)]
    [TestCase("Buzz", 5)]
    [TestCase("Fizz", 6)]
    [TestCase("Fizz", 9)]
    [TestCase("Buzz", 10)]

    public void CanGenerateFizzBuzzFromNumber(string expected, int number)
    {
        var fizzBuzzer = new FizzBuzzer();
        var fizzBuzzed = fizzBuzzer.Generate(number);

        Assert.That(fizzBuzzed, Is.EqualTo(expected));
    }

}