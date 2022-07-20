public class Solution {
    public string DefangIPaddr(string address) {
        string res = "";
        for(int i = 0;i<address.Length;i++)
        {
            if (address[i] != '.') res += address[i];
            else res += "[.]";
        }
        return res;
    }
}