using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresDemo;

namespace MsTestingLinkedList
{
    [TestClass]
    public class TestLinkedList
    {
        LinkedListclass<int> linkedListclass;
        [TestInitialize]
        public void setup()
        {
            linkedListclass = new LinkedListclass<int>();
            linkedListclass.InsertLast(56);
            linkedListclass.InsertLast(30);
            linkedListclass.InsertLast(70);
        }
        /// <summary>
        /// This method is used to search a given element
        /// It returns the position of element if found 
        /// Else returns 0
        /// </summary>
        [TestMethod]
        public void TestToSearch()
        {
            ///Arrange
            int expectedPosition = 2;
            ///Act
            int actualPosition = linkedListclass.Search(30);
            ///Assert
            Assert.AreEqual(expectedPosition, actualPosition);
        }
        /// <summary>
        /// This Test method frst adds an new element after element
        /// And later searches for that element
        /// </summary>
        [TestMethod]
        public void TestToInsertAfterElement()
        {
            ///Arrange
            linkedListclass.InsertAfterElement(30, 40);
            int expectedPosition = 3;
            ///Act
            int actualPosition=linkedListclass.Search(40);
            ///Assert
            Assert.AreEqual(expectedPosition, actualPosition);
        }
        /// <summary>
        /// This method tests for size of linked list
        /// </summary>
        [TestMethod]
        public void TestToGetSize()
        {
            ///Arrange
            int expectedSize = 3;
            ///Act
            int actualSize = linkedListclass.Size();
            ///Assert
            Assert.AreEqual(expectedSize, actualSize);
        }


    }
}
