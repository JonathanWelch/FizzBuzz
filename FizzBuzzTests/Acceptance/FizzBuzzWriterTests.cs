using FizzBuzz;

namespace FizzBuzzTests.Acceptance;

[TestFixture]
public class FizzBuzzWriterTests
{
    [Test]
    public void CanWriteFizzBuzz()
    {
        var stringWriter = new StringWriter();

        var fizzBuzzRules = new List<IFizzBuzzRule>
        {
            new FizzBuzzRule(),
            new FizzRule(),
            new BuzzRule(),
            new DefaultRule()
        };

        var fizzBuzzer = new FizzBuzzer(fizzBuzzRules);
        var fizzBuzzWriter = new FizzBuzzWriter(stringWriter, fizzBuzzer);

        fizzBuzzWriter.Write(1, 20);

        const string expectedOutput = @"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
Fizzbuzz
16
17
Fizz
19
Buzz
";

        Assert.That(stringWriter.ToString(), Is.EqualTo(expectedOutput));
    }
}