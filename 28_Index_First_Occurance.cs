public class Solution {
    public int StrStr(string haystack, string needle) {
        

        // find first occurence index of first letter of needle
        // compare substring to needle
        // if match return index
        //else continue onto next index of first letter of needle
        // continue loop until index is arrayLength - needleLength?
            //we know it cant be in the final letters as its too short

        int n = needle.Length;
        int h = haystack.Length;

        if(haystack.IndexOf(needle[0]) != -1 && n <= h){
            int index = haystack.IndexOf(needle[0]);

            while(index <= h - n && index != -1){
                if(haystack.Substring(index, n).Equals(needle)){
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