using System;

class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    public StudentIITGN(string name, int id, double marks, string hostel)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostel;
    }

    public void DisplayIITGNDetails()
    {
        Console.WriteLine($"IITGN Student: {Name}, ID: {ID}, Marks: {Marks}, Grade: {GetGrade()}, Hostel: {Hostel_Name_IITGN}");
    }
}
