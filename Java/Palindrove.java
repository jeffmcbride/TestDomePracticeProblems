/*
A palindrome is a word that reads the same backward or forward.

Write a function that checks if a given word is a palindrome. Character case should be ignored.

For example, isPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
*/

public class Palindrome {
    public static boolean isPalindrome(String word) {
        // Base case
        if (word.length() <= 1){
            return true;
        }
        //Lower entire word
        word = word.toLowerCase();
        
        //Loop through word
        for (int i = 0; i < word.length()-1; i++){
            if (word.charAt(i) != word.charAt(word.length()-1-i)){
                return false;
                
            }
         
        }
        return true;
    }
    
    public static void main(String[] args) {
        System.out.println(Palindrome.isPalindrome("Deleveled"));
    }
}