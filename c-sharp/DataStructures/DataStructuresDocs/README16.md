# Challenge Summary

The challenge was to add a method to the Binary Tree class that determines and returns the highest value in the tree. 

## Whiteboard Process

![C16 WhiteBoard](C16Whiteboard.png)

## Approach & Efficiency

The challenge asked for not arguments to the method call, so we employed level order traversal in our solution to compare each node's value. After checking all the nodes, the largest value found is returned. 

## Solution

This solution adds a single method to the BinaryTree class:

- BinaryTree<int>.TreeMax() => returns the highest number found within the tree.
