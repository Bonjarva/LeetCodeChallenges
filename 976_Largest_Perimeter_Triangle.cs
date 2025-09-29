public class Solution {
    public int LargestPerimeter(int[] nums) {
        
        //Triangle Inequality Theorem. 
        //Shortcut is to sum the two smallest sides and needs to be larger than longest side.

        //if we want the largest perimeter then we need to start with the largest.
        //sort the array and work from back to front
        
        Array.Sort(nums);
        int index = nums.Length - 3;

        //continue until we find a combination that satisfies a triangle
        while(nums[index+2] >= nums[index+1] + nums[index]){

            //condition for reaching end of array then return 0
            if(index == 0){
                return 0;
            }

            index--;

        }


        //Return total perimeter
        return nums[index] + nums[index+1] + nums[index+2];
    }
}