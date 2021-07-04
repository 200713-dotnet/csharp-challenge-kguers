using System;

namespace Palindrome.Domain
{
     public class PalindromeChecker
     {
          public bool IsPalindrome(string text)
          {
               if (text.Length <= 1)
                    return true;
               else
               {
                    if (text[0] != text[text.Length - 1])
                         return false;
                    else
                         return IsPalindrome(text.Substring(1, text.Length - 2));
               }
          }

     }
}
