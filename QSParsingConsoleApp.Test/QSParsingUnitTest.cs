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

    [TestMethod]
    public void ValueOf_MultiplePairs_ReturnsCorrectValue()
    {
        // Arrange
        QSParser parser = new QSParser();

        // Act
        string resultName = parser.ValueOf("age=30&name=John&city=Aarhus", "name");
        string resultAge = parser.ValueOf("age=30&name=John&city=Aarhus", "age");
        string resultCity = parser.ValueOf("age=30&name=John&city=Aarhus", "city");

        // Assert
        Assert.AreEqual("John", resultName);  // Forventer "John" for "name"
        Assert.AreEqual("30", resultAge);     // Forventer "30" for "age"
        Assert.AreEqual("Aarhus", resultCity); // Forventer "Aarhus" for "city"
    }


}