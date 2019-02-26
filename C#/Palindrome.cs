/*A palindrome is a word that reads the same backward or forward.

Write a function that checks if a given word is a palindrome. Character case should be ignored.

For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
*/

using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        if (word.Length <= 1){
            return true;
        }
        //Lower entire word
        word = word.ToLower();
        
        //Loop through word
        for (int i = 0; i < word.Length/2; i++){
            if (word[i] != word[word.Length-1-i]){
                return false;
                
            }
         
        }
        return true;
    
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}