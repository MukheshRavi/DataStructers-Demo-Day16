using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresDemo;

namespace MsTestingLinkedList
{
    [TestClass]
    public class TestToSearch
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
        [TestMethod]
        public void TestMethod1()
        {
            ///Arrange
            int expectedPosition = 2;
            ///Act
            int actualPosition = linkedListclass.Search(30);
            ///Assert
            Assert.AreEqual(expectedPosition, actualPosition);
        }
    }
}
