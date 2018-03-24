using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void RemoveTestMethod()
        {
            //arrange
            CList<int> storedInts = new CList<int>();

            storedInts.Add(1);
            storedInts.Add(2);
            storedInts.Add(3);
            storedInts.Add(4);
            storedInts.Add(5);
            
            //act
            storedInts.Remove();

            //assert
            Assert.AreEqual(2,storedInts[0]);
            Assert.AreEqual(3, storedInts[1]);
            Assert.AreEqual(4, storedInts[2]);
            Assert.AreEqual(5, storedInts[3]);
            Assert.AreEqual(0, storedInts[4]);
            Assert.IsTrue(storedInts.count == 4);
        }

        [TestMethod]
        public void RemoveAtTestMethod()
        {
            //arrange
            CList<int> storedInts = new CList<int>();

            storedInts.Add(1);
            storedInts.Add(2);
            storedInts.Add(3);
            storedInts.Add(4);
            storedInts.Add(5);

            //act
            storedInts.RemoveAt(3);

            //assert
            Assert.AreEqual(1, storedInts[0]);
            Assert.AreEqual(2, storedInts[1]);
            Assert.AreEqual(3, storedInts[2]);
            Assert.AreEqual(5, storedInts[3]);
            Assert.AreEqual(0, storedInts[4]);
            Assert.IsTrue(storedInts.count == 4);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException),
            "Cannot accept a Null Reference. Indexer is out of the bounds of the array")]
        public void EmptyRemoveAtTestMethod()
        {
            //arrange
            CList<int> storedInts = new CList<int>();
            storedInts.Add(1);

            //act
            storedInts.RemoveAt(3);

            //assert
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException),
        "Cannot accept a Null Reference. List does not have anything in it")]
        public void FirstRemoveAtTestMethod()
        {
            //arrange
            CList<int> storedInts = new CList<int>();

            //act
            storedInts.RemoveAt(0);

            //assert
            Assert.Fail();
        }
    }
}
