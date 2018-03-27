using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class IterationTest
    {
        [TestMethod]
        public void IterableTestMethod()
        {
            //arrange
            CList<int> storedValues = new CList<int>();
            int counter;

            counter = 0;

            storedValues.Add(1);
            storedValues.Add(2);
            storedValues.Add(3);
            storedValues.Add(4);
            storedValues.Add(5);
            storedValues.Add(6);
            storedValues.Add(7);
            storedValues.Add(8);
            storedValues.Add(9);
            storedValues.Add(0);

            //act   
            foreach(int number in storedValues)
            {
                counter = counter + number;
            }

            //assert
            Assert.AreEqual(45, counter);
        }
    }
}
