using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
  {
    public void Add(Node<T> node, T value)
    {
      Node<T> newNode = new(value);
      if (Root == null)
      {
        Root = newNode;
        return;
      }
      if(newNode.Value.CompareTo(node.Value) < 0 )
      {
        if(node.Left == null) { node.Left = newNode; }
        else { Add(node.Left, value); }
      }
      else if( newNode.Value.CompareTo(node.Value) > 0 )
      {
        if (node.Right == null) { node.Right = newNode; }
        else { Add(node.Right, value); }
      }
    }
    public bool Contains(T Value)
    {
      Node<T> current = Root;
      while(true)
      {
        if (current.Value.Equals(Value))
        {
          return true;
        }
        else if(current.Value.CompareTo(Value) > 0 )
        {
          if (current.Left != null)
          {
            current = current.Left;
          }
          else
          {
            return false;
          }
        }
        else
        {
          if (current.Right != null)
          {
            current = current.Right;
          }
          else
          {
            return false;
          }
        }   
      }
    }

  }
}
