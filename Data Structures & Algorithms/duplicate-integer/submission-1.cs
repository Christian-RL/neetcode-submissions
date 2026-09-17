public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> setNums = new HashSet<int>(nums);
        return nums.Length != setNums.Count;
    }
}