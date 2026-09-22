public class Solution {
    public int MaxProfit(int[] prices) {
        int bestDiff = 0;
        int maxVal = 0;
        int cur = 0;
        Stack<int> pricesS = new Stack<int>();
        foreach(int p in prices){
            pricesS.Push(p);
        }
        maxVal = pricesS.Pop();
        while(pricesS.Count() != 0){
            cur = pricesS.Pop();
            if(cur > maxVal){
                maxVal = cur;
            }else{
                int curDiff = maxVal - cur;
                bestDiff = Math.Max(bestDiff, curDiff);
            }
        }
        return bestDiff;
    }
}
