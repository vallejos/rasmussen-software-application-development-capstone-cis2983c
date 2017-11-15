using System;

public class Faculty : Person
{
    public int employeeId {get; set;}
    public Faculty(int _employeeId, string _firstName, string _lastName) : base() {
        employeeId = _employeeId;
        firstName = _firstName;
        lastName = _lastName;
        username = "";
        password = "";
    }
}