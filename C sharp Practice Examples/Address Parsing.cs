using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string address1 ="113 greenbrier dr , waterloo , ON , N2L 4B3, CANADA";
        string address2 ="119-113 greenbrier dr , waterloo , ON , N2L 4B3, CANADA";
        Console.WriteLine("Address 1: ");
        fncAddress(address1);
        Console.WriteLine("\n");
        Console.WriteLine("Address 2: ");
        fncAddress(address2);
    }
    public static void fncAddress(string address)
    {
        string[] parts = address.Split(", ");
        string addressLine = parts[0];
        string[] addressSplit = addressLine.Split('-');
        
        Console.WriteLine(addressSplit.Length == 2 ? 
        $" Unit No - {addressSplit[0].Trim()}\n Address - {addressSplit[1].Trim()}":
        $"Address - {addressSplit[0].Trim()}");
        Console.WriteLine($"City - {parts[1].Trim()}");
        Console.WriteLine($"Province - {parts[2].Trim()}");
        Console.WriteLine($"Postal - {parts[3].Trim()}");
        Console.WriteLine($"Country - {parts[4].Trim()}");
    }
}