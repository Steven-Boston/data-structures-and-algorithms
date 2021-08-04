using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class FizzBuzzTreeTests
  {
    [Fact]
    public void CanKeepStructure()
    {
      NaryTree<int> testTree = new();
      Node<int> root = new(3);

      Node<int> c1 = new(5);
      Node<int> c2 = new(7);
      Node<int> c3 = new(9);
      root.Leaves.Add(c1);
      root.Leaves.Add(c2);
      root.Leaves.Add(c3);

      Node<int> g1 = new(13);
      Node<int> g2 = new(4);
      Node<int> g3 = new(12);
      c2.Leaves.Add(g1);
      c2.Leaves.Add(g2);
      c2.Leaves.Add(g3);

      testTree.Root = root;

      NaryTree<string> result = FBTree.FizzBuzzTree(testTree);

      Assert.Equal("4", result.Root.Leaves[1].Leaves[1].Value);
    }
    [Fact]
    public void CanFizzBuzz()
    {
      Node<int> node1 = new(45);
      Assert.Equal("FizzBuzz", FBTree.NodeBuzz(node1).Value);
      Node<int> node2 = new(27);
      Assert.Equal("Fizz", FBTree.NodeBuzz(node2).Value);
      Node<int> node3 = new(20);
      Assert.Equal("Buzz", FBTree.NodeBuzz(node3).Value);
      Node<int> node4 = new(7);
      Assert.Equal("7", FBTree.NodeBuzz(node4).Value);
    }
    [Fact]
    public void CanReturnEmpty()
    {
      NaryTree<int> testTree = new();
      NaryTree<string> result = FBTree.FizzBuzzTree(testTree);
      Assert.Null(result.Root);
    }
  }
}
