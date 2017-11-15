using System;
using System.Collections.Generic;

public class CourseGiven
{
    public int id {get; set;}
    public Faculty faculty {get; set;}
    public List<CourseRecord> courseRecord {get; set;}

    public CourseGiven(int _id, Faculty _faculty) {
        id = _id;
        faculty = _faculty;
        courseRecord = new List<CourseRecord>();
    }
}