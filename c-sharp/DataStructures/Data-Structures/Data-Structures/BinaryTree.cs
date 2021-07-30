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

    public void Preorder(Node<T> Root)
    {
      Console.WriteLine($"Value: {Root.Value}");
      if (Root.Left != null)
      {
        Preorder(Root.Left);
      }
      if (Root.Right != null)
      {
        Preorder(Root.Right);
      }
    }
    public void 
  }
}
