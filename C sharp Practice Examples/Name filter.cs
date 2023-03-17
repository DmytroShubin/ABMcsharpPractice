using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] Names={"My name is Rownie","My name is Rakesh","My name is Israa"};
    for(int i=0;i<Names.Length; i++){
    if(Names[i].Contains("Israa")){
    Console.WriteLine(Names[i]);
    }
}
}
}