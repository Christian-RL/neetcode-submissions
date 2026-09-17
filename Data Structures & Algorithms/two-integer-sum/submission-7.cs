public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numMap = new Dictionary<int, int>(nums.Length);
        for(int i = 0; i < nums.Length; i++){
            int complement = target - nums[i];
             if (numMap.TryGetValue(complement, out int complementIndex)){
                return new[] { complementIndex, i };
            }
            numMap[nums[i]] = i;
        }
        return new int[2];
    }
}
