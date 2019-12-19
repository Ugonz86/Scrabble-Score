using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Project.Models
{
    [TestClass]
    public class ScrabbleScoreTest
    {
        [TestMethod]
        public void GetScore_StringToInt_ExpectedInteger()
        {
            Scrabble ChecksIfScoreIsInt = new Scrabble("hi");
            int result = ChecksIfScoreIsInt.GetScore("hi");
            Assert.AreEqual(4,result);
        }

        [TestMethod]
        public void Scrabble_ValidInput_String()
        {
            Scrabble CheckesIfInputIsString = new Scrabble("hi");
            Assert.AreEqual(typeof(Scrabble), CheckesIfInputIsString.GetType());
        }
    }
}