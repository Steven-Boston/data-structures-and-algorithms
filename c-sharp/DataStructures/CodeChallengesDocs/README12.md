# Challenge 12: Animal Shelter

Author: Steven Boston

Collaborators: 

- Ben Arno
- Benjamin Ibarra
- Joshua Haddock
- Joel Connell

This challenge asks for an Animal Shelter Class that manages both Cats and Dogs and allows for a potential adopter to specify which type of pet they would like to adopt.

## Whiteboard Process

![C12Whiteboard](C12Whiteboard.png)

## Approach & Efficiency

This AnimalShelter class manages cats and dogs separately via two Queues, which allows it to operate without any interating through either. This keeps big O time and space to a tidy O(1).

## Solution

This solution involves one primary class `AnimalShelter` which has the following methods:

- `EnQueue(Animal)`: add a cat or dog to the shelter. The method will handle sorting the new animal into the proper queue.
- `DeQueue(preference)`: give an argument of `"cat"` or `"dog"` and the Dequeue will give you back a pet to adopt!

There are a few classes that support these operations:

- `Animal`: Requires Name and Species attributes.
- `Cat`: sets Species to cat and adds .Meow()
- `Dog`: sets Species to dog and adds .Bark()
