﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.30,"Fail")]
    [TestCase(3.30, "Average")]
    [TestCase(3.60, "Good")]
    [TestCase(4.30, "Very Good")]
    [TestCase(4.70, "Excellent")]
    [TestCase(6.30, "Invalid!")]
    [TestCase(-3, "Invalid!")]
    [TestCase(0, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(1.99, "Invalid!")]

    [TestCase(2.00, "Fail")]
    [TestCase(2.99, "Fail")]

    [TestCase(3.00, "Average")]
    [TestCase(3.49, "Average")]

    [TestCase(3.50, "Good")]
    [TestCase(3.99, "Good")]

    [TestCase(4.00, "Very Good")]
    [TestCase(4.49, "Very Good")]

    [TestCase(4.50, "Excellent")]
    [TestCase(5.00, "Excellent")]

    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
