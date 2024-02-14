using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        //Arrange
        Triangle triangle = new Triangle();
        int input = 0;
        //Act
        string actual = Triangle.PrintTriangle(input);
        string expected = string.Empty;
        //Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        //Arrange
        Triangle triangle = new Triangle();
        int input = 3;
        //Act
        string actual = Triangle.PrintTriangle(input);
        string expected = "1\r\n1 2\r\n1 2 3\r\n1 2\r\n1";
        //Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        //Arrange
        Triangle triangle = new Triangle();
        int input = 5;
        //Act
        string actual = Triangle.PrintTriangle(input);
        string expected = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4\r\n1 2 3 4 5\r\n1 2 3 4\r\n1 2 3\r\n1 2\r\n1";
        //Assert

        Assert.AreEqual(expected, actual);
    }
}
