using System;

class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    public Student(string name, int id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    public string GetGrade()
    {
        if (Marks >= 90) return "A";
        else if (Marks >= 80) return "B";
        else if (Marks >= 70) return "C";
        else if (Marks >= 60) return "D";
        else return "F";
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Student Name: {Name}, ID: {ID}, Marks: {Marks}, Grade: {GetGrade()}");
    }
}
