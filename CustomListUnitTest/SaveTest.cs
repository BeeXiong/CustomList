using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class SaveTest
    {
        [TestMethod]
        public void StoreValueTestMethod()
        {
            //arrange  
            CList<int> storeValueList = new CList<int>();
            //act
            storeValueList.Add(9);
            storeValueList.Add(8);
            storeValueList.Add(7);
            storeValueList.Add(6);
            storeValueList.Add(5);
            storeValueList.Add(4);
            storeValueList.Add(3);
            storeValueList.Add(2);
            storeValueList.Add(1);
            storeValueList.Add(0);
            //assert
            Assert.AreEqual(9, storeValueList[0]);
            Assert.AreEqual(8, storeValueList[1]);
            Assert.AreEqual(7, storeValueList[2]);
            Assert.AreEqual(6, storeValueList[3]);
            Assert.AreEqual(5, storeValueList[4]);
            Assert.AreEqual(4, storeValueList[5]);
            Assert.AreEqual(3, storeValueList[6]);
            Assert.AreEqual(2, storeValueList[7]);
            Assert.AreEqual(1, storeValueList[8]);
            Assert.AreEqual(0, storeValueList[9]);
        }
        [TestMethod]
        public void StoreStringTestMethod()
        {
            //arrange  
            CList<string> storeValueList = new CList<string>();
            //act
            storeValueList.Add("this");
            storeValueList.Add("is");
            storeValueList.Add("a");
            storeValueList.Add("test");

            //assert
            Assert.AreEqual("this", storeValueList[0]);
            Assert.AreEqual("is", storeValueList[1]);
            Assert.AreEqual("a", storeValueList[2]);
            Assert.AreEqual("test", storeValueList[3]);
        }
        [TestMethod]
        public void StoreListTestMethod()
        {
            //arrange  
            CList<CList<string>> storeValueList = new CList<CList<string>>();

            CList<string> stringList = new CList<string>();
            stringList.Add("this");
            stringList.Add("is");
            stringList.Add("a");
            stringList.Add("test");

            CList<string> stringOfNumbers = new CList<string>();
            stringOfNumbers.Add("1");
            stringOfNumbers.Add("2");
            stringOfNumbers.Add("3");
            stringOfNumbers.Add("4");

            //act
            storeValueList.Add(stringList);
            storeValueList.Add(stringOfNumbers);

            //assert
            Assert.AreSame(stringList, storeValueList[0]);
            Assert.AreSame(stringOfNumbers, storeValueList[1]);
        }
    }
}
