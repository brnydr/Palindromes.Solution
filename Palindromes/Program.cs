using Palindromes.Models;
using System;

namespace Palindromes
{
    class Program
    {
      static void Main()
      {
        Console.WriteLine("Enter a word to check if it is a palindrome:");
        string input = Console.ReadLine();
        Checker newChecker = new Checker(input);
        Console.WriteLine(newChecker.IsPalindrome());
      }
    }
}