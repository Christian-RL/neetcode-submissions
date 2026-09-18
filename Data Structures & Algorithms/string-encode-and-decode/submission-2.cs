public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder bld = new StringBuilder();
        foreach(string s in strs){
            int length = s.Length;
            bld.Append(length + "#" + s);
        }
        return bld.ToString();
    }

    public List<string> Decode(string s) {
        List<string> results = new();
        char[] chars = s.ToCharArray();
        int i = 0;
        while(i < chars.Count()){
            StringBuilder bld = new StringBuilder();
            StringBuilder length = new StringBuilder();
            while(chars[i] != '#'){
                length.Append(chars[i]);
                i++;
            }
            string count = length.ToString();
            int num = int.Parse(count);
            i++;
            for(int c = 0; c < num; c++){
                bld.Append(chars[i]);
                i++;
            }
            String res = bld.ToString();
            results.Add(res);
        }
        return results;
   }
}
