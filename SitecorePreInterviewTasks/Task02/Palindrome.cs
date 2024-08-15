using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecorePreInterviewTasks.Task02
{
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
        public void checkPalindrome()
        {
            string inputString = InputString.ToLower();

            int length = inputString.Length;

            int left = 0;
            int right = length - 1;

            while (left < right)
            {

                while (TrashSymbolString.Contains(inputString[left]) && left < right)
                {
                    left++;
                }

                while (TrashSymbolString.Contains(inputString[right]) && left < right)
                {
                    right--;
                }

                if (inputString[left] != inputString[right])
                {
                    isPalindrome = false;
                    break;
                }

                left++;
                right--;
            }
        }
    }
}
