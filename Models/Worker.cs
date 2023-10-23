namespace EmployeeApp.Models;
public class Worker:Employee{
    public string WhatWork { get; set; }
    public Worker()
    {
        WhatWork =string.Empty;
    }
}