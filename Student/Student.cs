using Student;
using System;
//Matthew Prindle Lab5 Student Class
public class StudentC : Person
{

    public string Major { get; set; }
    public string GPA { get; set; }

    public StudentC(string Name, string Address, string Phone, string Email, string Major, string GPA) : base(Name,Address,Phone,Email) 
    {
        this.Major = Major;
        this.GPA = GPA;
    }
    public StudentC() :base()
    {
        this.Major = "0";
        this.GPA = "0";
    }

    public void Display()
    {
        base.Display();
        Console.WriteLine(Major);
        Console.WriteLine(GPA);
    }
}
