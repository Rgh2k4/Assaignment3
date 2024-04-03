using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class LinkedList : ILinkedListADT
    {
        public node Head { get; set; }

        public LinkedList()
        {
            Head = new node();
        }

        public void Prepend(object data)
        {
            Node AddFirst = new Node();
            to.Add.data = data;
            Node current = Head;
            current.First = toAdd;
        }

        public void Append(object data)
        {
            Node AddLast = new Node();
            to.Add.data = data;
            Node current = Head;
            current.Last = toAdd;
        }

        public void Remove(object data)
        {
            for (int i = 0; i < index - 1; i++)
            {
                if (Head.Next == null)
                {
                    throw new IndexOutOfRangeException("Attempt to remove from after end of list.");
                }

                Head = Head.Next;
            }

            Head.Next = Head.Next.Next;
            users.Head.Next = Head;
        }

        public void RemoveFirst()
        {
            Head.next = null;
        }

        public void RemoveLast()
        {
            while (Head.Next = null) ;
        }

        public void AddIndex(int index, object data)
        {
            LinkedList<int> ll;
            ll.FindIndex().Value = "";
        }

        public void Replace(int index, object data)
        {
            Node Head = users.Head;

            for (int i = 0; i < index; i++)
            {
                Head = Head.Next;
            }
            Head.Data = value;

            Assert.AreEqual(value.Name, users.Head.Next.Next.Data.Name);
        }

            public void FindItem(object data)
        {
            LinkedList.Find();
        }

        public void FindIndex(object data)
        {
            LinkedList.indexOf();
        }

        public void Check()
        {
            node * list;
            if (list == null) { "No items in list" }
        }

        public void Clear()
        {
            Head.next = null;
        }

        public void Count()
        {
            int total = 0;
            foreach Node(total += 1)
            return ("There are", total, "items in the list");
        }

        public void Reverse()
        {

        }
    }
}
