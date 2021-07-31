using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class BinaryTree<T>
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
  }
}
