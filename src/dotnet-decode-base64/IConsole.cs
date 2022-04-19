namespace DotNet.DecodeBase64;

internal interface IConsole
{
    void WriteFancyLine(string line);
    void WriteBoringLine(string line);
    void WriteErrorLine(string line);
}
