using NUnit.Framework;
using BinTree;

namespace BinTree.Tests
{
    [TestFixture]
    public class BinTreeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1)]
        public void TestConstructor(int data)
        {
            BinTree t = new BinTree(data);
            Assert.AreEqual(data, t.origin.data);
        }
    }
}