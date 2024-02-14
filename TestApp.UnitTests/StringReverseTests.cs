using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        StringReverse stringReverse = new StringReverse();
        string input = "";
        // Act
       string actual = StringReverse.Reverse(input);
        string expected = "";
        // Assert
       Assert.AreEqual(expected,actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        //Arrange

        StringReverse stringReverse = new StringReverse();
        string input = "K";
        //Act
        string actual = StringReverse.Reverse(input);
        string expected = "K";
        //Assert
        Assert.AreEqual(expected ,actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        //Arrange
        StringReverse stringReverse1 = new StringReverse();
        string input = "naomI";
        //Act
        string actual = StringReverse.Reverse(input);
        string expected = "Imoan";
        //Assert

        Assert.AreEqual(expected,actual);
    }
}
