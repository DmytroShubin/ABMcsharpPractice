using System;  
  public class Example  
   {  
     public static void Main(string[] args)  
      {  
       char ch = 'a';      
       int x, y, z, w;      
       for(x=1; x<=5; x++)      
       {      
        for(y=5; y>=x; y--)      
         Console.Write(" ");      
        for(z=1; z<=x; z++)      
         Console.Write(ch++);      
        ch--;      
        for(w=1; w<x; w++)      
         Console.Write(--ch);      
        Console.Write("\n");      
        ch='a';      
       }      
   }  
  }