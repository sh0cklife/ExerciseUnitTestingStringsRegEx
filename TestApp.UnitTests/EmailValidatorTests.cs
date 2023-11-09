using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("denis@abv.bg")]
    [TestCase("denis123@gmail.com")]
    [TestCase("123d@yahoo.com")]
    [TestCase("123.d_denis@abv.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("invalid mail@valid.com")]
    [TestCase("invalid%mail@_valid.com")]
    [TestCase("ivalid/mail@invalid.co")]
    [TestCase("ivalid/mail@invalidcom")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
