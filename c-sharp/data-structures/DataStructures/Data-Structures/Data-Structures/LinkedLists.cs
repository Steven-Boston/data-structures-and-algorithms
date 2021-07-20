using System;

namespace DataStructures
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {  }
        public void Insert(int value)
        {
            Node node = new Node(value);
            if (Head != null)
            {
                node.Next = Head;
            }
            Head = node;
            Console.WriteLine($"Added {node.Value}");
        }

        public bool Includes(int value)
        {
            Node current = Head;

            while (current != null)
            {
                if(value == current.Value)
                {
                    Console.WriteLine($"This list contains {value}");
                    return true;
                }
                current = current.Next;
            }
            Console.WriteLine($"The list does not contain {value}");
            return false;
        }

        public string ListToString()
        {
            string output = "";
            Node current = Head;
            while (current != null)
            {
                output = output + $"{current.Value} -> ";
                current = current.Next;
            }
            output += "NULL";
            Console.WriteLine(output);
            return output;
        }
        public void AppendLinked(int value)
        {
            Node newNode = new Node(value);
            bool finished = false;
            if (Head == null)
            {
              Head = newNode;
              finished = true;
            }
            Node current = Head;
            while (finished == false)
            {
              if (current.Next == null)
              {
                current.Next = newNode;
                finished = true;
              }
              current = current.Next;
            }
        }
        public void InsertBefore(int before, int value)
        {
            Node newNode = new Node(value);
            bool finished = false;
            Node current = Head;
            Node previous = null;
            if (current.Value == before)
            {
              Insert(value);
              return;
            }
            while (finished == false)
            {
              if (current.Value != before)

              {
                previous = current;
                current = current.Next;
              }
              else
              {
                newNode.Next = current;
                previous.Next = newNode;
                return;
              }
          }
        }
        public void InsertAfter(int after, int value)
        {
          Node newNode = new Node(value);
          bool finished = false;
          Node current = Head;

          while (finished == false)
            {
                if (current.Value == after)
                {
                  newNode.Next = current.Next;
                  current.Next = newNode;
                  finished = true;
                }
                else
                {
                  current = current.Next;
                }
            }
        }
        public int KFromLast(int k)
        {
            if (k<0)
            {
                throw new IndexOutOfRangeException("Value form last cannot be negative");
            }
            Node current = Head;
            int count = 0;
            while (current != null)
            {
              current = current.Next;
              count++;
            }
            if (k >= count)
            {
                throw new IndexOutOfRangeException("Value from last must be less that list length");
            }
            current = Head;
            for (int i=0; i<count-k; i++)
            {
                if (i+1 == count-k)
                {
                    return current.Value;  
                }
                else
                {
                    current = current.Next;
                }
            }
            return 0;
        }
    }
}
