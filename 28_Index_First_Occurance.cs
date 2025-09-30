public class Solution {
    public int StrStr(string haystack, string needle) {
        

        // find first occurence index of first letter of needle
        // compare substring to needle
        // if match return index
        //else continue onto next index of first letter of needle
        // continue loop until index is arrayLength - needleLength?
            //we know it cant be in the final letters as its too short

        if(haystack.IndexOf(needle[0]) != -1 && needle.Length <= haystack.Length){
            int index = haystack.IndexOf(needle[0]);

            while(index <= haystack.Length - needle.Length && index != -1){
                if(haystack.Substring(index, needle.Length).Equals(needle)){
                    //Match substring
                    return index;
                } else{
                    //find next occurence or will set to -1
                    index = haystack.IndexOf(needle[0], index+1);
                }

            }

        }

        //if not found return -1
        return -1;
    }
}