using System;

class Program {
    static void Main(string[] args) {
        // Prompt user to enter a word and read the input from the console
        Console.WriteLine ("Please Enter your Word");
        string input = Console.ReadLine ();

        // Pass the user input as inputString variable to the RemoveDuplicateChars function
        string inputString = input;

        // Call the RemoveDuplicateChars function and store the result in result variable
        string result = RemoveDuplicateChars(inputString);

        // Print the result on the console
        Console.WriteLine(result);
    }

    static string RemoveDuplicateChars(string input) {
        // Initialize an empty string result
        string result = "";

        // Loop through each character in the input string using a foreach loop
        foreach (char c in input) {
            // Check if the character already exists in the result string
            if (result.IndexOf(c) == -1) {
                // If the character is not found in the result string, append it to the result string
                result += c;
            }
        }
        // Return the result string without any duplicate characters
        return result;
    }
}