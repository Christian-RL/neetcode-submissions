public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> charsCount = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            charsCount.TryGetValue(s[i], out int countS);
            charsCount[s[i]] = ++countS;
            charsCount.TryGetValue(t[i], out int countT);
            charsCount[t[i]] = --countT;
        }
        foreach(var entry in charsCount.Values){
            if(entry != 0) return false;
        }
        return true;
    }
}
