using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class DuctTapeTests
  {
    [Fact]
    public void CanEnQueue()
    {
      DuctTapeQueue<int> testTape = new();
      testTape.EnQueue(1);
      testTape.EnQueue(2);

      Assert.Equal(1, testTape.StackIn.Top.Next.Value);
    }
    [Fact]
    public void CanDeQueue()
    {
      DuctTapeQueue<int> testTape = new();
      testTape.EnQueue(1);
      testTape.EnQueue(2);
      testTape.EnQueue(3);
      testTape.EnQueue(4);
      testTape.EnQueue(5);

      testTape.DeQueue();

      Assert.Equal(5, testTape.StackIn.Top.Value);
      Assert.Equal(2, testTape.StackIn.Top.Next.Next.Next.Value);
    }
    [Fact]
    public void CanThrowOnEmptyDeQueue()
    {
      DuctTapeQueue<int> testTape = new();
      Assert.Throws<Exception>(() => testTape.DeQueue());
    }
  }
}
