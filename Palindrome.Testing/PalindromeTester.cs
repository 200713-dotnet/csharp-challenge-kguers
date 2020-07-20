using System;
using Palindrome.Domain;
using Xunit;

namespace Palindrome.Testing
{
     public class PalindromeTester
     {
          [Theory]
          [InlineData("racecar")]
          [InlineData("$1ff1$")]
          public void Test_Palindrome(string text)
          {
               //arrange
               var sut = new PalindromeChecker();
               bool test;
               //act
               test = sut.IsPalindrome(text);
               //assert
               Assert.True(test);
          } 
     }
}

