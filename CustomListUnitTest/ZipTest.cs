using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void StringZipTestMethod()
        {
            //arrange
            CList<string> storedValues = new CList<string>();
            CList<string> storedStrings = new CList<string>();

            CList<string> testValues = new CList<string>();
            CList<string> resultsValue = new CList<string>();

            storedStrings.Add("1");
            storedStrings.Add("3");
            storedStrings.Add("5");
            storedStrings.Add("7");
            storedStrings.Add("9");
            storedStrings.Add("11");
            storedStrings.Add("13");
            storedStrings.Add("15");

            storedValues.Add("2");
            storedValues.Add("4");
            storedValues.Add("6");
            storedValues.Add("8");
            storedValues.Add("10");
            storedValues.Add("12");
            storedValues.Add("14");
            storedValues.Add("16");

            testValues.Add("1");
            testValues.Add("2");
            testValues.Add("3");
            testValues.Add("4");
            testValues.Add("5");
            testValues.Add("6");
            testValues.Add("7");
            testValues.Add("8");
            testValues.Add("9");
            testValues.Add("10");
            testValues.Add("11");
            testValues.Add("12");
            testValues.Add("13");
            testValues.Add("14");
            testValues.Add("15");
            testValues.Add("16");

            //act
            resultsValue = storedStrings.Zip(storedValues);

            //assert
            Assert.AreEqual(testValues.count, resultsValue.count);
            Assert.AreEqual(testValues[0], resultsValue[0]);
            Assert.AreEqual(testValues[7], resultsValue[7]);
            Assert.AreEqual(testValues[15], resultsValue[15]);
        }
        [TestMethod]
        public void IntZipTestMethod()
        {
            //arrange
            CList<int> storedValues = new CList<int>();
            CList<int> storedStrings = new CList<int>();

            CList<int> testValues = new CList<int>();
            CList<int> resultsValue = new CList<int>();

            storedStrings.Add(1);
            storedStrings.Add(3);
            storedStrings.Add(5);
            storedStrings.Add(7);
            storedStrings.Add(9);
            storedStrings.Add(11);
            storedStrings.Add(13);
            storedStrings.Add(15);

            storedValues.Add(2);
            storedValues.Add(4);
            storedValues.Add(6);
            storedValues.Add(8);
            storedValues.Add(10);
            storedValues.Add(12);
            storedValues.Add(14);
            storedValues.Add(16);

            testValues.Add(1);
            testValues.Add(2);
            testValues.Add(3);
            testValues.Add(4);
            testValues.Add(5);
            testValues.Add(6);
            testValues.Add(7);
            testValues.Add(8);
            testValues.Add(9);
            testValues.Add(10);
            testValues.Add(11);
            testValues.Add(12);
            testValues.Add(13);
            testValues.Add(14);
            testValues.Add(15);
            testValues.Add(16);

            //act
            resultsValue = storedStrings.Zip(storedValues);

            //assert
            Assert.AreEqual(testValues.count, resultsValue.count);
            Assert.AreEqual(testValues[0], resultsValue[0]);
            Assert.AreEqual(testValues[7], resultsValue[7]);
            Assert.AreEqual(testValues[15], resultsValue[15]);
        }
        [TestMethod]
        public void ObjectZipTestMethod()
        {
            //arrange
            CList<int> storedValues = new CList<int>();
            CList<int> storednumbers = new CList<int>();

            CList<int> storedints = new CList<int>();
            CList<int> savedInts = new CList<int>();

            CList<CList<int>> storedList = new CList<CList<int>>();
            CList<CList<int>> savedList = new CList<CList<int>>();

            CList<CList<int>> testValues = new CList<CList<int>>();
            CList<CList<int>> resultValues = new CList<CList<int>>();

            storednumbers.Add(1);
            storednumbers.Add(1);
            storednumbers.Add(1);
            storednumbers.Add(1);
            storednumbers.Add(1);
            storednumbers.Add(1);
            storednumbers.Add(1);
            storednumbers.Add(1);

            storedValues.Add(2);
            storedValues.Add(2);
            storedValues.Add(2);
            storedValues.Add(2);
            storedValues.Add(2);
            storedValues.Add(2);
            storedValues.Add(2);
            storedValues.Add(2);

            storedints.Add(3);
            storedints.Add(3);
            storedints.Add(3);
            storedints.Add(3);
            storedints.Add(3);
            storedints.Add(3);
            storedints.Add(3);
            storedints.Add(3);

            savedInts.Add(4);
            savedInts.Add(4);
            savedInts.Add(4);
            savedInts.Add(4);
            savedInts.Add(4);
            savedInts.Add(4);
            savedInts.Add(4);
            savedInts.Add(4);

            storedList.Add(storednumbers);
            storedList.Add(storedints);
            savedList.Add(storedValues);
            savedList.Add(savedInts);

            testValues.Add(storednumbers);
            testValues.Add(storedValues);
            testValues.Add(storedints);
            testValues.Add(savedInts);
            //act
            resultValues = storedList.Zip(savedList);

            //assert
            Assert.AreEqual(testValues.count, resultValues.count);
            Assert.AreEqual(testValues[0], resultValues[0]);
            Assert.AreEqual(testValues[1], resultValues[1]);
            Assert.AreEqual(testValues[2], resultValues[2]);
            Assert.AreEqual(testValues[3], resultValues[3]);
        }
    }
}
