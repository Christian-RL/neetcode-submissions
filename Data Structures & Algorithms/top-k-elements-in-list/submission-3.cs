public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new();
        foreach(int n in nums){
            frequency.TryGetValue(n, out int freq);
            frequency[n] = ++freq;
        }
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var pair in frequency){
            int number = pair.Key;
            int freq = pair.Value;
            if(buckets[freq] == null){
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(number);
        }
        List<int> result = new();
        for(int count = buckets.Length - 1; count >= 1; count--){
            if(buckets[count] == null) continue;
            foreach(int num in buckets[count]){
                result.Add(num);
                if(result.Count == k){
                    return result.ToArray();
                }
            }
        }
        return result.ToArray();
    }
}
