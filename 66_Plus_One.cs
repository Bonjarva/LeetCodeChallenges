public class Solution {
    public int[] PlusOne(int[] digits) {
        
        //for just single digit change
        //get final index of array, add one to the number and return array

        //but issues when hitting 9+1 = 10
        // and 99+1 = 100

        int digit = 0;
        //interate through the digits back to front

        for(int i = digits.Length - 1 ; i >= 0 ; i--){
            digit = (digits[i] + 1) % 10;
            digits[i] = digit;

            if(digit != 0){
                break;

            } else if (i == 0){
                
                //Need new case for adding one more digit - [9] +1 = [1], [0]
                // create new array with 1 and append old array?
                int[] newArray = new int[digits.Length + 1];
                newArray[0] = 1;
                return newArray;
            }
        }
        return digits;
    }
}