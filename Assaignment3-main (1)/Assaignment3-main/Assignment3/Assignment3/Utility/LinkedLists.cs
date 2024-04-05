using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
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

        public void Prepend(User data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void Append(User data)
        {
            Node newNode = new Node(data);

            if (Head.Data == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void Remove(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Attempt to remove from before start of list.");
            }

            if (index == 0)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            Node prev = null;
            int currentIndex = 0;

            while (current != null && currentIndex != index)
            {
                prev = current;
                current = current.Next;
                currentIndex++;
            }

            if (current == null)
            {
                throw new IndexOutOfRangeException("Attempt to remove index out of list bounds.");
            }

            prev.Next = current.Next;
        }

        public void RemoveFirst()
        {
            if (Head.Data == null)
            {
                throw new InvalidOperationException("Attempt to remove from empty list.");
            }
            Head = Head.Next;
        }

        public void RemoveLast()
        {
            if (Head.Data == null)
            {
                throw new InvalidOperationException("Attempt to remove from empty list.");
            }
            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            Node current = Head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

        public void AddIndex(int index, object data)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Attempt to add negative index.");
            }

            if (index == 0)
            {
                Prepend((User)data);
                return;
            }

            Node newNode = new Node((User)data);
            Node current = Head;
            int currentIndex = 0;

            while (current != null && currentIndex != index - 1)
            {
                current = current.Next;
                currentIndex++;
            }

            if (current == null)
            {
                throw new IndexOutOfRangeException("Attempt to add index out of list bounds.");
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public bool IsEmpty()
        {
            if (Head.Data != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Clear()
        {
            Head.Data = null;
            Head.Next = null;
        }

        public void AddLast(User value)
        {
            Append(value);
        }

        public void AddFirst(User value)
        {
            Prepend(value);
        }

        public void Add(User value, int index)
        {
            AddIndex(index, value);
        }

        public void Replace(User value, int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Attempt to replace negative index.");
            }

            Node current = Head;
            int currentIndex = 0;

            while (current != null && currentIndex != index)
            {
                current = current.Next;
                currentIndex++;
            }

            if (current == null)
            {
                throw new IndexOutOfRangeException("Attempt to replace index out of list bounds.");
            }

            current.Data = value;
        }

        public int Count()
        {
            int count = 0;
            if (Head.Data != null)
            {
                count = 1;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        public void Remove(object data)
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Attempt to remove from empty list.");
            }

            Node current = Head;
            Node prev = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (prev == null)
                    {
                        Head = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    return;
                }
                prev = current;
                current = current.Next;
            }

            throw new InvalidOperationException("Attempt to remove non-existant item.");
        }

        public User GetValue(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Attempt to get negative index value.");
            }

            Node current = Head;
            int currentIndex = 0;

            while (current != null && currentIndex != index)
            {
                current = current.Next;
                currentIndex++;
            }

            if (current == null)
            {
                throw new IndexOutOfRangeException("Attempt to get index value beyond list bounds.");
            }

            return current.Data;
        }

        public int IndexOf(User value)
        {
            Node current = Head;
            int index = 0;

            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        }

        public void Reverse()
        {
            Node current = Head;
            Node next = null;
            Node prev = null;

            while (current != null)
            {
                current.Next = next;
                current.Next = prev;
                prev = current;
                next = current;
            }
            Head = prev;
        }
    }
}
