/*Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

 

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
 

Constraints:

1 <= nums.length <= 105
-231 <= nums[i] <= 231 - 1
0 <= k <= 105
 

Follow up:

Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
Could you do it in-place with O(1) extra space?*/

public class Solution {
    public void Rotate(int[] nums, int k) {
        
        int n = nums.Length;

        // break k into a single shift location within the array instead of interating continueously to get to the final destination
        k = k % n;
    
        //if we are to move the array a full cycle or multiple of a full cycle the array wont move.
        if (k == 0) return;

        // Variable initialisation
        int prevValue = 0;        
        int currValue = 0;
        int index = 0;
        int cycleStartIndex = 0;
        int count = 0;


        while(count < n){

                // to avoid cycles we need to track when we get back to our starting index
                index = cycleStartIndex;
                prevValue = nums[index];

                //logic to move records
                do{
                    index = (index + k) % n;
                    currValue = nums[index];
                    nums[index] = prevValue;
                    prevValue = currValue;
                    count++;
                }while(index != cycleStartIndex);
                cycleStartIndex++;
        }

        return;
    }
}