using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class DSUnitTests
  {
    [Fact]
    public void CanCreateList()
    {
      LinkedList testList = new LinkedList();
      Assert.NotNull(testList);
    }
    [Fact]
    public void CanInsertAndLink()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(6);
      testList.Insert(3);
      Assert.Equal(3, testList.Head.Value);
      Assert.Equal(6, testList.Head.Next.Value);
    }
    [Fact]
    public void CanInsertMultipleAndfind()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(6);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);
      testList.Insert(11);
      Assert.Equal(4, testList.Head.Next.Next.Value);
      Assert.True(testList.Includes(4));
      Assert.False(testList.Includes(23));
    }
    [Fact]
    public void CanReturnSummary()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(6);
      testList.Insert(3);
      testList.Insert(4);
      Assert.Equal("4 -> 3 -> 6 -> NULL", testList.ListToString());
    }
    [Fact]
    public void CanAppend()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(6);
      testList.Insert(4);
      testList.Insert(2);

      testList.AppendLinked(8);
      testList.AppendLinked(10);
      testList.AppendLinked(35);

      Assert.Equal(8, testList.Head.Next.Next.Next.Value);
    }
    [Fact]
    public void CanInsertBefore()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(10);
      testList.Insert(8);
      testList.Insert(6);
      testList.Insert(4);
      testList.Insert(2);

      testList.InsertBefore(8, 7);
      testList.InsertBefore(2, 1);

      Assert.Equal(1, testList.Head.Value);
      Assert.Equal(7, testList.Head.Next.Next.Next.Next.Value);
    }
    [Fact]
    public void CanInsertAfter()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(10);
      testList.Insert(8);
      testList.Insert(6);
      testList.Insert(4);
      testList.Insert(2);

      testList.InsertAfter(6, 7);
      testList.InsertAfter(10, 11);
      Assert.Equal(7, testList.Head.Next.Next.Next.Value);
      Assert.Equal(11, testList.Head.Next.Next.Next.Next.Next.Next.Value);
    }
  }
}
