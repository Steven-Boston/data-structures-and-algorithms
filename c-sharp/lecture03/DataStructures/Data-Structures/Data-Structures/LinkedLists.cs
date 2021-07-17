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
    }
}
