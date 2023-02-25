using System;
using System.Linq;
  
public class GFG {
  
static void Main(string[] args) {
    for (int x=1; x<=100;x++){
        bool isPrime= true;
    for (int i=2;i<x;i++){
        if(x%i==0){
            isPrime=false;
        }
    } 
        if (isPrime&&x>1){
            Console.WriteLine(x);
        }
    }
}
}