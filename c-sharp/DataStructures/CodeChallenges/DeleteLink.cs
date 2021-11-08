using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class DeleteLink
  {
    public static void DeleteNode(Node<int> node)
    {
      node.Value = node.Next.Value;
      node.Next = node.Next.Next;
    }
  }
}
