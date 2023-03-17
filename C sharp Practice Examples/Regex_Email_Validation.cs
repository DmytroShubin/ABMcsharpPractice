using System;
using System.Text.RegularExpressions;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        functionValidationForPassword("@gmail.com");
        functionValidationForPassword("Dmytro20@gmail.com");
        functionValidationForPassword("Dmytro20@");
        
    }

    public static bool functionValidationForPassword(string Password){
           
            var hasEmail = new Regex( @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
            
            if(!hasEmail.IsMatch(Password)){
            Console.WriteLine ("Email is not valid");
            return false;
            }
            
            else{
            Console.WriteLine ("Email is valid");
            return true;
            }
            
    }
}