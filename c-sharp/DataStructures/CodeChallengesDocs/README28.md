# Challenge Summary

Author: Steven Boston
Written in collaboration with: Charles Hubert Bofferding IV, Joel Connell

Challenge 28 concerns QuickSort, a strange sorting pattern that works by partitioning off sections of the array relative to a pivot position.

## Solution

This solution adds three methods to CodeChallenges in the file ArraySorts.cs:

- QuickSort(int[], int, int) -> takes and array, the leftmost index, and the rightmost index, and sorts the array.
- Partition(int[], int, int) -> partially sorts the array around the second integer at the midpoint, and returns its new position.
- Swap(int[], int, int) -> swaps the values at the given indexes in the array. 

## QuickSort Visualization

![C28Breakdown](C28Breakdown.png)
