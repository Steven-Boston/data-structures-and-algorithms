# Challenge 35: Graphs

Author: Steven Boston
Sample Code provided by: Ed Younskevicius

This challenge asks us to implement a graph data structure with several methods. 

## Challenge

The graph more or less functions as a tree with some special bells and whistles to give it more versatile connections in order to represent a wider variety of data. This graph in particular represents that data via adjacencylists rather than a matrix, and handles its edges accordingly.

## Approach & Efficiency

Similar to trees, graph traversals are reasonably efficient given how much data can be stored within them in different ways, generally keeping to O(n). Depending on the tree and the objective this can often be beaten. 

## API

This challenge implements the Graph<T> class in DataStructures, with the follwing members:

- AddNode(T) -> returns newly added node. 
- AddEdge(Node<T>, Node<T>) -> adds and edge to two nodes that are already in the graph. 
- GetNodes() -> returns all the nodes in the graph as a list.
- GetNeighbors(Node<T>) -> returns a list of all the edges of the node.
- Size() -> returns the number of nodes in the graph.

It also supports the Graph with the new Vertex and Edge classes, and an additonal print() method that gives a text representation of the graph in the console. 
