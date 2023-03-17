using System;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        int[] numbers = { 1,2,3,4,5,6,7,8,9,10,10 };
        int length = numbers.Length;
        int count = numbers.Sum();
        double mean = count/length;
        Console.WriteLine("Mean: " + mean);
        Console.WriteLine();
        int median = length/2;
        Console.WriteLine("Median: " + numbers[median]);
        Console.WriteLine();
        for (int i = 0; i < numbers.Length; i++)
        {
         for (int j =numbers.Length - 1;i<j; j--)
         {
             if (numbers[j] == numbers[i]){
                 Console.Write ("Mode: " +numbers[i]);
             }
      
         }
         
           
    }
    }
}