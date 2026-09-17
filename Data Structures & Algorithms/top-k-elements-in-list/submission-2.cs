public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new();
        foreach(int n in nums){
            frequency.TryGetValue(n, out int freq);
            frequency[n] = ++freq;
        }
        return frequency
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();
    }
}
