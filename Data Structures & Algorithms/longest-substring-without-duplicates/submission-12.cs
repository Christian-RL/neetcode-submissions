public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int length = 0;
        int p1 = 0;
        int p2 = 0;
        var matches = new HashSet<char>();
        while(p2 < s.Length){
            while(!matches.Add(s[p2])){
                matches.Remove(s[p1]);
                p1++;
            }
            length = Math.Max(length, p2 - p1 + 1);
            p2++;
        }   
        return length;
    }
}
