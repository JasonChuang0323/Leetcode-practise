
// Write a function that reverses a string. The input string is given as an array of characters char[].

// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

// You may assume all the characters consist of printable ascii characters.

 

// Example 1:

// Input: ["h","e","l","l","o"]
// Output: ["o","l","l","e","h"]
// Example 2:

// Input: ["H","a","n","n","a","h"]
// Output: ["h","a","n","n","a","H"]

// better
public class Solution {
    public void ReverseString(char[] s) {
        int l = 0;
        int r = s.Length - 1;
        while(l < r){
            char temp;
            temp = s[l];
            s[l] = s[r];
            s[r] = temp;
            l++;
            r--;
        }
        
    }
}

//esay but slower
public class Solution {
    public void ReverseString(char[] s) {
        Array.Reverse(s);
    }
}