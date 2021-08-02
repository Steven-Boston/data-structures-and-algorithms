using System;
using Xunit;
using DataStructures;
using System.Collections.Generic;

namespace DataStructuresTests
{
  public class TreeTests
  {
    //Can successfully instantiate an empty tree
    //Can successfully instantiate a tree with a single root node
    //Can successfully add a left child and right child to a single root node
    [Fact]
    public void CanPlantTrees()
    {
      BinaryTree<string> willow = new();
      Node<string> one = new("Root");
      Node<string> two = new("clorophyll");
      Node<string> three = new("bark");
      willow.Root = one;
      one.Left = two;
      one.Right = three;
      Assert.IsType<BinaryTree<string>>(willow);
      Assert.Equal("Root", willow.Root.Value);
      Assert.Equal("bark", willow.Root.Right.Value);
    }
    //Can successfully return a collection from a preorder traversal
    //Can successfully return a collection from an inorder traversal
    //Can successfully return a collection from a postorder traversal
    [Fact]
    public void CanListTrees()
    {
      BinarySearchTree<int> testTree = new();
      testTree.Add(testTree.Root, 4);
      testTree.Add(testTree.Root, 5);
      testTree.Add(testTree.Root, 3);
      testTree.Add(testTree.Root, 1);
      testTree.Add(testTree.Root, 6);
      testTree.Add(testTree.Root, 2);
      List<int> testOne = new();
      List<int> inOrder = BinaryTree<int>.InOrder(testTree.Root, testOne);
      List<int> testTwo = new();
      List<int> preOrder = BinaryTree<int>.Preorder(testTree.Root, testTwo);
      List<int> testThree = new();
      List<int> postOrder = BinaryTree<int>.PostOrder(testTree.Root, testThree);

      Assert.Equal(4, inOrder[3]);
      Assert.Equal(3, postOrder[0]);
      Assert.Equal(3, preOrder[1]);
    }
    [Fact]
    public void CanFindLargest()
    {
      BinaryTree<int> pine = new();
      pine.Root = new(3);
      pine.Root.Left = new(5);
      pine.Root.Right = new(6);
      pine.Root.Right.Left = new(8);
      pine.Root.Right.Right = new(2);
      pine.Root.Right.Right.Right = new(1);

      Assert.Equal(8, pine.TreeMax());

      pine.Root.Left.Right = new(6);

      Assert.Equal(8, pine.TreeMax());
    }
    [Fact]
    public void CanThrowEmptyMax()
    {
      BinaryTree<int> pine = new();
      Assert.Throws<Exception>(() => pine.TreeMax());
    }
  }
}
