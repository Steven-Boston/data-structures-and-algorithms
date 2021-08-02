using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class BinaryTree<T> where T : IComparable
  {
    public Node<T> Root { get; set; }

    public static List<T> Preorder(Node<T> node, List<T> values)
    {
      values.Add(node.Value);

      if (node.Left != null)
      {
        Preorder(node.Left, values);
      }
      if (node.Right != null)
      {
        Preorder(node.Right, values);
      }
      return values;
    }
    public static List<T> InOrder(Node<T> node, List<T> values)
    {
      if(node.Left != null) { InOrder(node.Left, values); }

      values.Add(node.Value);

      if(node.Right != null) { InOrder(node.Right, values); }

      return values;
    }
    public static List<T> PostOrder(Node<T> node, List<T> values)
    {
      if (node.Left != null)
      {
        Preorder(node.Left, values);
      }
      if (node.Right != null)
      {
        Preorder(node.Right, values);
      }
      values.Add(node.Value);
      return values;
    }
    public T TreeMax()
    {
      Queue<Node<T>> nodeHopper = new();
      if (Root == null)
      {
        throw new Exception("Sorry, this tree is empty.");
      }
      nodeHopper.EnQueue(Root);
      T largest = Root.Value;
      while (!nodeHopper.IsEmpty())
      {
        Node<T> treeNode = nodeHopper.DeQueue();
        if (treeNode.Value.CompareTo(largest) > 0)
        {
          largest = treeNode.Value;
        }
        if (treeNode.Left != null)
        {
          nodeHopper.EnQueue(treeNode.Left);
        }
        if (treeNode.Right != null)
        {
          nodeHopper.EnQueue(treeNode.Right);
        }
      }
      return largest;
    }
  }
}
