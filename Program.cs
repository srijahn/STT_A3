using System;

class Program
{
    static void Main()
    {   
        Console.WriteLine("Running Basic Operations...");
        BasicOperations.Run();  // Calls the BasicOperations class
        LoopsFunctions.Run();  // Calls the LoopsFunctions class
        Student student = new Student("John Doe", 12345, 85.5);
        student.DisplayDetails();  // Calls the DisplayDetails method of the Student class
        StudentIITGN studentIITGN = new StudentIITGN("Jane Doe", 67890, 92.0, "Hostel A");
        studentIITGN.DisplayIITGNDetails();  // Calls the DisplayIITGNDetails method of the StudentIITGN class
        Console.WriteLine("\nRunning Exception Handling...");
        ExceptionHandling.Run();
    
}}
