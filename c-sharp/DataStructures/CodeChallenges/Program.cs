using System;
using DataStructures;
using System.Collections.Generic;

namespace CodeChallenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataStructures.LinkedList<int> test1 = new();
            test1.Insert(1);
            test1.AppendLinked(3);
            test1.AppendLinked(5);
            test1.AppendLinked(7);
            test1.ListToString();

            DataStructures.LinkedList<int> test2 = new();
            test2.Insert(2);
            test2.AppendLinked(4);
            test2.AppendLinked(6);
            test2.ListToString();

            DataStructures.LinkedList<int> list3 = ZipLists(test1, test2);
            list3.ListToString();
        }
        public static DataStructures.LinkedList<int> ZipLists(DataStructures.LinkedList<int> listOne, DataStructures.LinkedList<int> listTwo)
        {
            Node<int> current1 = listOne.Head;
            Node<int> current2 = listTwo.Head;
            if (current1 == null)
            { 
                listOne.Head = listTwo.Head;
            }
            while ((current1 != null)&&(current2 != null))
            {
                Node<int> tempOne = current1.Next;
                Node<int> tempTwo = current2.Next;  

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
