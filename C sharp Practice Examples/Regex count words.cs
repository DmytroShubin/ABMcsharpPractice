using System;
using System.Text.RegularExpressions;

public class Example
{
   public static void Main()
   {
      string pattern = "Basant";
      string input = "This my name BAsaNT and basaNT is the good student and he studies well and BaSaNT might work hard to get into ivy leaugue.";
      int count=0;
      foreach (Match match in Regex.Matches(input, pattern,RegexOptions.IgnoreCase)){
      count++;
     }
         Console.WriteLine("In this Phrase the word"+" "+pattern+" "+"is mentioned"+" "+count+" "+"times");
   }
}