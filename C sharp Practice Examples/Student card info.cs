using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double Total = 0;
      List<StudentInfo> StudentInfoList = new List<StudentInfo>();
      
      StudentInfo stident1= new StudentInfo();
      stident1.StudentId= 1;
      stident1.StudentName= "Dmytro";
      stident1.MarksList.Add(new Marks {Subject  = "Math", Score = 95} );
      stident1.MarksList.Add(new Marks {Subject  = "Social Studies", Score = 93} );
      stident1.MarksList.Add(new Marks {Subject  = "Physic", Score = 87} );
      stident1.MarksList.Add(new Marks {Subject  = "Religion", Score = 95} );
      stident1.MarksList.Add(new Marks {Subject  = "Science", Score = 90} );
      stident1.FirstTermScore=30;
      stident1.SecondTermScore=45;
      stident1.ThirdTermScore=87;
      StudentInfoList.Add(stident1);
      foreach (var stident in StudentInfoList)
    {
    Console.WriteLine("Student Id: {0}",stident.StudentId);
    Console.WriteLine("Name: {0}",stident.StudentName);
    Console.WriteLine("First Term Score: {0}",stident.FirstTermScore);
    Console.WriteLine("Second Term Score: {0}",stident.SecondTermScore);
    Console.WriteLine("Third Term Score: {0}",stident.ThirdTermScore);
    Console.WriteLine("Marks:");
    foreach (var mark in stident.MarksList)
    {
     Console.WriteLine("{0} {1} ",mark.Subject, mark.Score );   
    }
    Total = (stident.FirstTermScore+stident.SecondTermScore+stident.ThirdTermScore)/3;
    Console.WriteLine("Total : "+Total );
    if (Total>= 70){
        Console.WriteLine("Pass");
    }
    else{
        Console.WriteLine("Failed");
    }
    
    } 
    }
   public class StudentInfo
    {
      public  int StudentId{get;set;}
      public  string StudentName{get;set;}
      public  List<Marks>MarksList{get;set;}=new List<Marks>(); 
      public  double FirstTermScore{get;set;}
      public  double SecondTermScore{get;set;}
      public  double ThirdTermScore{get;set;}
      public  double TotalScore{get;set;}
      public  bool isPass{get;set;}
    }
   public class Marks
    {
      public string Subject {get;set;}
      public  double Score{get;set;}
      
    }
}    