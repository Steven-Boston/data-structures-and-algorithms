using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class BreadthFirstClass
  {
    public static List<int> BreadthFirst(BinaryTree<int> tree)
    {
      DataStructures.Queue<Node<int>> nodeHopper = new();
      List<int> result = new();
      if (tree.Root != null)
      {
        nodeHopper.EnQueue(tree.Root);
      }
      while (!nodeHopper.IsEmpty())
      {
        Node<int> node = nodeHopper.DeQueue();
        result.Add(node.Value);
        if (node.Left != null)
        {
          nodeHopper.EnQueue(node.Left);
        }
        if (node.Right != null)
        {
          nodeHopper.EnQueue(node.Right);
        }
      }
      return result;
    }
  }
}
