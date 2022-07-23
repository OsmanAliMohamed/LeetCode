class Solution {
public:
    bool isValid(string s) {
      stack<char> stk;
      for(auto x: s)
      {
          if(x=='(' || x=='{' || x=='[')
              stk.push(x);
          else
          {
               if(stk.empty()==true) return false;
               char c=stk.top();
               if(x==')' && c!='(') return false;
               if(x==']' && c!='[') return false;
               if(x=='}' && c!='{') return false;
               stk.pop();
          }
      }
        if(stk.empty()==false) return false;
        return true; 
    }
};