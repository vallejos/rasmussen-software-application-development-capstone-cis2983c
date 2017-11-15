using System;
using System.Collections.Generic;

public class CourseOffering
{
    public int id {get; set;}
    public List<CourseRecord> courseRecords {get; set;}
    public StudentRecord studentRecord {get; set;}
    public CourseOffering(int _id, StudentRecord _studentRecord) {
        id = _id;
        courseRecords = new List<CourseRecord>();
        studentRecord = _studentRecord;
    }
}