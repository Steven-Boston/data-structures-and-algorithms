using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class FBTree
  {
    public static NaryTree<string> FizzBuzzTree(NaryTree<int> oldTree)
    {
      NaryTree<string> result = new();
      if(oldTree.Root != null)
      {
        result.Root = NodeBuzz(oldTree.Root);
        result.Root.Leaves = NodeMap(oldTree.Root.Leaves);
      }
      return result;
    }
    public static List<Node<string>> NodeMap(List<Node<int>> oldLeaves)
    {
      List<Node<string>> newLeaves = new();

      foreach(Node<int> leaf in oldLeaves)
      {
        Node<string> newLeaf = NodeBuzz(leaf);
        newLeaf.Leaves = NodeMap(leaf.Leaves);
        newLeaves.Add(newLeaf);
      }
      return newLeaves;
    }
    public static Node<string> NodeBuzz(Node<int> oldNode)
    {
      int value = oldNode.Value;
      Node<string> result = new("");
      if((value % 3 == 0) && (value % 5 == 0))
      {
        result.Value = "FizzBuzz";
      }
      else if(value % 3 == 0)
      {
        result.Value = "Fizz";
      }
      else if(value % 5 == 0)
      {
        result.Value = "Buzz";
      }
      else
      {
        result.Value = $"{oldNode.Value}";
      }
      return result;
    }
  }
}
