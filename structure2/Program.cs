using System;


public struct Student
{




    public int Id;

    public string Name;

    public int Age;





    public void SetStudent(int id, string name, int age)

    {

        Id = id;

        Name = name;

        Age = age;


    }




    public void DisplayStudent()

    {

        Console.WriteLine(" Student:");

        Console.WriteLine("\tId    : " + Id);

        Console.WriteLine("\tName   : " + Name);

        Console.WriteLine("\tAge   : " + Age);

        Console.WriteLine("\n");
        Console.ReadLine();

    }



}