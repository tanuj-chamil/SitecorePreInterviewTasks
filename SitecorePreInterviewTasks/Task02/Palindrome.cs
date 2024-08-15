using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.Task02
{
    /// <summary>
    /// Class to check if a string is a palindrome with or without trash symbols
    /// </summary>
    public class Palindrome
    {
        public string InputString { get; set; } = String.Empty;

        public string TrashSymbolString { get; set; } = String.Empty;

        public bool isPalindrome { get; set; } = true;

        public Palindrome(string inputString, string trashSymbolString)
        {
            InputString = inputString;
            TrashSymbolString = trashSymbolString;
            checkPalindrome();
        }

        /// <summary>
        /// Method to check if the input string is a palindrome with or without trash symbols
        /// </summary>
        private void checkPalindrome()
        {
            // Convert the input string to lower case to make the comparison case-insensitive
            string inputString = InputString.ToLower();
            
            int length = inputString.Length;
            int left = 0;
            int right = length - 1;

            while (left < right)
            {
                // Skip trash symbols from the left
                while (TrashSymbolString.Contains(inputString[left]) && left < right)
                {
                    // if current character is trash symbol, move to the next character
                    left++;
                }

                // Skip trash symbols from the right
                while (TrashSymbolString.Contains(inputString[right]) && left < right)
                {
                    // if current character is trash symbol, move to the next character
                    right--;
                }

                // Check if the non-trash characters are equal
                if (inputString[left] != inputString[right])
                {
                    // if the characters are not equal, the input string is not a palindrome
                    isPalindrome = false;
                    break;
                }

                // Move to the next characters
                left++;
                right--;
            }
        }
    }
}
