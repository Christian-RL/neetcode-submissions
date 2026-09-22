public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> present = new HashSet<int>();
        foreach(int num in nums){
            if(!present.Add(num)) return true;
        }
        return false;
    }
}