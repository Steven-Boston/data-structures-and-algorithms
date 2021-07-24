# Stacks and Queues

Author: Steven Boston

This challenge asked us to create classes that build Stack and Queue data structures with some supporting methods for basic functionality.

## Challenge

This challenge calls for two data structures:

- Stack: A class with a node value of Top that begins a Node chain. Nodes are only added to or removed form the chain via the top position.

- Queue: This class has both Front and Back node values, nodes are processed from the front and added to the back.

## Approach & Efficiency

None of the current methods available to these data structures require any data manipulation that would put them beyond O(1) in time or space. The methods available are quite boilerplate, with basic functionality simply add and removes nodes according to the nature of each structure.  

## API

At the time of writing, these are the methods available to `Stack<T>`:

- `Push(T Value)` creates a new node with the specified value atop the stack.
- `Pop()` Pops the top node from the stack and returns the value.
- `Peek()` Looks at the top Node of the stack and returns the value.
- `IsEmpty()` return a boolean based on whether there are any nodes in the stack.

and for `Queue<T>`:

- `EnQueue(T Value)` add a Node to the end of the Queue.
- `DeQueue()` remove the front Node and return its Value.
- `Peek()` returns the Value of the Front Node.
- `IsEmpty()` return a boolean based on whether there are any nodes in the Queue.
