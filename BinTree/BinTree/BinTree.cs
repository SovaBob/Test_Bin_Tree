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

        public int SummaElements(Vertex actual)
        {
            if (actual == null)
                return 0;
            else
            {
                int count = 0;
                count += SummaElements(actual.left);
                count += SummaElements(actual.right);

                return count + actual.data;
            }
        }

        public Vertex Delete(Vertex actual, int data)
        {
            if (actual == null)
            {
                return null;
            }
            if (data < actual.data)
            {
                actual.left = Delete(actual.left, data);
            }
            else
            {
                if (data > actual.data)
                {
                    actual.right = Delete(actual.right, data);
                }
                else
                {
                    if (actual.right == null)
                    {
                        return actual.left;
                    }
                    else
                    {
                        Vertex parent = actual.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        actual.data = parent.data;
                        actual.right = Delete(actual.right, parent.data);
                    }
                }
            }
            return actual;
        }

        public void Delete(int data)
        {
            origin = Delete(origin, data);
        }

    }
}
