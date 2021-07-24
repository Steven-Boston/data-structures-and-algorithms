using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class CCUnitTests
  {
    [Fact]
    public void CanZip()
    {
      LinkedList<int> test1 = new();
      test1.Insert(1);
      test1.AppendLinked(3);
      test1.AppendLinked(5);
      test1.AppendLinked(7);

      LinkedList<int> test2 = new();
      test2.Insert(2);
      test2.AppendLinked(4);
      test2.AppendLinked(6);
      test2.AppendLinked(8);

      LinkedList<int> list3 = Program.ZipLists(test1, test2);

      Assert.Equal(7, list3.Head.Next.Next.Next.Next.Next.Next.Value);
    }
    [Fact]
    public void CanHandleVariedLengths()
    {
      LinkedList<int> test1 = new();
      test1.Insert(1);
      test1.AppendLinked(3);
      test1.AppendLinked(5);

      LinkedList<int> test2 = new();
      test2.Insert(2);
      test2.AppendLinked(4);
      test2.AppendLinked(6);
      test2.AppendLinked(8);
      test2.AppendLinked(10);

      LinkedList<int> list3 = Program.ZipLists(test1, test2);

      Assert.Equal(8, list3.Head.Next.Next.Next.Next.Next.Next.Value);
    }
    [Fact]
    public void CanHandleEmptyArray()
    {
      LinkedList<int> test1 = new();

      LinkedList<int> test2 = new();
      test2.Insert(2);
      test2.AppendLinked(4);
      test2.AppendLinked(6);
      test2.AppendLinked(8);
      test2.AppendLinked(10);

      LinkedList<int> list3 = Program.ZipLists(test1, test2);

      Assert.Equal(2, list3.Head.Value);
    }
  }
}
