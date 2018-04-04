using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
  public   class DataNode
    {
        string Fname, Lname, Cnum, email, address;
        DataNode next;

        
        public string storeFname
        {
            get { return this.Fname; }
            set { this.Fname = value; }
        }
        public string storeLname
        {
            get { return this.Lname; }
            set { this.Lname = value; }
        }
        public string storeCnum
        {
            get { return this.Cnum; }
            set { this.Cnum = value; }
        }
        public string storeEmail
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string storeAddress
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public DataNode storeNext
        {
            get { return this.next; }
            set { this.next = value; }
        }
    

        public DataNode(string Name, string Lname, string num, string email, string Address)
        {
            this.storeFname = Name; this.storeLname = Lname; this.storeCnum = num; this.storeEmail = email; this.storeAddress = Address;
            this.storeNext = null;
        }
    }
    

}
