using System;

public class CourseRecord
{
    public int id {get; set;}
    public bool online {get; set;}
    public string name {get; set;}
    public int credits {get; set;}
    public string requirements {get; set;}
    public CourseRecord(int _id, string _name, int _credits, bool _online) {
        id = _id;
        name = _name;
        credits = _credits;
        online = _online;
        requirements = "";
    }
}