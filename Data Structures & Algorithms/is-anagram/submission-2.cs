public class Solution {
    public bool IsAnagram(string s, string t) {
        List<char> sList = new List<char>(s);
        List<char> tList = new List<char>(t);
        sList.Sort();
        tList.Sort();
        return sList.SequenceEqual(tList);
    }
}
