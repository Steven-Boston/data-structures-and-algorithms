using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class DuctTapeQueue<T>
  {
    public DataStructures.Stack<T> StackIn { get; set; } = new();
    public void EnQueue(T Value)
    {
      StackIn.Push(Value);
    }
    public T DeQueue()
    {
      DataStructures.Stack<T> StackOut = new();
      if (StackIn.IsEmpty())
      {
        throw new Exception("The Queue has nothing to process");
      }
      while (!StackIn.IsEmpty())
      {
        StackOut.Push(StackIn.Pop());
      }
      T Popped = StackOut.Pop();
      while (!StackOut.IsEmpty())
      {
        StackIn.Push(StackOut.Pop());
      }
      return Popped;
    }


    
  }
}
