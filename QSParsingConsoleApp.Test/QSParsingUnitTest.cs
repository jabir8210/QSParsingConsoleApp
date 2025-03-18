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
    public void Count_EmptyString_ReturnsZero()
    {
        // Arrange
        QSParser parser = new QSParser();

        // Act
        int result = parser.Count("");

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Count_NullString_ReturnsZero()
    {
        // Arrange
        QSParser parser = new QSParser();

        // Act
        int result = parser.Count(null);

        // Assert
        Assert.AreEqual(0, result);
    }


    [TestMethod]
    public void ValueOf_SinglePair_ReturnsValue()
    {
        // Arrange
        QSParser parser = new QSParser();

        // Act
        string result = parser.ValueOf("name=John", "name");

        // Assert
        Assert.AreEqual("John", result);
    }





}