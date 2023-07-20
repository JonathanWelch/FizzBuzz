using FizzBuzz;
using Moq;

namespace FizzBuzzTests.Unit;

[TestFixture]
public class FizzBuzzWriterTests
{
    [Test]
    public void CanCollaborateWithFizzBuzzer()
    {
        var textWriterMock = new Mock<TextWriter>();
        var fizzBuzzerMock = new Mock<IFizzBuzzer>();
        var writer = new FizzBuzzWriter(textWriterMock.Object, fizzBuzzerMock.Object);

        writer.Write(1, 2);

        fizzBuzzerMock.Verify(buzzer => buzzer.Generate(1), Times.Once());
        fizzBuzzerMock.Verify(buzzer => buzzer.Generate(2), Times.Once());
    }

    [Test]
    public void CanWriteFizzBuzzResultToWriter()
    {
        var textWriterMock = new Mock<TextWriter>();
        var fizzBuzzerMock = new Mock<IFizzBuzzer>();
        fizzBuzzerMock.Setup(buzzer => buzzer.Generate(1)).Returns("1");
        fizzBuzzerMock.Setup(buzzer => buzzer.Generate(2)).Returns("2");
        var writer = new FizzBuzzWriter(textWriterMock.Object, fizzBuzzerMock.Object);

        writer.Write(1, 2);

        textWriterMock.Verify(writer => writer.WriteLine("1"), Times.Once());
        textWriterMock.Verify(writer => writer.WriteLine("2"), Times.Once());
    }
}