public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = new HashSet<int>(nums);
        int longest = 0;
        foreach(int num in numbers){
            if(!numbers.Contains(num - 1)){
                int current = num;
                int length = 1;
                while(numbers.Contains(current + 1)){
                    current++;
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
