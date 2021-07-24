using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class StackAndQueueTests
  {
    [Fact]
    public void CanPushStacks()
    {
      Stack<string> testStack = new();
      testStack.Push("Ragavan, Nimble Pilferer");
      testStack.Push("Mental Misstep");
      testStack.Push("Reiterate");
      testStack.Push("Remand");
      //Can Push
      Assert.Equal("Remand", testStack.Top.Value);
      //Can Push Multiple
      Assert.Equal("Mental Misstep", testStack.Top.Next.Next.Value);
    }
    [Fact]
    public void CanPopStacks()
    {
      Stack<string> testStack = new();
      testStack.Push("Ragavan, Nimble Pilferer");
      testStack.Push("Mental Misstep");
      testStack.Push("Reiterate");
      testStack.Push("Remand");
      //This Stack is popping off
      while (testStack.Top != null)
      {
        testStack.Pop();
      }
      //Now it is empty
      Assert.True(testStack.IsEmpty());
      //Which means no more popping (and ragavan is probably countered)
      Assert.Throws<Exception>(() => testStack.Pop());
    }
    [Fact]
    public void CanPeekAtStack()
    {
      Stack<string> testStack = new();
      //Can make empty stack
      Assert.True(testStack.IsEmpty());
      //Peek at empty throws
      Assert.Throws<Exception>(()=>testStack.Peek());
      testStack.Push("Ragavan, Nimble Pilferer");
      testStack.Push("Mental Misstep");
      testStack.Push("Reiterate");
      testStack.Push("Remand");
      //Can peek at Next
      Assert.Equal("Remand", testStack.Peek());
     
    }
    [Fact]
    public void CanEnQueue()
    {
      Queue<int> testQueue = new();
      testQueue.EnQueue(1);
      testQueue.EnQueue(2);
      testQueue.EnQueue(3);
      testQueue.EnQueue(4);
      testQueue.EnQueue(5);
      //Can EnQueue:
      Assert.Equal(1, testQueue.Front.Value);
      //Can EnQueueueueue
      Assert.Equal(2, testQueue.Front.Next.Value);
      //Can Peek
      Assert.Equal(1, testQueue.Peek());
    }
    [Fact]
    public void CanMakeBlizzard()
    {
      Queue<int> testQueue = new();
      testQueue.EnQueue(1);
      //Can DeQueue correctly
      Assert.Equal(1, testQueue.DeQueue());
      testQueue.EnQueue(2);
      testQueue.EnQueue(3);
      testQueue.EnQueue(4);
      testQueue.EnQueue(5);
      //Can DeQueue 'em all
      while (testQueue.Front != null)
      {
        testQueue.DeQueue();
      }
      Assert.True(testQueue.IsEmpty());
      testQueue.EnQueue(1);

    }
    [Fact]
    public void CanMakeBlankQueue()
    {
      Queue<int> testQueue = new();
      //Can make empty list
      Assert.True(testQueue.IsEmpty());
      Assert.Throws<Exception>(()=>testQueue.DeQueue());
    }
  }
}
