using System;
using System.Collections.Generic;
  
public class GFG {
  
static void Main(string[] args) {
        int[] NumbersArray ={1,3,2,5,4};
        Console.WriteLine("Ascending  order");
        Array.Sort(NumbersArray);
        foreach(int i in NumbersArray) {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Descending  order");
        Array.Reverse(NumbersArray);
        foreach(int i in NumbersArray) {
            Console.WriteLine(i + " ");
        }
  }
}