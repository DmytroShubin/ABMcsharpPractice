using System;
using System.Collections.Generic;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
      /*int[] array = Enumerable.Range(1, 100).ToArray();
      foreach( var arr in array){
        Console.Write ("\t"+arr);*/
        Count();
      }
       public static void Count(){
       int[] array = Enumerable.Range(1, 100).ToArray();
       
       for (int z =0; z<10;z++)
       {
        for (int x =0; x<10;x++)
        {
            int index = z*10+x;
            Console.Write ("{0,3}", array[index]);
        }
         Console.WriteLine ();
       }
        //foreach( var arr in array){
        //Console.Write ("\t"+arr);
        //}
    }
}