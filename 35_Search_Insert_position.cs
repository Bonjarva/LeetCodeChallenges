/*

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104

*/

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {

        //array is sorted
        //iterate through nums until we find the exact value or the number is higher than the target.
        //return the index as thats either the index of where it is or where the number should be put.
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
            {
                return i;
            }

        }

        return nums.Length;
    }
}