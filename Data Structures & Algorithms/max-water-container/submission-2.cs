public class Solution {
    public int MaxArea(int[] heights) {
        int pointer1 = 0;
        int pointer2 = heights.Length - 1;
        int max = 0;
        int vol = 0;
        while(pointer1 < pointer2){
            vol = Math.Min(heights[pointer1], heights[pointer2]) * (pointer2 - pointer1);
            if(heights[pointer1] > heights[pointer2]){
                if(max < vol) max = vol;
                pointer2--;
            }else{
                if(max < vol) max = vol;
                pointer1++;
            }
        }
        return max;
    }
}
