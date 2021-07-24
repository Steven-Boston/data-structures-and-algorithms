using System;
using DataStructures;
namespace DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      /*LinkedList<int> testList = new LinkedList<int>();
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

      testList.ListToString();*/
      Queue<int> testQueue = new();
      testQueue.EnQueue(1);
      testQueue.EnQueue(2);
      testQueue.EnQueue(3);
      testQueue.EnQueue(4);
      testQueue.EnQueue(5);

      Node<int> current = testQueue.Front;
      while (current != null)
      {
        Console.WriteLine($"Next value: {current.Value}");
        current = current.Next;
      }
    }
  }
}
