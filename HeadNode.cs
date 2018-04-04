using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class HeadNode
    {
        char value;
        public HeadNode Head;
        public HeadNode Tail;
        public DataNode dnode;     //down node (child node)


        public DataNode storeDnode
        {
            get { return this.dnode; }
            set { this.dnode = value; }
        }
        public HeadNode storeNxt
        {
            get { return this.Head; }
            set { this.Head = value; }
        }
        public HeadNode storePrv
        {
            get { return this.Tail; }
            set { this.Tail = value; }
        }

        public HeadNode(char val)
        {
            this.value = val;
            this.Head = null;
            this.Tail = null;
            this.dnode = null;
        }
        public char storeValue
        {
            get { return this.value; }
            set { this.value = value; }
        }
      
         



    }
}
