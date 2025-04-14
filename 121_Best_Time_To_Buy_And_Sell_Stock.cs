public class Solution {
    public int MaxProfit(int[] prices) {
        
        // Stored variable for max price 
        int profit = 0;
        int lowestPrice = prices[0];

        for (int i = 1; i < prices.Length; i++){
            // check if this is the lowest price we've seen
            if (prices[i] < lowestPrice){
                lowestPrice = prices[i];
                continue;
            }

            // check for potential profit of current index to lowest price
            if (prices[i]-lowestPrice > profit){
                profit = prices[i]-lowestPrice;
            }
        }

        return profit;
    }
}