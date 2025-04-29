 # Count Inversions

## Problem Statement
Given an array of integers, count the number of inversions in the array. An inversion is a pair (i, j) where:
- 0 <= i < j < arr.length
- arr[i] > arr[j]

## Approach
The solution uses a modified merge sort algorithm to count inversions during the merge process. This approach is efficient because:
- It divides the problem into smaller subproblems
- Counts inversions while merging sorted subarrays
- Avoids redundant comparisons

### Algorithm Steps:
1. Divide the array into two halves
2. Recursively count inversions in both halves
3. Merge the sorted halves while counting cross-inversions
4. Return the total count

## Time Complexity
- O(n log n) where n is the length of the input array

## Space Complexity
- O(n) for the temporary array used in merge sort

## Example
```
Input: arr = [2, 4, 1, 3, 5]
Output: 3
Explanation: The inversions are:
- (2,1) --> 4 > 1
- (4,1) --> 4 > 1
- (4,3) --> 4 > 3
```

## Implementation
The solution is implemented in `Program.cs` using C#.