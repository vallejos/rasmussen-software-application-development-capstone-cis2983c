using System;

public class Student : Person
{
    public int studentId {get; set;}
    public CourseProgram program {get; set;}
    public string degree {get; set;}
    public double gpa {get; set;}
    public StudentRecord studentRecord {get; set;}
    public Student(int _studentId, string _firstName, string _lastName) : base() {
        studentId = _studentId;
        firstName = _firstName;
        lastName = _lastName;
        username = "";
        password = "";
    }
}