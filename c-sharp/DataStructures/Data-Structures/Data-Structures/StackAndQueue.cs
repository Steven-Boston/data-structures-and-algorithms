using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Stack<T>
  {
    public Node<T> Top { get; set; }
    public void Push(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = Top;
      Top = node;
    }
    public T Pop()
    {
      if (IsEmpty())
      {
        throw new Exception("The stack is empty!");
      }
      Node<T> node = Top;
      Top = Top.Next;
      return node.Value;
    }
    public T Peek()
    {
      if (IsEmpty())
      {
        throw new Exception("The stack is empty!");
      }
      return Top.Value;
    }
    public bool IsEmpty()
    {
      return (Top == null);
    }
  }
  public class Queue<T>
  {
    public Node<T> Front { get; set; }
    public Node<T> Back { get; set; }

    public void EnQueue(T Value)
    {
      Node<T> node = new(Value);
      if (Front == null)
      {
        Front = node;
      }
      else
      {
        Back.Next = node;
      }
      Back = node;
    }
    public T DeQueue()
    {
      if (IsEmpty())
      {
        throw new Exception("The queue is empty!");
      }
      Node<T> node = Front;
      Front = node.Next;
      return node.Value;
    }
    public T Peek()
    {
      if (IsEmpty())
      {
        throw new Exception("The queue is empty!");
      }
      return Front.Value;
    }
    public bool IsEmpty()
    {
      return (Front == null);
    }
  }

}
