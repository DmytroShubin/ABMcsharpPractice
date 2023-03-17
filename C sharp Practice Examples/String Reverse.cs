using System;

class ReverseString {
    static void Main() 
    {
         Console.WriteLine ("Please Enter your Word");
        //Getting word
        string input=Console.ReadLine ();
        string str = input;
        // Declare a string variable and assign it a value
        //string str = "hello world";
        
        // Convert the string to a character array
        char[] charArray = str.ToCharArray();
        
        // Reverse the character array in place
        Array.Reverse(charArray);
        
        // Create a new string from the reversed character array
        string reversedStr = new string(charArray);
        
        // Print the reversed string to the console
        Console.WriteLine(reversedStr);
    }
}