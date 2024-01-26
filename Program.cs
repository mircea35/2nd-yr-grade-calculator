using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
abstract class Student
{
    public string studentName { get; set; }
    public string grade {get; set; }
    public string gradeBoundry { get; set; }

    public int marks {  get; set; }

    public Student(string name, int marks, string grade)
    {
        this.studentName = name;
        this.grade = grade;
        this.marks = marks;
    }

    public abstract string GetBoundary();
}

class LowerStudent: Student
{
    public LowerStudent(string name,int marks, string grade) : base(name, marks, grade)
    {

    }
    public override string GetBoundary()
    {
        return "Lower";
    }
}

class HigherStudent : Student
{
    public HigherStudent(string name, int marks, string grade) : base(name, marks, grade)
    {

    }
    public override string GetBoundary()
    {
        return "Higher";
    }
}
internal class Program
{
    static void SortingStudents(List<Student> LowerStudent, List<Student> HigherStudent)
    {
        LowerStudent = LowerStudent.OrderByDescending(o => o.marks).ToList();
        HigherStudent = HigherStudent.OrderByDescending(o => o.marks).ToList();
        Console.WriteLine("\n");
        Console.WriteLine("Lower Students:");
        foreach (Student student in LowerStudent)
        {
            Console.WriteLine($"Student name: {student.studentName}");
            Console.WriteLine($"Student grade boundary: {student.GetBoundary()}");
            Console.WriteLine($"Student marks: {student.marks}");
            Console.WriteLine($"Student grade: {student.grade}");
            Console.WriteLine("\n");
        }
        Console.WriteLine("Higher Students:");
        foreach (Student student in HigherStudent)
        {
            Console.WriteLine($"Student name: {student.studentName}");
            Console.WriteLine($"Student grade boudary: {student.GetBoundary()}");
            Console.WriteLine($"Student marks: {student.marks}");
            Console.WriteLine($"Student grade: {student.grade}");
            Console.WriteLine("\n");
        }
    }
    static void AddingStudent(List<Student> LowerStudent, List<Student> HigherStudent)
    {
        int temp_marks = 0;
        string temp_name = "", temp_boundary = "", temp_grade = "";

        Console.WriteLine("Enter student name: ");
        temp_name = Console.ReadLine() ?? "";
        Console.WriteLine("Enter the marks: ");
        temp_marks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What grade boundary? Lower/Higher");
        temp_boundary = Console.ReadLine().ToLower() ?? "";
        if(temp_boundary == "lower")
        {
            if( 21 > temp_marks && temp_marks >= 0)
            {
                temp_grade = "U";
            }
            else if (41 > temp_marks && temp_marks >= 21)
            {
                temp_grade = "F";
            }
            else if (61 > temp_marks && temp_marks >= 41)
            {
                temp_grade = "E";
            }
            else if (81 > temp_marks && temp_marks >= 61)
            {
                temp_grade = "D";
            }
            else if (91 > temp_marks && temp_marks >= 81)
            {
                temp_grade = "C";
            }
            else if (101 > temp_marks && temp_marks >= 91)
            {
                temp_grade = "B";
            }

            LowerStudent.Add(new LowerStudent(temp_name,temp_marks, temp_grade));
        }
        else if(temp_boundary == "higher")
        {
            if (11 > temp_marks && temp_marks >= 0)
            {
                temp_grade = "U";
            }
            else if (31 > temp_marks && temp_marks >= 11)
            {
                temp_grade = "F";
            }
            else if (51 > temp_marks && temp_marks >= 31)
            {
                temp_grade = "E";
            }
            else if (61 > temp_marks && temp_marks >= 51)
            {
                temp_grade = "D";
            }
            else if (71 > temp_marks && temp_marks >= 61)
            {
                temp_grade = "C";
            }
            else if (81 > temp_marks && temp_marks >= 71)
            {
                temp_grade = "B";
            }
            else if (91 > temp_marks && temp_marks >= 81)
            {
                temp_grade = "A";
            }
            else if (101 > temp_marks && temp_marks >= 91)
            {
                temp_grade = "A*";
            }
            HigherStudent.Add(new HigherStudent(temp_name, temp_marks, temp_grade));
        }
        else
        {
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        string usrChoice = "";
        List<Student> LowerStudents = new List<Student>();
        List<Student> HigherStudents = new List<Student>();

        while (true)
        {
            Console.WriteLine("Welcome!\n What do you want to do?\n 1 - Add a student\n 2 - Sort users\n");
            usrChoice = Console.ReadLine() ?? "";
            switch (usrChoice)
            {
                case "1":
                    AddingStudent(LowerStudents, HigherStudents);
                    break;
                case "2":
                    SortingStudents(LowerStudents, HigherStudents);
                    break;
                default:
                    Console.WriteLine("How you got here? Error!!!");
                    break;
            }
        }
    }
}
