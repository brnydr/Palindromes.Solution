using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Palindromes.Models;


namespace Palindromes.Tests
{
  [TestClass]
  public class CheckerTests 
  {
    [TestMethod]
    public void CheckerConstructor_CreatesInstanceOfChecker_Checker()
    {
      Checker newChecker = new Checker("radio");
      Assert.AreEqual(typeof(Checker), newChecker.GetType());
    }

    [TestMethod]
    public void isPalindrome_ReturnsTrueIfPalindrome_Bool()
    {
      Checker newChecker = new Checker("radio");
      Assert.AreEqual(true, newChecker.IsPalindrome());
    }
  }
}