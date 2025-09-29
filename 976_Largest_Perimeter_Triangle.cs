public class Solution {
    public int LargestPerimeter(int[] nums) {
        
        //Triangle Inequality Theorem. 
        //Shortcut is to sum the two smallest sides and needs to be larger than longest side.

        //if we want the largest perimeter then we need to start with the largest.
        //sort the array and work from back to front
        
        Array.Sort(nums);

        int sideA = nums.Length - 3; //left most index
        int sideB = nums.Length - 2;
        int sideC = nums.Length - 1; //Largest index


        //continue until we find a combination that satisfies a triangle
        while(nums[sideC] >= nums[sideB] + nums[sideA]){

            //condition for reaching end of array then return 0
            if(sideC == 2){
                return 0;
            }

            sideC--;
            sideB--;
            sideA--;
        }


        //Return total perimeter
        return nums[sideA] + nums[sideB] + nums[sideC];
    }
}