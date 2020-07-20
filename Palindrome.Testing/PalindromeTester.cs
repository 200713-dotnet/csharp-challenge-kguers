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
               bool test;
               //act
               test = isPalindrome(text);
               //assert
               Assert.NotNull(test);
               Assert.True(test);
          } 
     }
}
}
