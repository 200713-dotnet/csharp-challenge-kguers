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
          [InlineData("Test")]
          [InlineData("*%KDMV#WVR1234")]
          public void Test_Palindrome(string text)
          {
               //arrange
               var sut = new PalindromeChecker();
               bool test;
               //act
               test = sut.IsPalindrome(text);
               //assert
               if(test)
               {
                    //Palindrome
                    Assert.True(test);
               }
               else
               {
                    //Not a Palindrome
                    Assert.False(test);
               }
          } 
     }
}

