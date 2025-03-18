using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSParsingConsoleApp;
using System;

namespace QSParsingConsoleApp.Test;

[TestClass]
public class QSParsingUnitTest
{
    [TestMethod]
    public void Count_SinglePair_ReturnsOne()
    {
        // Arrange
        QSParser parser = new QSParser();

        // Act
        int result = parser.Count("name=John");

        // Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Count_TwoPairs_ReturnsTwo()
    {
        // Arrange
        QSParser parser = new QSParser();

        // Act
        int result = parser.Count("name=John&age=30");

        // Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void Count_EmptyString_ReturnsZero()
    {
        // Arrange
        QSParser parser = new QSParser();

        // Act
        int result = parser.Count("");

        // Assert
        Assert.AreEqual(0, result);
    }
}