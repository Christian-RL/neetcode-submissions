public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> complements = new Dictionary<int, int>();
        int complement = 0;
        for(int i = 0; i < nums.Length; i++){
            complement = target - nums[i];
            if(complements.TryGetValue(complement, out int value)) return new int[]{value, i};
            complements.Add(nums[i], i);
        }
        return new int[]{0, 0};
    }
}
