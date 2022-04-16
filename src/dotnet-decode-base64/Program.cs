namespace DotNet.DecodeBase64;

internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("A single argument should be provided:");
            Console.WriteLine("dotnet decode-base64 SGVsbG8gV29ybGQh");
            return;
        }

        try
        {
            var decodedString = Base64Decoder.Decode(args[0]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Decoded string:");
            Console.ResetColor();
            Console.WriteLine(decodedString);
        }
        catch (FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.ResetColor();
        }
    }
}
