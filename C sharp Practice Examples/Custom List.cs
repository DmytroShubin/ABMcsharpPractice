using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double totalcost=0;
        List<Meal> MealList = new List<Meal>();
        MealList.Add(new Meal(1,"Big Mac", 7.99));
        MealList.Add(new Meal(2,"Mac Chicken", 5.99));
        MealList.Add(new Meal(3,"Delux", 9.99));
       
       foreach (var meal in MealList)
{
    Console.WriteLine("Meal:   {0}   {1}    {2}",meal.id, meal.Name, meal.Price);
}
     Console.WriteLine("Please Make your Selection");
     string input = Console.ReadLine();
     string [] arrayInput=input.Split(" ");
     for(int i=0; i<=arrayInput.Length-1; i++){
         foreach (var meal in MealList){
             if(meal.id==Convert.ToInt32(arrayInput[i])){
               Console.WriteLine("Meal:   {0}   {1}    {2}",meal.id, meal.Name, meal.Price);  
               totalcost+=meal.Price;
             }
         }
     }
     Console.WriteLine("Meal Total:"+" "+ totalcost);
    }
    public class Meal
{
    public int id;
    public string name;
    public double price;
  
    public Meal(int id,string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        
    }
    
    public int Id
    {
        get { return id;  }
        set { id = value; }
    }
    
    public string Name
    {
        get { return name;  }
        set { name = value; }
    }
  
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
   
}
   
}