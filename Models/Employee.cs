namespace EmployeeApp.Models;
public class Employee{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Date { get; private set; }
    public Employee()
    {
        System.Console.WriteLine($"An instance has been devired form the Constractur method in: {Date}");
        FirstName ="";
        LastName ="";
        Date = DateTime.Now;
        
    }
    public Employee(string FirstName, string LastName):this()
    {
        System.Console.WriteLine($"An instance has been devired form the Constractur with 3 parameters method");
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    public Employee(int Id , string name, string lastName): this(name, lastName)
    {
        System.Console.WriteLine("An instance has been devired form the Constractur whit 2 parameters method");
        
    }
    public virtual void Work(){
        System.Console.WriteLine("Working.....");
    }
}