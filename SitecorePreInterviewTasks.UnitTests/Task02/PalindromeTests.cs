using SitecorePreInterviewTasks.Task02;

namespace SitecorePreInterviewTasks.UnitTests.Task02
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void checkPalindrome_WhenInputStringIsPalindrome_ReturnsTrue()
        {
            // Arrange
            string inputString = "Racecar";
            string trashSymbolString = "";
            Palindrome palindrome = new Palindrome(inputString, trashSymbolString);

            // Act
            bool result = palindrome.isPalindrome;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkPalindrome_WhenInputStringIsNotPalindrome_ReturnsFalse()
        {
            // Arrange
            string inputString = "Hello";
            string trashSymbolString = "";
            Palindrome palindrome = new Palindrome(inputString, trashSymbolString);

            // Act
            bool result = palindrome.isPalindrome;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void checkPalindrome_WhenInputStringIsPalindromeWithTrashSymbols_ReturnsTrue()
        {
            // Arrange
            string inputString = "a@b!!b$a";
            string trashSymbolString = "!@$";
            Palindrome palindrome = new Palindrome(inputString, trashSymbolString);

            // Act
            bool result = palindrome.isPalindrome;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkPalindrome_WhenInputStringIsNotPalindromeWithTrashSymbols_ReturnsFalse()
        {
            // Arrange
            string inputString = "?Aa#c";
            string trashSymbolString = "#?";
            Palindrome palindrome = new Palindrome(inputString, trashSymbolString);

            // Act
            bool result = palindrome.isPalindrome;

            // Assert
            Assert.IsFalse(result);
        }

    }
}