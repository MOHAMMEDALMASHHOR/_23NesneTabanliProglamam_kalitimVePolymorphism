using EmployeeApp.Models;

//NewMethod();
Manager manager1 =new Manager("Mohammed","Almashhor");
manager1.Work();
ManagerAssistant assistant1 = new ManagerAssistant(){
    Id =1,
    FirstName = "Fakid",
    LastName = "Alhadi",
    Salary = 50_000
};
assistant1.Work();

static void NewMethod()
{
    Employee emp1 = new Employee();
    emp1.FirstName = "Mohammed";
    System.Console.WriteLine(emp1.FirstName);
    Employee emp2 = new Employee(12, "Manger", "Fanger");
}
