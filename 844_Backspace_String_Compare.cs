/*
Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

Note that after backspacing an empty text, the text will continue empty.

 
Example 1:

Input: s = "ab#c", t = "ad#c"
Output: true
Explanation: Both s and t become "ac".
Example 2:

Input: s = "ab##", t = "c#d#"
Output: true
Explanation: Both s and t become "".
Example 3:

Input: s = "a#c", t = "b"
Output: false
Explanation: s becomes "c" while t becomes "b".
 

Constraints:

1 <= s.length, t.length <= 200
s and t only contain lowercase letters and '#' characters.
 

Follow up: Can you solve it in O(n) time and O(1) space?
*/

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        int i = 0;
        string tFinal = "";
        string sFinal = "";

        while (i < t.Length)
        {
            if (t[i].Equals('#'))
            {
                if (!String.IsNullOrEmpty(tFinal))
                {
                    tFinal = tFinal.Remove(tFinal.Length - 1, 1);
                }
            }
            else
            {
                tFinal += t[i];
            }

            i++;
        }

        i = 0;

        while (i < s.Length)
        {
            if (s[i].Equals('#'))
            {
                if (!String.IsNullOrEmpty(sFinal))
                {
                    sFinal = sFinal.Remove(sFinal.Length - 1, 1);
                }
            }
            else
            {
                sFinal += s[i];
            }

            i++;
        }






        return (sFinal == tFinal);
    }
}