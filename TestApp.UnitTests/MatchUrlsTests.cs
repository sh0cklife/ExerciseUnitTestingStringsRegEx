using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new List<string>();

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "No valid URL!";
        
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "Single URL: https://softuni.bg";
        List<string> expected = new() { "https://softuni.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Multiple URLs: https://www.softuni.bg, https://softuni.com, https://softuni.net";
        List<string> expected = new() { "https://www.softuni.bg", "https://softuni.com", "https://softuni.net"};

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Single URL: \"https://softuni.bg\"";
        List<string> expected = new() { "https://softuni.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        //CollectionAssert.AreEqual(expected, result);
        Assert.That(result, Is.EqualTo(expected));
    }
}
