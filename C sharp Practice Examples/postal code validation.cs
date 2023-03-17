using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      fncPostalCode("93015");
      fncPostalCode("5H50H0");
    }
    public static void fncPostalCode(string postalCode){
        int postalCodeLength=postalCode.Length;
       // Console.WriteLine("postalCodeLength");
        if(postalCodeLength==5){
         Console.WriteLine("USA Postal Code"+" "+postalCode);   
        }
        
        else if (postalCodeLength==6){
         Console.WriteLine("Canada Postal Code"+" "+postalCode); 
         Console.WriteLine(postalCode.Substring(0,3)+" "+postalCode.Substring(3,3)+"-"+"Correct Syntax");
        }
    }
}