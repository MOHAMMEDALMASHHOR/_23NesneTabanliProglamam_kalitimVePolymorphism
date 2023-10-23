namespace EmployeeApp.Models;
public class ManagerAssistant:Manager{
    public double Salary { get; set; }
    public override void Work()
    {
        base.Work();
        System.Console.WriteLine(": By the manager assistant");
    }
}