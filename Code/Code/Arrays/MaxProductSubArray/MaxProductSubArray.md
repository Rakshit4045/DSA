 # Maximum Product Subarray

## Problem Statement
Given an integer array `nums`, find a contiguous non-empty subarray within the array that has the largest product, and return the product.

## Approach
The solution uses dynamic programming to track both maximum and minimum products at each step. This is necessary because:
- A negative number can become positive when multiplied by another negative number
- The minimum product can become the maximum product when multiplied by a negative number

### Algorithm Steps:
1. Initialize maxProduct, minProduct, and result with the first element
2. For each element starting from index 1:
   - If the current number is negative, swap maxProduct and minProduct
   - Update maxProduct as max(current, maxProduct * current)
   - Update minProduct as min(current, minProduct * current)
   - Update result if maxProduct is greater

## Time Complexity
- O(n) where n is the length of the input array

## Space Complexity
- O(1) as we only use a constant amount of extra space

## Example
```
Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.

Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
```

## Implementation
The solution is implemented in `Program.cs` using C#.