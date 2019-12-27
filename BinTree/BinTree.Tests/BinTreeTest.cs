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

        [Test]
        public void TestFind()
        {
            BinTree t = new BinTree(25);
            t.Add(t.origin, new BinTree.Vertex(0));
            t.Add(t.origin, new BinTree.Vertex(17));
            t.Add(t.origin, new BinTree.Vertex(10));
            t.Add(t.origin, new BinTree.Vertex(5));

            BinTree.Vertex n = t.Find(1, t.origin);
            Assert.AreEqual(n, null);

            n = t.Find(17, t.origin);
            Assert.AreEqual(n, t.origin.left.right);
        }

        [Test]
        public void TestCountElements()
        {
            BinTree t = new BinTree(5);
            t.Add(t.origin, new BinTree.Vertex(2));
            t.Add(t.origin, new BinTree.Vertex(3));
            t.Add(t.origin, new BinTree.Vertex(4));
            t.Add(t.origin, new BinTree.Vertex(1));

            long n = t.CountElements(t.origin);
            Assert.AreEqual(n, 5);
        }

        [Test]
        public void TestSummaElements()
        {
            BinTree t = new BinTree(0);
            t.Add(t.origin, new BinTree.Vertex(-5));
            t.Add(t.origin, new BinTree.Vertex(5));

            long n = t.SummaElements(t.origin);
            Assert.AreEqual(n, 0);
        }
    }
}