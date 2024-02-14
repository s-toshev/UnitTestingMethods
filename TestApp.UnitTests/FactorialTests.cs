using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [TestCase(0,1)]
    public void Test_CalculateFactorial_InputZero_ReturnsOne(int input, int expected)
    {
        //Arrange
        Factorial factorial = new Factorial();


        //Act
        int actual = Factorial.CalculateFactorial(input);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(5,120)]
    [TestCase(1, 1)]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial(int input, int expected)
    {
        //Arrange
        Factorial factorial = new Factorial();


        //Act

        int actual = Factorial.CalculateFactorial(input);


        //Assert

        Assert.AreEqual(expected, actual);
    }
}
