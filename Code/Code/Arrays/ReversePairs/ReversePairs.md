 # Count Reverse Pairs

## Problem Statement
Given an integer array `nums`, return the number of reverse pairs in the array. A reverse pair is a pair (i, j) where:
- 0 <= i < j < nums.length
- nums[i] > 2 * nums[j]

## Approach
The solution uses a modified merge sort algorithm to count reverse pairs during the merge process. This approach is efficient because:
- It divides the problem into smaller subproblems
- Counts reverse pairs while merging sorted subarrays
- Avoids redundant comparisons

### Algorithm Steps:
1. Divide the array into two halves
2. Recursively count reverse pairs in both halves
3. Merge the sorted halves while counting cross-pairs
4. Return the total count

## Time Complexity
- O(n log n) where n is the length of the input array

## Space Complexity
- O(n) for the temporary array used in merge sort

## Example
```
Input: nums = [1,3,2,3,1]
Output: 2
Explanation: The reverse pairs are:
- (1,4) --> nums[1]=3 > 2*nums[4]=2
- (3,4) --> nums[3]=3 > 2*nums[4]=2
```

## Implementation
The solution is implemented in `Program.cs` using C#.