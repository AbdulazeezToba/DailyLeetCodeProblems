public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue, maxProfit = 0;
        foreach (int price in prices) {
            if (price < minPrice) minPrice = price;
            else maxProfit = Math.Max(maxProfit, price - minPrice);
        }
        return maxProfit;
    }
}
