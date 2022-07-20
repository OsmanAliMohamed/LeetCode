public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] a1 = s.ToCharArray();
        char[] a2 = t.ToCharArray();
        if(a2.Length > a1.Length || a2.Length < a1.Length)
            return false;
        Array.Sort(a1);
        Array.Sort(a2);
        for(int i = 0; i < Math.Min(a1.Length,a2.Length); i++)
        {
            if (a1[i] != a2[i])
                return false;
        }
        return true;
    }
}