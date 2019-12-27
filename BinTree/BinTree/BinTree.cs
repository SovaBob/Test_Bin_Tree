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
    }
}
