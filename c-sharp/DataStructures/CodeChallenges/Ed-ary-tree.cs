using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class Ed_ary_tree<T>
  {
    public EdNode<T> Root { get; set; }
    public static List<T> EdTraversal(EdNode<T> root)
    {
      List<T> result = new();
      DataStructures.Stack<T> pile = new();
      EdNode<T> previous;
      EdNode<T> current;
      


      return result;
    }
  }

  public class EdNode<T>
  {
    public T Value { get; set; }
    public List<EdNode<T>> ChildList { get; set; }
    public EdNode(T value)
    {
      Value = value;
      ChildList = new();
    }
  }
}
