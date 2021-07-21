using System;
using DataStructures;

namespace CodeChallenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList test1 = new();
            test1.Insert(1);
            test1.AppendLinked(3);
            test1.AppendLinked(5);
            test1.AppendLinked(7);
            test1.ListToString();

            LinkedList test2 = new();
            test2.Insert(2);
            test2.AppendLinked(4);
            test2.AppendLinked(6);
            //test2.AppendLinked(8);
            //test2.AppendLinked(10);
            test2.ListToString();

            LinkedList list3 = ZipLists(test1, test2);
            list3.ListToString();
        }
        public static LinkedList ZipLists(LinkedList listOne, LinkedList listTwo)
        {
            Node current1 = listOne.Head;
            Node current2 = listTwo.Head;
            if (current1 == null)
            { 
                listOne.Head = listTwo.Head;
            }
            while ((current1 != null)&&(current2 != null))
            {
                Node tempOne = current1.Next;
                Node tempTwo = current2.Next;

                current1.Next = current2;
                current2.Next = tempOne;

                current1 = tempOne;
                if(current1 == null)
                { 
                    current2.Next = tempTwo;
                }
                current2 = tempTwo;
            }
            return listOne;
        }
    }
}
