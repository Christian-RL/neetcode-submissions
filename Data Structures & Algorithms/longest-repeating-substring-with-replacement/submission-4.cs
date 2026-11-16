public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int p1 = 0;
        int longest = 0;

        for (int p2 = 0; p2 < s.Length; p2++) {
            freq[s[p2] - 'A']++;

            while (p2 - p1 + 1 - freq.Max() > k) {
                freq[s[p1] - 'A']--;
                p1++;
            }

            longest = Math.Max(longest, p2 - p1 + 1);
        }

        return longest;
    }
}
