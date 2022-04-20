namespace Gabo.DotNet.DecodeBase64;

internal static class Program
{
    internal const int SuccessExitCode = 0;
    internal const int FailureExitCode = 1;

    internal static IConsole AbstractedConsole;

    internal static int Main(string[] args)
    {
        AbstractedConsole ??= new NonThreadSafeConsole();

        if (args.Length != 1)
        {
            AbstractedConsole.WriteBoringLine("A single argument should be provided:");
            AbstractedConsole.WriteBoringLine("dotnet decode-base64 SGVsbG8gV29ybGQh");
            return FailureExitCode;
        }

        try
        {
            var decodedString = Base64Decoder.Decode(args[0]);

            AbstractedConsole.WriteFancyLine("Decoded string:");
            AbstractedConsole.WriteBoringLine(decodedString);
            return SuccessExitCode;
        }
        catch (FormatException e)
        {
            AbstractedConsole.WriteErrorLine(e.Message);
            return FailureExitCode;
        }
    }
}
