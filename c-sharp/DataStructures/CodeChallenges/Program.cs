using System;
using DataStructures;
using System.Collections.Generic;

namespace CodeChallenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DuctTapeQueue<int> testTape = new();
            testTape.EnQueue(4);

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
