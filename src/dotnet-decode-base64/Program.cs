using System;
using System.Text;

namespace DotNetDecodeBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("A single argument should be provided:");
                Console.WriteLine("dotnet decode-base64 \"SGVsbG8gV29ybGQh\"");
                return;
            }

            try
            {
                var data = Convert.FromBase64String(args[0]);
                var decodedString = Encoding.UTF8.GetString(data);

                Console.ForegroundColor = ConsoleColor.DarkGray;
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
}
