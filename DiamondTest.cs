using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DiamondKata;
using System;
using System.Linq;

namespace DiamondKataTest
{
    [TestClass]
    public class DiamondTest
    {
        private readonly Diamond _diamond;
        private readonly string _lowerCaseAlphabets = "abcdefghijklmnopqrstuvwxyz";
        private const string InvalidCharMessage = "Invalid character"; //Should be in const file

        public DiamondTest()
        {
            _diamond = new Diamond();
        }

        [TestMethod]
        public void AlphabetError_When_NumberIsEntered()
        {
            try
            {
                List<string> lst = _diamond.Generate('4');
                Assert.IsTrue(lst.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void AlphabetError_When_SpecialCharacterIsEntered()
        {
            try
            {
                List<string> lst = _diamond.Generate('$');
                Assert.IsTrue(lst.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [TestMethod]
        public void DiamondForA_When_AIsEntered()
        {
            try
            {
                List<string> lst = _diamond.Generate('A');
                Assert.IsTrue(lst.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [TestMethod]
        public void DiamondForB_When_BIsEntered()
        {
            try
            {
                List<string> lst = _diamond.Generate('B');
                Assert.IsTrue(lst.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void DiamondForC_When_CIsEntered()
        {
            try
            {
                List<string> lst = _diamond.Generate('C');
                Assert.IsTrue(lst.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void DiamondForZ_When_ZIsEntered()
        {
            try
            {
                List<string> lst = _diamond.Generate('Z');
                Assert.IsTrue(lst.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}