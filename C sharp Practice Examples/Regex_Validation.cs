using System;
using System.Text.RegularExpressions;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        functionValidationForPassword("Dmytro20@");
        
    }

    public static bool functionValidationForPassword(string Password){
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            
            if(!hasNumber.IsMatch(Password)){
            Console.WriteLine ("At least 1 number should be used");
            return false;
            }
            else if(!hasUpperChar.IsMatch(Password)){
            Console.WriteLine ("At least 1 Uppercase should be used");
            return false;
            }
            else if(!hasMiniMaxChars.IsMatch(Password)){
            Console.WriteLine ("Minimun 8 symbols should be used");
            return false;
            }
             else if(!hasLowerChar.IsMatch(Password)){
            Console.WriteLine ("At least 1 Lowercase should be used");
            return false;
            }
            else if(!hasSymbols.IsMatch(Password)){
            Console.WriteLine ("At least 1 Special symbol should be used");
            return false;
            }
            else{
            Console.WriteLine ("Good Work");
            return true;
            }
            
    }
}