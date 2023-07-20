using FizzBuzz;
using Moq;

namespace FizzBuzzTests.Unit;

[TestFixture]
public class FizzBuzzWriterTests
{
    private Mock<TextWriter> _textWriterMock;
    private Mock<IFizzBuzzer> _fizzBuzzerMock;
    private FizzBuzzWriter _writer;

    [SetUp]
    public void SetUp()
    {
        _textWriterMock = new Mock<TextWriter>();
        _fizzBuzzerMock = new Mock<IFizzBuzzer>();
        _writer = new FizzBuzzWriter(_textWriterMock.Object, _fizzBuzzerMock.Object);
    }

    [Test]
    public void CanCollaborateWithFizzBuzzer()
    {
        _writer.Write(1, 2);

        _fizzBuzzerMock.Verify(buzzer => buzzer.Generate(1), Times.Once());
        _fizzBuzzerMock.Verify(buzzer => buzzer.Generate(2), Times.Once());
    }

    [Test]
    public void CanWriteFizzBuzzResultToWriter()
    {
        _fizzBuzzerMock.Setup(buzzer => buzzer.Generate(1)).Returns("1");
        _fizzBuzzerMock.Setup(buzzer => buzzer.Generate(2)).Returns("2");

        _writer.Write(1, 2);

        _textWriterMock.Verify(writer => writer.WriteLine("1"), Times.Once());
        _textWriterMock.Verify(writer => writer.WriteLine("2"), Times.Once());
    }
}