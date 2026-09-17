public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> AnagramGroups = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            string key = Sorted(s);
            if(!AnagramGroups.TryGetValue(key, out List<string> list)){
                List<string> l = [s];
                AnagramGroups[key] = l;
            }else{
                list.Add(s);
                AnagramGroups[key] = list;
            }
        }
        return AnagramGroups.Values.ToList();
    }

    private string Sorted(string s){
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
