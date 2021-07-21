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
      LinkedList test1 = new();
      test1.Insert(1);
      test1.AppendLinked(3);
      test1.AppendLinked(5);
      test1.AppendLinked(7);

      LinkedList test2 = new();
      test2.Insert(2);
      test2.AppendLinked(4);
      test2.AppendLinked(6);
      test2.AppendLinked(8);

      LinkedList list3 = Program.ZipLists(test1, test2);

      Assert.Equal(7, list3.Head.Next.Next.Next.Next.Next.Next.Value);
    }
    [Fact]
    public void CanHandleVariedLengths()
    {
      LinkedList test1 = new();
      test1.Insert(1);
      test1.AppendLinked(3);
      test1.AppendLinked(5);

      LinkedList test2 = new();
      test2.Insert(2);
      test2.AppendLinked(4);
      test2.AppendLinked(6);
      test2.AppendLinked(8);
      test2.AppendLinked(10);

      LinkedList list3 = Program.ZipLists(test1, test2);

      Assert.Equal(8, list3.Head.Next.Next.Next.Next.Next.Next.Value);
    }
    [Fact]
    public void CanHandleEmptyArray()
    {
      LinkedList test1 = new();

      LinkedList test2 = new();
      test2.Insert(2);
      test2.AppendLinked(4);
      test2.AppendLinked(6);
      test2.AppendLinked(8);
      test2.AppendLinked(10);

      LinkedList list3 = Program.ZipLists(test1, test2);

      Assert.Equal(2, list3.Head.Value);
    }
  }
}
