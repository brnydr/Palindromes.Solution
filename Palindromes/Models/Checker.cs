using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes.Models
{
  public class Checker
  {
    string wordToCheck {get; set;}

    public Checker(string wrdToChck)
    {
      wordToCheck = wrdToChck;
    }

    public string IsPalindrome()
    {
      char[] charArray = this.wordToCheck.ToCharArray();
      List<char> charList = new List<char>();

      for(int i = charArray.Length - 1; i >= 0; i--)
      {
        charList.Add(charArray[i]);
      }

      bool isEqual = charArray.SequenceEqual(charList.ToArray());

      if (isEqual)
      {
        return "this is a palindrome";
      }
      else
      {
        return "this is not a palindrome";
      }
    }
  }
}