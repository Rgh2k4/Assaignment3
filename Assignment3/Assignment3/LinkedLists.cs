using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class LinkedList : ILinkedListADT
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = new Node();
        }

        public void Prepend(object data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void Append(object data)
        {
            Node newNode = new Node(data);

            Node current = Head;
            while (current.Next != null)
            {
            current = current.Next;
            }
            current.Next = newNode;
        }

        public void Remove(object data)
        {
        Node current = Head;
        
            for (int i = 0; i < index - 1; i++)
            {
                if (Head.Next == null)
                {
                    throw new IndexOutOfRangeException("Attempt to remove from after end of list.");
                }

                while (current.Next != null)
                {
                if (current.Next.Data.Equals(data))
                {
                current.Next = current.Next.Next;
                }
                }
                current = current.Next;
            }

            Head.Next = Head.Next.Next;
            users.Head.Next = Head;
        }

        public void RemoveFirst()
        {
        if (Head = null)
        {
        throw new IndexOutOfRangeException("Attempt to remove from empty list.");
        }
            Node Head = null;
            Head = current.Next;
        }

        public void RemoveLast()
        {
            Node current = Head;
            while (current.Next != null)
            {
            current = current.Next;
            }
            current.Next = null;
            if (Head = null)
        {
        throw new IndexOutOfRangeException("Attempt to remove from empty list.");
        }
        if (Head.next == null)
        {
        throw new IndexOutOfRangeException("Attempt to remove last from 1 node list.");
        }
        }

        public void AddIndex(int index, object data)
        {
            if (index < 1)
        {
        throw new IndexOutOfRangeException("Attempt to add from before start of list.");
        }
            if (index == null)
        {
        throw new IndexOutOfRangeException("Attempt to add from after end of list.");
        }
        
        while (current.Next != null)
                {
                if (current.Next.Index.Equals(Index))
                {
                current = current.Next;
                }
        }
        }
        }

        
        public void Replace(int index, object data)
        {
            if (index < 1)
        {
        throw new IndexOutOfRangeException("Attempt to replace from before start of list.");
        }
            if (index == null)
        {
        throw new IndexOutOfRangeException("Attempt to replace from after end of list.");
        }

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            while (current.Next != null)
                {
                if (current.Next.Index.Equals(Index))
                {
                current = (data);
                }

            Assert.AreEqual(value.Name, users.Head.Next.Next.Data.Name);
        }

            public void FindItem(object item)
        {
            Node current = Head;
            while (current.Next != null)
                {
                if (current.Data.Equals(item))
                {
                return current;
                }
                current = current.Next;
        }
         if (item == null)
        {
        throw new IndexOutOfRangeException("Attempt to retrive item not in list.");
        }
        }
        

        public void FindIndex(object item)
        {
            Node current = Head;

            while (current != null)
            {
            if (current.Data.Equals(item))
            {
            return index;
            }
                current = current.Next;
                index++;
            }
                     if (item == null)
        {
        throw new IndexOutOfRangeException("Attempt to retrive item not in list.");
        }
        }

        public void Check()
        {
            node * list;
            if (Head == null)
            {
                "No items in list" 
            }
            else {return}
        }

        public void Clear()
        {
            Head.next = null;
        }

        public int Count()
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
            count++;
            current = current.Next;
            }
            return count;
        }

        public void AlphaOrder()
        {
        User = User.OrderBy(User.name).ToList();
        }
    }
}
