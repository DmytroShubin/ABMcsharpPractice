using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Airport> AirportList = new List<Airport>();
        AirportList.Add(new Airport(1,"Isra", "Date of Birth ",new DateTime(1985, 03, 15)));
        AirportList.Add(new Airport(2,"Basant",  "Date of Birth ",new DateTime(1985, 03, 15)));
        AirportList.Add(new Airport(3,"Kelsey",  "Date of Birth ",new DateTime(1985, 03, 15)));
        AirportList.Add(new Airport(3,"Rashid",  "Date of Birth ",new DateTime(2003, 03, 15)));
        AirportList.Add(new Airport(3,"MJ",  "Date of Birth ",new DateTime(2005, 03, 15)));
        AirportList.Add(new Airport(3,"Dmytro",  "Date of Birth ",new DateTime(2000, 03, 15)));
       
       //foreach (var airport in AirportList)
{
    //Console.WriteLine("   {0}   {1}    {2}  {3}\n",airport.Id, airport.Code, airport.Name,airport.dob.ToString("yyyy,MM,dd"));
}
    
    foreach (var airport in AirportList){
        if(airport.dob>=new DateTime(2000, 01, 01)){
            Console.WriteLine("   {0}   {1}    {2}  {3}\n",airport.Id, airport.Code, airport.Name,airport.dob.ToString("yyyy,MM,dd"));
        }
    }
    }
}
    public class Airport
{
    public int id;
    public string code;
    public string name;
    public DateTime dob;
    
    public Airport(int id,string code, string name, DateTime dob)
    {
        this.id = id;
        this.code = code;
        this.name = name;
        this.dob = dob;
        
    }
    
    public int Id
    {
        get { return id;  }
        set { id = value; }
    }
    
    public string Code
    {
        get { return code;  }
        set { code = value; }
    }
  
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
   public DateTime Dob
    {
        get { return dob;  }
        set { dob = value; }
    }
}