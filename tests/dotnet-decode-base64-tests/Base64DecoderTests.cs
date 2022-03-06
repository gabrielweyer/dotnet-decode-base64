namespace DotNet.DecodeBase64.Tests;

public class Base64DecoderTests
{
    [Fact]
    public void GivenValidBase64String_WhenDecode_ThenReturnDecodedString()
    {
        // Arrange
        const string input = "SGVsbG8gV29ybGQh";
        const string expected = "Hello World!";

        // Act
        var actual = Base64Decoder.Decode(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("WGZ-Xz0=", "Xf~_=")]
    [InlineData("bFo_ejc=", "lZ?z7")]
    public void GivenMinusAndUnderscore_WhenDecode_ThenReturnDecodedString(string input, string expected)
    {
        // Act
        var actual = Base64Decoder.Decode(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("SA", "H")]
    [InlineData("SGk", "Hi")]
    public void GivenRemovedPadding_WhenDecode_ThenReturnDecodedString(string input, string expected)
    {
        // Act
        var actual = Base64Decoder.Decode(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
