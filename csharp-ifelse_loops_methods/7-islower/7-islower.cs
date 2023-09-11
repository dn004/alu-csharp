using System;
    class Character{
    static List<char> LCase = new List<char>();
    public static bool IsLower(char c){

        for(char i = 'a'; i <= 'z'; i++){
            LCase.Add(i);
        }

        if(LCase.Contains(c)){
            return true;
        }
        else{
            return false;
        }
    }
}