namespace DotNet.DecodeBase64.Tests.TestInfrastructure;

internal class MockConsole : IConsole
{
    public const ConsoleColor FancyColor = ConsoleColor.Cyan;
    public const ConsoleColor BoringColor = ConsoleColor.Yellow;
    public const ConsoleColor ErrorColor = ConsoleColor.Magenta;
    public IReadOnlyList<ColoredLine> Lines => _lines;

    private readonly List<ColoredLine> _lines;

    public MockConsole()
    {
        _lines = new List<ColoredLine>();
    }

    public void WriteFancyLine(string line)
    {
        _lines.Add(new ColoredLine(line, FancyColor));
    }

    public void WriteBoringLine(string line)
    {
        _lines.Add(new ColoredLine(line, BoringColor));
    }

    public void WriteErrorLine(string line)
    {
        _lines.Add(new ColoredLine(line, ErrorColor));
    }
}

internal class ColoredLine
{
    public ColoredLine(string line, ConsoleColor color)
    {
        Line = line;
        Color = color;
    }

    public ConsoleColor Color { get; }
    public string Line { get; }
}
