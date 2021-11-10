using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using CodeChallenges;
using Xunit;

namespace CodeChallengesTests
{
  public class LinkedSumTests
  {
    [Fact]
    public void CanAddLists()
    {
      DataStructures.LinkedList<int> testList1 = new();
      DataStructures.LinkedList<int> testList2 = new();
      testList1.AppendLinked(1);
      testList1.AppendLinked(1);
      testList1.AppendLinked(1);
      testList2.AppendLinked(1);
      testList2.AppendLinked(1);
      testList2.AppendLinked(1);
      DataStructures.LinkedList<int> sum = SumLinkedLists.SumLists(testList1, testList2);
      Assert.Equal(2, sum.Head.Value);
      Assert.Equal(2, sum.Head.Next.Value);
      Assert.Equal(2, sum.Head.Next.Next.Value);
    }
    [Fact]
    public void CanCarry()
    {
      DataStructures.LinkedList<int> testList1 = new();
      DataStructures.LinkedList<int> testList2 = new();
      testList1.AppendLinked(5);
      testList1.AppendLinked(1);
      testList1.AppendLinked(6);
      testList2.AppendLinked(5);
      testList2.AppendLinked(1);
      testList2.AppendLinked(4);
      DataStructures.LinkedList<int> sum = SumLinkedLists.SumLists(testList1, testList2);
      Assert.Equal(0, sum.Head.Value);
      Assert.Equal(3, sum.Head.Next.Value);
      Assert.Equal(0, sum.Head.Next.Next.Value);
      Assert.Equal(1, sum.Head.Next.Next.Next.Value);
    }
  }
}
