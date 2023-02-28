using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       List<string> colors = new List<string>(); 
       colors.Add("Red");    
       colors.Add("Green");    
       colors.Add("Yelow");    
       colors.Add("Black"); 
	 colors.Add("Purple"); 
       colors.Remove("Black");
       for(int i=0;i<colors.Count; i++){
           if(colors [i]=="Yelow"){
               colors [i]="Pink";
           }
       }
      foreach(var color in colors)
      Console.WriteLine(color);
    }
}