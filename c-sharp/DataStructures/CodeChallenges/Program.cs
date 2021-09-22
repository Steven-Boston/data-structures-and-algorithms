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
      int[] nums1 = new int[] { 2,2,2,2};
      int[] nums2 = new int[] { 2,2,2 };
      Console.WriteLine(MedianOfTwoArrays.FindMedianSortedArrays(nums1, nums2));
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
      public static string CompressString(string input)
      {
        Dictionary<char, int> record = new();
        foreach(char letter in input)
        {
          if(!record.ContainsKey(letter))
          {
            record.Add(letter, 0);
          }
          record[letter]++;
        }
        string result = "";
        foreach(var pair in record)
        {
          result = result + pair.Key + pair.Value;
        }
        return result;
      }

      public static bool StackPals(DataStructures.Stack<char> input)
      {
        DataStructures.Stack<char> half = new();
        int count = 0;
        while(!input.IsEmpty())
        {
          half.Push(Char.ToLower(input.Pop()));
          count++;
        }
        int halfCount = count / 2;
        for(int i = 0; i<halfCount; i++)
        {
          input.Push(half.Pop());
        }
        if(count % 2 == 1)
        {
          half.Pop();
        }
        while((!input.IsEmpty())&&(!half.IsEmpty()))
        {
          char temp1 = input.Pop();
          char temp2 = half.Pop();
          if(temp1 != temp2)
          {
            return false;
          }
        }
        return true;
      }
      public static ChangeSummary MakeCoins(double price)
      {
        ChangeSummary change = new();
         int changeCount=100-(int)(price % 1.00 * 100);

      //get quarters
      if(changeCount>=25)
      {
        change.Quarters = changeCount / 25;
        changeCount = changeCount % 25;
      }
      if(changeCount>=10)
      {
        change.Dimes = changeCount / 10;
        changeCount = changeCount % 10;
      }
      if (changeCount>=5)
      {
        change.Nickels = changeCount / 5;
        changeCount = changeCount % 5;
      }
      if(changeCount>=1)
      {
        change.Pennies = changeCount / 1;
      }
        return change;
      }

      public static int LargestProduct(List<int> input)
      {
        if(input.Count>=2)
        {
          int largest = input[0]*input[1];
          for(int i = 0; i<input.Count; i++)
          {
            for(int j = 0; j<input.Count; j++)
            {
              if(input[j]*input[i]>largest && i != j)
              {
                largest = input[i] * input[j];
              }  
            }
          }
          return largest;
        }
        throw new Exception("List does not have at least two entries.");
      }
    }
    public class ChangeSummary
    {
      public int Quarters { get; set; }
      public int Dimes { get; set; }
      public int Nickels { get; set; }
      public int Pennies { get; set; }
      public ChangeSummary()
      {
        Quarters = 0;
        Dimes = 0;
        Nickels = 0;
        Pennies = 0;
      }
    }
}
