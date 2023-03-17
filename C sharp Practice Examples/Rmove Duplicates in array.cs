using System;
class Program
{
    static void Main (string[]args)
    {
        int i = 0, j = 0;
        int[] arr1 = new int[]{ 1,2,2,3,4,5,6 };
        for (i = 0; i < arr1.Length; i++)
        {
            bool isDuplicate= false;
         for (j = 0; j < i; j++)
         {
            // if (i == j)
            // continue;
             if (arr1[j] == arr1[i]){
                 isDuplicate= true;
                 break;
             }
      
         }
         if (!isDuplicate)
         {
             Console.Write (arr1[i]);
         }
        }
    }
}