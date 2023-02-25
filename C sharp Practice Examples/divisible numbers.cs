using System;
using System.Linq;
  
public class GFG {
  
static void Main(string[] args) {
      int n;
            Console.WriteLine("Enter the Number :");
            n =Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(i<n)
            {
                i++;
                if(n%i==0){
                Console.WriteLine(i);  
               }
            }
}
}