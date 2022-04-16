namespace DotNet.DecodeBase64;

public static class Base64Decoder
{
    public static string Decode(string value)
    {
        value = value.Replace('-', '+');
        value = value.Replace('_', '/');

        value = value.PadRight(value.Length + (4 - value.Length % 4) % 4, '=');

        var data = Convert.FromBase64String(value);
        return Encoding.UTF8.GetString(data);
    }
}
