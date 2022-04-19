using DotNet.DecodeBase64.Tests.TestInfrastructure;
using FluentAssertions;

namespace DotNet.DecodeBase64.Tests;

public class ProgramTests
{
    private readonly MockConsole _console;
    private const string ValidBase64Input = "SGVsbG8gV29ybGQh";
    private const string DecodedValidBase64Input = "Hello World!";
    private const string InvalidBase64Input = "#";

    public ProgramTests()
    {
        _console = new MockConsole();
        Program.AbstractedConsole = _console;
    }

    [Fact]
    public void GivenNoArgumentProvided_ThenDisplayInstructions()
    {
        // Arrange
        var input = Array.Empty<string>();

        // Act
        Program.Main(input);

        // Assert
        var expectedLines = new List<ColoredLine>
        {
            new("A single argument should be provided:", MockConsole.BoringColor),
            new("dotnet decode-base64 SGVsbG8gV29ybGQh", MockConsole.BoringColor)
        };
        _console.Lines.Should().BeEquivalentTo(expectedLines);
    }

    [Fact]
    public void GivenNoArgumentProvided_ThenFailureExitCode()
    {
        // Arrange
        var input = Array.Empty<string>();

        // Act
        var actualExitCode = Program.Main(input);

        // Assert
        actualExitCode.Should().Be(Program.FailureExitCode);
    }

    [Fact]
    public void GivenMoreThanOneArgumentProvided_ThenDisplayInstructions()
    {
        // Arrange
        var input = new[] { ValidBase64Input, ValidBase64Input };

        // Act
        Program.Main(input);

        // Assert
        var expectedLines = new List<ColoredLine>
        {
            new("A single argument should be provided:", MockConsole.BoringColor),
            new("dotnet decode-base64 SGVsbG8gV29ybGQh", MockConsole.BoringColor)
        };
        _console.Lines.Should().BeEquivalentTo(expectedLines);
    }

    [Fact]
    public void GivenMoreThanOneArgumentProvided_ThenFailureExitCode()
    {
        // Arrange
        var input = new[] { ValidBase64Input, ValidBase64Input };

        // Act
        var actualExitCode = Program.Main(input);

        // Assert
        actualExitCode.Should().Be(Program.FailureExitCode);
    }

    [Fact]
    public void GivenInvalidBase64Input_ThenDisplayErrorMessage()
    {
        // Arrange
        var input = new[] { InvalidBase64Input };

        // Act
        Program.Main(input);

        // Assert
        const string errorMessage =
            "The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.";
        var expectedLines = new List<ColoredLine>
        {
            new(errorMessage, MockConsole.ErrorColor)
        };
        _console.Lines.Should().BeEquivalentTo(expectedLines);
    }

    [Fact]
    public void GivenInvalidBase64Input_ThenFailureExitCode()
    {
        // Arrange
        var input = new[] { InvalidBase64Input };

        // Act
        var actualExitCode = Program.Main(input);

        // Assert
        actualExitCode.Should().Be(Program.FailureExitCode);
    }

    [Fact]
    public void GivenValidBase64Input_ThenDisplayDecodedInput()
    {
        // Arrange
        var input = new[] { ValidBase64Input };

        // Act
        Program.Main(input);

        // Assert
        var expectedLines = new List<ColoredLine>
        {
            new("Decoded string:", MockConsole.FancyColor),
            new(DecodedValidBase64Input, MockConsole.BoringColor)
        };
        _console.Lines.Should().BeEquivalentTo(expectedLines);
    }

    [Fact]
    public void GivenValidBase64Input_ThenSuccessExitCode()
    {
        // Arrange
        var input = new[] { ValidBase64Input };

        // Act
        var actualExitCode = Program.Main(input);

        // Assert
        actualExitCode.Should().Be(Program.SuccessExitCode);
    }
}
