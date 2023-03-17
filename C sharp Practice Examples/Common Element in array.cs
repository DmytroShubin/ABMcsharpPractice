using System;

namespace DevApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Declaire array
            int[] array1 = new int[] { 1,2,3};
            int[] array2 = new int[] { 3,4,5 };
            int[] array3 = new int[] { 3,7,6 };
            // Running Loop for similar elements
            for (int i = 0; i < array1.Length ; i++){
             for (int j = 0; j < array2.Length ; j++){
                 for (int k = 0; k < array3.Length ; k++){
                     // if it is match printing it
                     if (array1[i]==array2[j]&&array1[i]==array3[k]){
                         Console.WriteLine("CommonElement"+" "+array3[k]);

                     }
                 }
             }
}
}
}
}
