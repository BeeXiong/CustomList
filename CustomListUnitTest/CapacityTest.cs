using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class CapacityTest
    {
        [TestMethod]
        public void checkArrayCapacityTestMethod()
        {
            //arrange
            CList<int> storeValueList = new CList<int>();
            storeValueList.count = 55;
            CList<int> noValueList = new CList<int>();
            
            //act
            bool storeValueResult = storeValueList.CheckArrayCapacity();
            bool noValueResult = noValueList.CheckArrayCapacity();
            //assert
            Assert.IsTrue(storeValueResult);
            Assert.IsFalse(noValueResult);
        }
        [TestMethod]
        public void CapacityTestMethod()
        {
            //arrange
            CList<int> storeValueList = new CList<int>();
            //act
            //storing 25 intregers
            storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9); storeValueList.Add(9);
            //assert
            Assert.AreEqual(40, storeValueList.capacity);
        }
    }
}
