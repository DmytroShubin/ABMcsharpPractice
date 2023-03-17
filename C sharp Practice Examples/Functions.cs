using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
       string Name = "Dmytro";
       int Age = 40;
       double Weight = 83.5;
       char FirstLetter ='D';
       bool CityCalgary = true;
       
       Console.WriteLine ("String"+" "+ fncName(Name));
       Console.WriteLine ("int"+" "+ fncAge(Age));
       Console.WriteLine ("double"+" "+ fncWeight( Weight));
       Console.WriteLine ("char"+" "+ fncFirstLetter(FirstLetter));
       Console.WriteLine ("bool"+" "+ fncCityCalgary(CityCalgary));
    }
    public static string fncName(string Name){
        return Name;
    }
    public static int fncAge(int Age){
        return Age;
    }
    public static double fncWeight(double Weight){
        return Weight;
    }
    public static char fncFirstLetter(char FirstLetter){
        return FirstLetter;
    }
    public static bool fncCityCalgary(bool CityCalgary){
        return CityCalgary;
    }
}