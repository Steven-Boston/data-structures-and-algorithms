using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  class TreeIntersections
  {
    public int[] TreeIntersection(BinaryTree<int> treeOne, BinaryTree<int> treeTwo)
    {
      List<int> results = new();

      HashTable table = new(1024);

      if ((treeOne.Root != null) && (treeTwo.Root != null))
        {
          HashTree(treeOne.Root, table);
          TreeChecker(treeTwo.Root, table, results);
        }
      return results.ToArray();
    }
    public static void HashTree(Node<int> node, HashTable table)
    {
      if (node.Left != null) { HashTree(node.Left, table); }

      table.Add(node.Value.ToString(), node.Value.ToString());

      if (node.Right != null) { HashTree(node.Right, table); }
    }

    public static void TreeChecker(Node<int> node, HashTable table, List<int> list)
    {
      if (node.Left != null) { TreeChecker(node.Left, table, list); }
      if (table.Contains(node.Value.ToString()) && (!list.Contains(node.Value)))
        { 
          list.Add(node.Value);
        }
      if (node.Right != null) { TreeChecker(node.Right, table, list); }
    }
  }
}
