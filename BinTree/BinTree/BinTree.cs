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

        public Vertex Find(int data, Vertex actual)
        {
            if (actual == null)
            {
                return null;
            }
            if (data < actual.data)
            {
                return Find(data, actual.left);
            }
            else
            {
                if (data == actual.data)
                {
                    return actual;
                }
                else
                {
                    return Find(data, actual.right);
                }
            }
        }
 
        public long CountElements(Vertex actual)
        {
            long count = 1;
            if (actual.right != null)
            {
                count += CountElements(actual.right);
            }
            if (actual.left != null)
            {
                count += CountElements(actual.left);
            }
            return count;
        }
    }
}
