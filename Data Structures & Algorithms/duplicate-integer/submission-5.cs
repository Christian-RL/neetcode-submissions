public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums.Length);
        foreach(int num in nums){
            if(!numSet.Add(num)) return true;
        }
        return false;
    }
}