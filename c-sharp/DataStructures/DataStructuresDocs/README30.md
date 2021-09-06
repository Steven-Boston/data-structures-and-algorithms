# Challenge 30: Hashtables

Author: Steven Boston
Designed in collaboration with: Benjamin Ibarra

This challenge had us implement a HashTable class that stores Key: Value pairs by using a hashing algorithm to derive an array index from the key string. Each index has a linked list that can store multiple values. 

## Approach & Efficiency

Hashtables are not as efficient as other data structures when handling small sets of data, but a runtime of O(1+n/k) becomes quite stellar when larger datasets need to be searched.

## API

The HashTable class has the follwing members:

- `LinkedList<KeyValuePair<string, string>>[] Map`
- Get(string key) -> returns a string that summarizes the key and value of a given key.
- Add(string key, string value) -> adds a key value pair to the table
- Contains(string key) -> returns the presence of a key as a boolean


