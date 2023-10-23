namespace EmployeeApp.Models;
public class Manager:Employee{
    public double Income { get; set; }
    public Manager()
    {
        
    }

    public Manager(string FirstName, string LastName) : base(FirstName, LastName)
    {
    }
    public Manager(int id, string firstName, string lastName):base(id,firstName,lastName)
    {
        
    }
    public override void Work()
    {
        base.Work();
        System.Console.Write("Management is happing");
    }
}