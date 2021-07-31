# Trees

Author: Steven Boston

Designed in Collaboration With:

- Joshua Haddock
- Benjamin Ibarra

## Challenge

This data structure consists of a Binary Tree and an extension of it that forms a binary search tree. Both have access to several methods that assist in traversal, and the BST has two additional methods for populating as verifying the contents of the search tree. 

## Approach & Efficiency

Each Traversal method relies on recursion, which necessarily gives each limited efficiency:

- PreOrder: O(h)
- InOrder: O(n)
- PostOrder: O(w)

This lets the BST methods stay somewhat light, however:

- Add: O(h)
- Contains O(log n)

## API

This implementation add two data structures:

DataStructures.BinaryTree<T>

- Node<T> Root
- PreOrder(node<T>, list<T>) => List<T>
- InOrder(node<T>, List<T>) => List<T>
- PostOrder(node<T>, List<T>) => List<T>

DataStructures.BinarySearchTree<T> (extends BinaryTree)

- Add(T Value)
- Contains(T Value) => Boolean
