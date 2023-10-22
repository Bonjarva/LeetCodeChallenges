/*
You are given a 2D integer array logs where each logs[i] = [birthi, deathi] indicates the birth and death years of the ith person.

The population of some year x is the number of people alive during that year. The ith person is counted in year x's population if x is in the inclusive range [birthi, deathi - 1]. Note that the person is not counted in the year that they die.

Return the earliest year with the maximum population.

 

Example 1:

Input: logs = [[1993,1999],[2000,2010]]
Output: 1993
Explanation: The maximum population is 1, and 1993 is the earliest year with this population.
Example 2:

Input: logs = [[1950,1961],[1960,1971],[1970,1981]]
Output: 1960
Explanation: 
The maximum population is 2, and it had happened in years 1960 and 1970.
The earlier year between them is 1960.
 

Constraints:

1 <= logs.length <= 100
1950 <= birth i < death i <= 2050

*/

public class Solution
{
    public int MaximumPopulation(int[][] logs)
    {

        //Create an array for each of the 100 years for the population constraints.
        int[] yearsPopulation = new int[100];

        //iterate through each of the logs
        foreach (int[] person in logs)
        {
            int born = person[0];
            int death = person[1];
            //  add 1 to each of the array positions for each year they were alive
            for (int i = born; i < death; i++)
            {
                yearsPopulation[i - 1950]++;
            }
        }

        //Initialise the variables to store the max year and value
        int highestPopulation = 0;
        int highestPopYear = 1950;

        //Iterate through the population array to find the max year
        for (int j = 0; j < yearsPopulation.Length; j++)
        {

            //keep track of the largest year and only update the year if we find a larger month
            if (yearsPopulation[j] > highestPopulation)
            {
                highestPopulation = yearsPopulation[j];
                //the position + 1950 will equal the year specified
                highestPopYear = 1950 + j;
            }
        }

        //return the largest year we found
        return highestPopYear;
    }
}


