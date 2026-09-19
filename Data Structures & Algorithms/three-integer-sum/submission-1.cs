public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int p2 = 0;
        int p3 = nums.Length - 1;
        List<List<int>> res = new List<List<int>>();
        for(int p1 = 0; p1 < nums.Length - 2; p1++){
            if (p1 > 0 && nums[p1] == nums[p1 - 1])continue;
            p2 = p1 + 1;
            p3 = nums.Length - 1;
            while(p2 < p3){
                int sum = nums[p1] + nums[p2] + nums[p3];
                if( sum == 0){
                    res.Add(new List<int>{nums[p1], nums[p2], nums[p3]});
                    p2++;
                    p3--;
                    while (p2 < p3 && nums[p2] == nums[p2 - 1]) p2++;
                    while (p2 < p3 && nums[p3] == nums[p3 + 1]) p3--;
                }else if(sum > 0){
                    p3--;
                }else{
                    p2++;
                }
            }
        }
        return res;
    }
}
