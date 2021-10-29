using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  class SwapLinkedPairs<T>
  {
    public static Node<T> SwapPairs(Node<T> head)

    {
      if (head == null)
      {
        return head;
      }
      Node<T> current = head;
      if (current.Next != null)
      {
        head = current.Next;
      }
      Node<T> third;
      Node<T> previous = null;
      while (current.Next.Next != null)
      {
        if (previous != null)
        {
          previous.Next = current.Next;
        }
        third = current.Next.Next;
        current.Next.Next = current;
        current.Next = third;
        previous = current;
        current = third;
      }
      if (current.Next != null)
      {
        if (previous != null)
        {
          previous.Next = current.Next;
        }
        current.Next.Next = current;
      }
      return head;
    }
  }
}
