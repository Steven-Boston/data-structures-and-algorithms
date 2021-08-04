# Challenge Summary

Author: Steven Boston
Written in collaboration with: Benjamin Ibarra

This challenge asks for a method that accepts a k-ary tree and returns a new k-ary tree wherein all of the node values have been replaced with their fizzbuzz equivalents. 

## Whiteboard Process

![C18WhiteBoard](C18WhiteBoard.png)

## Approach & Efficiency

We built this method by attaching each node to the list of its parent after conversion, using recursion to accomplish this all the way down the tree. This method involves a loop of each set of leaves, meaning that the runtime is O(n). The space requirements involve recursive calls on the leaves, meaning that space is O(w).

## Solution

This solution is comprised of three methods

- FizzBuzzTree(naryTree<int>) => returns a new naryTree<string> where each value is replaced with "Fizz", "Buzz", "FizzBuzz", or the original int converted to a string.

FizzBuzzTree has two supporting methods:

- NodeMap(List<Node<int>>) => returns a new List<Node<string>> where all the nodes are converted to FizzBuzz nodes.

- NodeBuzz(Node<int>) => returns a new Node<string> converted to FizzBuzz
