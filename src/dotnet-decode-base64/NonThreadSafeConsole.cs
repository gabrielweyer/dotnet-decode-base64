namespace DotNet.DecodeBase64;

internal class NonThreadSafeConsole : IConsole
{
    public void WriteFancyLine(string line)
    {
        WriteColoredLine(ConsoleColor.Green, line);
    }

    public void WriteBoringLine(string line)
    {
        Console.WriteLine(line);
    }

    public void WriteErrorLine(string line)
    {
        WriteColoredLine(ConsoleColor.Red, line);
    }

    private static void WriteColoredLine(ConsoleColor color, string line)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(line);
        Console.ResetColor();
    }
}
