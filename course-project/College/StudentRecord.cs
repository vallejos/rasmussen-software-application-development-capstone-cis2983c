using System;

public class StudentRecord
{
    public int id {get; set;}
    public Student student {get; set;}
    public StudentRecord(int _id, Student _student) {
        id = _id;
        student = _student;
    }
}