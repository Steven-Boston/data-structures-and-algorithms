using System;
using DataStructures;
using System.Collections.Generic;
using CodeChallenges;

namespace CodeChallenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
      string test = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only";
          Console.WriteLine(RepeatedWords.RepeatedWord(test));
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
