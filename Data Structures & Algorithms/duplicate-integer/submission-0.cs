public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        foreach(int i in nums){
            if(numbers.TryAdd(i, i) == false){
                return true;
            }
        }
        return false;
    }
}