using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class OperatorTest
    {
        [TestMethod]
        public void MinusOperatorTestMethod()
        {
            //arrange
            CList<int> storedValues = new CList<int>();
            CList<int> subtractingValues = new CList<int>();
            CList<int> resultValues = new CList<int>();
            CList<int> testValues = new CList<int>();

            storedValues.Add(1);
            storedValues.Add(2);
            storedValues.Add(3);
            storedValues.Add(4);
            storedValues.Add(1);
            storedValues.Add(2);
            storedValues.Add(3);
            storedValues.Add(4);
            storedValues.Add(1);
            storedValues.Add(2);
            storedValues.Add(3);
            storedValues.Add(4);

            subtractingValues.Add(1);
            subtractingValues.Add(3);

            testValues.Add(2);
            testValues.Add(4);
            testValues.Add(2);
            testValues.Add(4);
            testValues.Add(2);
            testValues.Add(4);

            //act

            resultValues = storedValues - subtractingValues;

            //assert
            Assert.AreEqual(testValues[0], resultValues[0]);
            Assert.AreEqual(testValues[1], resultValues[1]);
            Assert.AreEqual(testValues[2], resultValues[2]);
            Assert.AreEqual(testValues[3], resultValues[3]);
            Assert.AreEqual(testValues[4], resultValues[4]);
            Assert.AreEqual(testValues[5], resultValues[5]);
            Assert.AreEqual(testValues[6], resultValues[6]);
            Assert.AreEqual(testValues.count, resultValues.count);
            Assert.AreNotEqual(storedValues[0], resultValues[0]);

            foreach(int item in resultValues)
            {
                Assert.AreNotEqual(1, item);
                Assert.AreNotEqual(3, item);
            }
        }
        [TestMethod]
        public void PlusOperatorTestMethod()
        {
            //arrange
            CList<int> storedValues = new CList<int>();
            CList<int> additionalValues = new CList<int>();
            CList<int> combinedValues = new CList<int>();
            CList<int> testValues = new CList<int>();

            storedValues.Add(0);
            storedValues.Add(1);
            storedValues.Add(2);

            additionalValues.Add(3);
            additionalValues.Add(4);
            additionalValues.Add(5);

            testValues.Add(0);
            testValues.Add(1);
            testValues.Add(2);
            testValues.Add(3);
            testValues.Add(4);
            testValues.Add(5);

            //act

            combinedValues = storedValues + additionalValues;

            //assert
            Assert.AreEqual(testValues[0], combinedValues[0]);
            Assert.AreEqual(testValues[5], combinedValues[5]);
            Assert.AreEqual(testValues[9], combinedValues[9]);
            Assert.AreEqual(testValues.count, combinedValues.count);
            Assert.AreEqual(testValues.capacity, testValues.capacity);
        }
        [TestMethod]
        public void PlusOpCapacityTestMethod()
        {
            //arrange
            CList<int> storedValues = new CList<int>();
            CList<int> additionalValues = new CList<int>();
            CList<int> combinedValues = new CList<int>();
            CList<int> testValues = new CList<int>();

            storedValues.Add(0);
            storedValues.Add(1);
            storedValues.Add(2);
            storedValues.Add(3);
            storedValues.Add(4);
            storedValues.Add(5);

            additionalValues.Add(6);
            additionalValues.Add(7);
            additionalValues.Add(8);
            additionalValues.Add(9);
            additionalValues.Add(10);
            additionalValues.Add(11);

            testValues.Add(0);
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

            //act

            combinedValues = storedValues + additionalValues;

            //assert
            Assert.AreEqual(testValues[0], combinedValues[0]);
            Assert.AreEqual(testValues[5], combinedValues[5]);
            Assert.AreEqual(testValues[9], combinedValues[9]);
            Assert.AreEqual(testValues[15], combinedValues[15]);
            Assert.AreEqual(testValues.count, combinedValues.count);
            Assert.AreEqual(testValues.capacity, testValues.capacity);
        }
    }
}
