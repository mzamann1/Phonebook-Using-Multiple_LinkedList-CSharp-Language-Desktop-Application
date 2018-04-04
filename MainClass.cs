using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Phonebook
{
     class MainClass
    {
        HeadNode Header;
        HeadNode Pointer;
        DataNode dnode;
        DataNode pointer;



        public MainClass()
        {
            Header = null;
            Pointer = null;
            dnode = null;
        }

        public void CreateXLinkedList()
        {
            for (int k = 65; k <= 91; k++)
            {
                char val = (char)k;
                HeadNode n = new HeadNode(val);
                if (Header == null)
                {
                    Header = n;
                    Pointer = n;
                    dnode = null;
                }
                else
                {
                    Pointer.storeNxt = n;
                    n.storePrv = Pointer;
                    Pointer = Pointer.storeNxt;

                }
            }
        }

        public void AddToYLinkedList(string Name, string Lname, string num, string email, string Address)
        {
            Name = Name.ToUpper();
            Lname = Lname.ToUpper();
            Address = Address.ToUpper();
            if (this.IsAvailableIndex(Name[0]) == true)
            {
                HeadNode ptr;
                int check = (int)Name[0];
                if (check >= 65 && check <= 78)
                {
                    ptr = this.ForwardGo(Name[0]);
                }
                else if (check >= 78 && check <= 91)
                {
                    ptr = this.ReverseGo(Name[0]);
                }
                else
                {
                    ptr = null;
                }
                if (ptr != null)
                {
                    dnode = new DataNode(Name, Lname, num, email, Address);
                    if (ptr.storeDnode == null)
                    {
                        ptr.storeDnode = dnode;
                        pointer = dnode;
                    }
                    else
                    {
                        pointer.storeNext = dnode;
                        pointer = pointer.storeNext;
                    }
                }

                else
                {
                    Console.WriteLine(" Read the precautions. ");
                }
            }
            else
            {
                Console.WriteLine("Doesnot Exists");
            }
        }

        public bool DeleteFromYLinkedList(string Name, string Lname)
        {
            HeadNode ptr;
            Name = Name.ToUpper();
            Lname = Lname.ToUpper();
            int check = (int)Name[0];
            if (check >= 65 && check <= 78)
            {
                ptr = this.ForwardGo(Name[0]);
            }
            else if (check >= 78 && check <= 91)
            {
                ptr = this.ReverseGo(Name[0]);
            }
            else
            {
                ptr = null;
            }
            if (ptr != null)
            {
                DataNode deletenode = ptr.storeDnode;
                while (deletenode.storeNext != null)
                {
                    if (ptr.storeDnode.storeFname == Name)
                    {
                        ptr.storeDnode = deletenode.storeNext;
                    }
                    else if (deletenode.storeNext.storeFname == Name && deletenode.storeNext.storeLname == Lname)
                    {
                        ptr.storeDnode.storeNext = deletenode.storeNext.storeNext;
                        break;
                    }
                    deletenode = deletenode.storeNext;

                }
                return true;
            }
            return false;



        }
        public void Print()
        {
            char[] a = new char[26];
            string[] b = new string[100];



            for (HeadNode printNode = Header; printNode != null; printNode = printNode.storeNxt)
            {
                Console.WriteLine("HeadNode Value :" + printNode.storeValue);
               // Console.WriteLine("Contacts Found: " + printNode.GetSize);
                for (DataNode dn = printNode.storeDnode; dn != null; dn = dn.storeNext)
                {
                    Console.WriteLine("First Name:  " + dn.storeFname);
                    Console.WriteLine("Last Name:" + dn.storeLname);
                    Console.WriteLine("Full Name : " + dn.storeFname + "  " + dn.storeLname);
                    Console.WriteLine("Num : " + dn.storeCnum);
                    Console.WriteLine("Email:  " + dn.storeEmail);
                    Console.WriteLine("Address: " + dn.storeAddress);
                    
                }

            }

        }
        public DataNode[] GetAllContacts()
        {
            DataNode[] d = new DataNode[10];
            int i = 0;
            HeadNode printNode = Header;
            DataNode dn;
            while (printNode != null)
            {
                dn = printNode.storeDnode;
                while (dn != null)
                {
                    d[i] = dn;
                    i++;
                    dn = dn.storeNext;
                }
                printNode = printNode.storeNxt;
            }
            return d;
        }
        public void ReversePrint()
        {
            HeadNode printNode = Pointer;
            while (printNode != null)
            {
                Console.WriteLine(printNode.storeValue);
                printNode = printNode.storePrv;
            }
        }
        public HeadNode ReverseGo(char val)
        {
            HeadNode curr = Pointer;
            while (curr.storeValue != val && curr.storePrv != null)
            {
                Console.WriteLine(curr.storeValue);
                curr = curr.storePrv;
            }
            return curr;
        }
        public HeadNode ForwardGo(char val)
        {
            HeadNode h = Header;
            while (h.storeValue != val )
            {
                h = h.storeNxt;
            }
            return h;
        }
        public bool IsAvailableIndex(char Value)
        {
            HeadNode xway = Header;
            // Node yway = Header.storeDnode;

            while (xway != null && Value != xway.storeValue)
            {
                xway = xway.storeNxt;
            }
            return (xway != null);
        }

        public bool IsNumAlreadyExists(string num)
        {
            HeadNode printNode = Header;
            DataNode dn;
            while (printNode != null)
            {
                dn = printNode.storeDnode;
                while (dn != null)
                {
                    if (dn.storeCnum == num)
                    {
                        return true;
                    }
                    dn = dn.storeNext;
                }
                printNode = printNode.storeNxt;
            }
            return false;
        }

        public bool IsEmailAlreadyExists(string email)
        {
            HeadNode printNode = Header;
            DataNode dn;
            while (printNode != null)
            {
                dn = printNode.storeDnode;
                while (dn != null)
                {
                    if (dn.storeEmail == email)
                    {
                        return true;
                    }
                    dn = dn.storeNext;
                }
                printNode = printNode.storeNxt;
            }
            return false;
        }

     

        public bool IsNameAlreadyExists(string Name)
        {
            Name = Name.ToUpper();
            bool f;
            if (this.IsAvailableIndex(Name[0]) == true)
            {
                HeadNode ptr;
                int check = (int)Name[0];
                if (check >= 65 && check <= 78)
                {
                    ptr = this.ForwardGo(Name[0]);
                }
                else if (check >= 78 && check <= 91)
                {
                    ptr = this.ReverseGo(Name[0]);
                }
                else
                {
                    ptr = null;
                }


                if (ptr != null)
                {

                    for (DataNode dn = ptr.storeDnode; dn != null; dn = dn.storeNext)
                    {
                        if (dn.storeFname == Name)
                        {
                            f = true;
                            return f;
                        }
                        f = false;
                    }

                }
                return false;
            }


            else
            {
                return true ;
            }
        }

        public DataNode[] SearchContact(string Name)
        {
            Name = Name.ToUpper();
            DataNode[] d = new DataNode[10];
            int i = 0;
            HeadNode printNode = Header;
            DataNode dn;
            while (printNode != null)
            {
                dn = printNode.storeDnode;
                while (dn != null)
                {
                    if (dn.storeFname == Name || dn.storeLname == Name || dn.storeFname + " " + dn.storeLname == Name)
                    {
                        d[i] = dn;
                        i++;
                    }
                    dn = dn.storeNext;
                }
                printNode = printNode.storeNxt;
            }
            return d;
        }

        public DataNode[] GetContactByIndex(char val)
        {
            DataNode[] dn = new DataNode[20];
            HeadNode ptr;
            int i = 0;
            int check = (int)val;
            if (check >= 65 && check <= 78)
            {
                ptr = this.ForwardGo(val);
            }
            else if (check >= 78 && check <= 91)
            {
                ptr = this.ReverseGo(val);
            }
            else
            {
                ptr = null;
            }

            if (ptr != null)
            {
                for (DataNode d = ptr.storeDnode; d != null; d = d.storeNext)
                {
                    dn[i] = d;
                    i++;
                }
                return dn;
            }

            else
            {
                return null;
            }
        }

        public void SaveToFile(char p, DataNode[] list)
        {
            string opath = @"E:\UNI WORK\4th Semester\Data Structure\Work\PhoneBook\Phonebook\Phonebook\data\";
            if (Directory.Exists(opath) != true)
            {
                Directory.CreateDirectory(opath);

            }

            for (int i = 0; i < list.Length; i++)
            {

                if (list[i] != null)
                {
                    string path = opath + list[i].storeFname + " " + list[i].storeLname + ".txt";
                    //   path += list[i].storeFname + " " + list[i].storeLname+".txt";
                    string[] arr = new string[5];
                    arr[0] = list[i].storeFname;
                    arr[1] = list[i].storeLname;
                    arr[2] = list[i].storeEmail;
                    arr[3] = list[i].storeCnum;
                    arr[4] = list[i].storeAddress;
                    File.WriteAllLines(path, arr);
                }


            }


        }

        public void SaveAllContacts()
        {

            DataNode[] d = new DataNode[10];
            int i = 0;
            HeadNode printNode = Header;
            DataNode dn;
            while (printNode != null)
            {
                dn = printNode.storeDnode;
                while (dn != null)
                {
                    d[i] = dn;
                    i++;
                    dn = dn.storeNext;
                }
                char a = printNode.storeValue;

                printNode = printNode.storeNxt;
                SaveToFile(a, d);
            }

        }

        public void ReadAllContacts()
        {
            string opath = @"E:\UNI WORK\4th Semester\Data Structure\Work\PhoneBook\Phonebook\Phonebook\data\";

            string[] filenames = Directory.GetFiles(opath);
            for (int i = 0; i < filenames.Length; i++)
            {
                string[] data = File.ReadAllLines(filenames[i]);
                this.AddToYLinkedList(data[0], data[1], data[3], data[2], data[4]);
            }
        }
      

    }
}

