using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    public class BinTree
    {
        public class Vertex
        {
            public int data;
            public Vertex left = null;
            public Vertex right = null;
            public Vertex(int data)
            {
                this.data = data;
            }
        }
        public Vertex origin;
        public BinTree(int data)
        {
            origin = new Vertex(data);
        }

        public void Add(Vertex actual, Vertex n)
        {
            if (n.data < actual.data)
            {
                if (actual.left == null)    actual.left = n;
                else                        Add(actual.left, n);
            }
            else
            {
                if (actual.right == null)   actual.right = n;
                else                        Add(actual.right, n);
            }
        }
    }
}
