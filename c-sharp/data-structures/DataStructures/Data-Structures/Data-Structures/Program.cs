using System;
using DataStructures;
namespace DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList testList = new LinkedList();
      testList.Insert(9);
      testList.Insert(8);
      testList.Insert(7);
      testList.Insert(6);
      testList.Insert(5);
      testList.Insert(4);
      testList.Insert(3);

      testList.Includes(3);
      testList.Includes(10);
      testList.Includes(7);

      int kStuff = testList.KFromLast(4);
      Console.WriteLine($"4th from last is {kStuff}");

      testList.ListToString();
    }
  }
}
