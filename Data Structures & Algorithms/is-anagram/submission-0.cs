public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            charCount.TryGetValue(s[i], out int count1);
            charCount[s[i]] = ++count1;
            charCount.TryGetValue(t[i], out int count2);
            charCount[t[i]] = --count2;
        }
        foreach(var (key, value) in charCount){
            if(value != 0) return false;
        }
        return true;
    }
}
