using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void IntToStringTestMethod()
        {
            //arrange
            CList<int> storedInts = new CList<int>();
            string testString;
            string resultString;

            storedInts.Add(1);
            storedInts.Add(2);
            storedInts.Add(3);
            storedInts.Add(4);
            storedInts.Add(5);

            testString = "1,2,3,4,5";
            //act
            resultString = storedInts.ToString();
            //assert
            Assert.AreEqual(testString, resultString);
        }
        [TestMethod]
        public void StringToStringTestMethod()
        {
            //arrange
            CList<string> storedStrings = new CList<string>();
            string testString;
            string resultString;

            storedStrings.Add("This");
            storedStrings.Add("Is");
            storedStrings.Add("A");
            storedStrings.Add("Test");
            storedStrings.Add(".");

            testString = "This,Is,A,Test,.";
            //act
            resultString = storedStrings.ToString();
            //assert
            Assert.AreEqual(testString, resultString);
        }
        [TestMethod]
        public void ListToStringTestMethod()
        {
            //arrange
            CList<CList<string>> storedList = new CList<CList<string>>();
            CList<string> storedInts = new CList<string>();
            CList<string> storedStrings = new CList<string>();
            string testString;
            string resultString;

            storedInts.Add("1");
            storedInts.Add("2");
            storedInts.Add("3");
            storedInts.Add("4");
            storedInts.Add("5");

            storedStrings.Add("This");
            storedStrings.Add("Is");
            storedStrings.Add("A");
            storedStrings.Add("Test");
            storedStrings.Add(".");

            storedList.Add(storedInts);
            storedList.Add(storedStrings);

            testString = "1,2,3,4,5,This,Is,A,Test,.";

            //act
            resultString = storedList.ToString();
            //assert
            Assert.AreEqual(testString, resultString);
        }

    }
}
