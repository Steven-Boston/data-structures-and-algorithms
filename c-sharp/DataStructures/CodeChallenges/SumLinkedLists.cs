using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
namespace CodeChallenges
{
  public class SumLinkedLists
  {
    public static DataStructures.LinkedList<int> SumLists(DataStructures.LinkedList<int> listA, DataStructures.LinkedList<int> listB)
    {
      DataStructures.LinkedList<int> result = new();
      int add = 0;
      Node<int> current1 = listA.Head;
      Node<int> current2 = listB.Head;

      while(current1 != null && current2 != null)
      {
        int sum = current1.Value + current2.Value + add;
        current1 = current1.Next;
        current2 = current2.Next;
        if(sum-10>=0)
        {
          add = 1;
          result.AppendLinked(sum - 10);
        }
        else
        {
          add = 0;
          result.AppendLinked(sum);
        }
      }
      while(current1 != null)
      {
        result.AppendLinked(current1.Value+add);
        add = 0;
        current1 = current1.Next;
      }
      while (current2 != null)
      {
        result.AppendLinked(current2.Value + add);
        add = 0;
        current2 = current2.Next;
      }
      if(add == 1)
      {
        result.AppendLinked(1);
      }
      return result;
    }
  }
}
