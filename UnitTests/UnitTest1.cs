using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System.Linq;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class T_SplitString
    {
        [TestMethod]
        public void TestMethodSplit()
        {
            // arrange

            // act
            List<string> testSplit = Splitter.SplitString("tests tests");
            var testArray = new List<string>{ "tests", "tests" };
            // assert
            CollectionAssert.AreEqual(testArray,testSplit);
        }
    }

    [TestClass]
    public class T_CountStrings
    {
        [TestMethod]
        public void CountStrings_StringsCountFromList()
        {
            // arrange
            var testStringList = new List<string>{ "one", "two", "three" };
            // act
            int counter = CountStrings.StringsCountFromList(testStringList);
            // assert
            Assert.AreEqual(counter,3);
        }
    }

    [TestClass]
    public class T_StopWords
    {
        [TestMethod]
        public void StopWords_ReturnCleansedString()
        {
            // arrange
            var blackList = new string[] { "a", "b" };
            var in_RawList = new List<string> { "a", "b", "c" };
            var cleansedList = new List<string> { "c" };
            // act
            List<string> resultList = StopWords.ReturnCleansedString(blackList, in_RawList);
            // assert
            CollectionAssert.Equals(resultList,cleansedList);
        }
    }

    
}
