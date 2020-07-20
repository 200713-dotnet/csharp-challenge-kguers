using System;
using Palindrome.Domain;
using Xunit;

namespace Palindrome.Testing
{
     public class PalindromeTester
     {
          [Theory]
          [InlineData("racecar")]
          [InlineData("Test")]
          [InlineData("$1ff1$")]
          public static bool Test_Palindrome(string text)
          {
               //arrange
               var sut = new PalindromeChecker();
               bool test;
               //act
               test = sut.isPalindrome(text);
               //assert
               Assert.True(test);
          } 
     }
}

