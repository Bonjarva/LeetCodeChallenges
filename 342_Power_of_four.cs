/*
Given an integer n, return true if it is a power of four. Otherwise, return false.

An integer n is a power of four, if there exists an integer x such that n == 4x.

 

Example 1:

Input: n = 16
Output: true
Example 2:

Input: n = 5
Output: false
Example 3:

Input: n = 1
Output: true
 

Constraints:

-231 <= n <= 231 - 1
*/

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        int i = 0;

        //Iterate through each of the powers of 4 until we find a match
        while (n != Math.Pow(4, i))
        {

            // if we overshoot our n value return false
            if (n < Math.Pow(4, i)) return false;
            i++;

        }
        // if we find a match return true;
        return true;
    }
}