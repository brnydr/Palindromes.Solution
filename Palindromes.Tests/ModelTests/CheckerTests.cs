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
    public void isPalindrome_ReturnsTrueWhenInvoked_String()
    {
      Checker newChecker = new Checker("radio");
      Assert.AreEqual("this is not a palindrome", newChecker.IsPalindrome());
    }

    [TestMethod]
    public void isPalidrome_RetrunsTrueWhenPalidrome_String()
    {
      Checker newChecker = new Checker("maam");
      Assert.AreEqual("this is a palindrome", newChecker.IsPalindrome());
    }
  }
}