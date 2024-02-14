using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_AdditionWithPositiveNums()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_AdditionWithNegativeNums()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(-5, -2);
        int expected = -7;

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_AdditionWithOnePositiveOneNegativeNums()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(35, -2);
        int expected = 33;

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }


    [TestCase(-5,-3,-2)]
    [TestCase(15, 5, 10)]
    [TestCase(-5, -3, -2)]
    [TestCase(-5, 3, -8)]

    public void Test_SubtractionWithNegativeNumbers(int firstNum, int secondNum, int expected)
    {
        // Arrange
        Calculate substractCalc = new();

        // Act

        int actual = substractCalc.Subtraction(firstNum,secondNum);
        // Assert

        Assert.AreEqual(expected, actual);

    }

   

}
