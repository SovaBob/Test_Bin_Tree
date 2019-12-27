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

        [Test] 
        public void TestAdd()
        {
            BinTree t = new BinTree(100);

            BinTree.Vertex
            n = new BinTree.Vertex(80);    t.Add(t.origin, n);
            Assert.AreEqual(n, t.origin.left);

            n = new BinTree.Vertex(70); t.Add(t.origin, n);
            Assert.AreEqual(n, t.origin.left.left);

            n = new BinTree.Vertex(90); t.Add(t.origin, n);
            Assert.AreEqual(n, t.origin.left.right);

            n = new BinTree.Vertex(110);    t.Add(t.origin, n);
            Assert.AreEqual(n, t.origin.right);

        }
    }
}