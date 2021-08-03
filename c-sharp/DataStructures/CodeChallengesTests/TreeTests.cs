using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructures;
using CodeChallenges;

namespace CodeChallengesTests
{
  public class TreeTests
  {
    [Fact]
    public void CanReturnOrderedList()
    {
      BinaryTree<int> pine = new();
      pine.Root = new(3);
      pine.Root.Left = new(5);
      pine.Root.Right = new(6);
      pine.Root.Right.Left = new(8);
      pine.Root.Right.Right = new(2);
      pine.Root.Right.Right.Right = new(1);
      List<int> result = new();
      result.Add(3);
      result.Add(5);
      result.Add(6);
      result.Add(8);
      result.Add(2);
      result.Add(1);

      List<int> comparator = BreadthFirst(pine);

      Assert.Equal(result, comparator);
    }
    [Fact]
    public void CanReturnEmpty()
    {
      BinaryTree<int> testTree = new();
      List<int> testResult = BreadthFirst(testTree);
      Assert.Empty(testResult);
    }
  }
}
