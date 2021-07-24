using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public LinkedList()
        {  }
        public void Insert(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Head != null)
            {
                node.Next = Head;
            }
            Head = node;
            Console.WriteLine($"Added {node.Value}");
        }

        public bool Includes(int value)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if(value.Equals(current.Value))
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
            Node<T> current = Head;
            while (current != null)
            {
                output = output + $"{current.Value} -> ";
                current = current.Next;
            }
            output += "NULL";
            Console.WriteLine(output);
            return output;
        }
        public void AppendLinked(T value)
        {
            Node<T> newNode = new Node<T>(value);
            bool finished = false;
            if (Head == null)
            {
              Head = newNode;
              finished = true;
            }
            Node<T> current = Head;
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
        public void InsertBefore(T before, T value)
        {
            Node<T> newNode = new Node<T>(value);
            bool finished = false;
            Node<T> current = Head;
            Node<T> previous = null;
            if (!current.Value.Equals(before))
            {
              Insert(value);
              return;
            }
            while (finished == false)
            {
              if (current.Value.Equals(before))

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
        public void InsertAfter(T after, T value)
        {
          Node<T> newNode = new Node<T>(value);
          bool finished = false;
          Node<T> current = Head;

          while (finished == false)
            {
                if (current.Value.Equals(after))
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
        public T KFromLast(int k)
        {
            if (k<0)
            {
                throw new IndexOutOfRangeException("Value form last cannot be negative");
            }
            Node<T> current = Head;
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
            throw new IndexOutOfRangeException("No Values available");
        }
    }
}
