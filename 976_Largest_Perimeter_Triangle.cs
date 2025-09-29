public class Solution {
    public int LargestPerimeter(int[] nums) {
        
        //Triangle Inequality Theorem. 
        //Shortcut is to sum the two smallest sides and needs to be larger than longest side.

        //if we want the largest perimeter then we need to start with the largest.
        //sort the array and work from back to front
        
        Array.Sort(nums);
        for(int i = nums.Length - 3 ; i >= 0 ; i--){
            if(nums[i+2] < nums[i+1] + nums[i]){
                return nums[i] + nums[i+1] + nums[i+2];
            }
        }
        return 0;
    }
}