public class Solution {
    public bool IsPalindrome(string s) {
        int pointer1 = 0;
        int pointer2 = s.Count() - 1;
        while(pointer1 < pointer2){
            while(pointer1 < pointer2 && !inRange(s[pointer1])) pointer1++;
            while(pointer1 < pointer2 && !inRange(s[pointer2])) pointer2--;
            if(char.ToLowerInvariant(s[pointer1]) != char.ToLowerInvariant(s[pointer2])) return false;
            pointer1++;
            pointer2--;
        }
        return true;
    }
    private bool inRange(char c){
        if((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || ( c >= '0' && c <= '9')) return true;
        return false;
    }
}
