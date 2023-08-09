using System;

class Employee
{
    private int id;
    private string name;
    private float salary;
    public int GetId()
    {
        return id;
    }
    public string GetName()
    {
        return name;
    }
    public float GetSalary()
    {
        return salary;
    }
    public Employee() { }
    public Employee(int i) { id = i; }
    public Employee(int i, string n) { id = i; name = n; }
    public Employee(int i, string n, float s) { id = i; name = n; salary = s; }

}
class Lap_8_1_1
{
    public static void Main()
    {
        Console.WriteLine($"Enter the Number of employees ");
        int EmployeeCount = int.Parse(Console.ReadLine());
        Employee[] EmployeeSheet = new Employee[EmployeeCount];

        Fill(EmployeeSheet);
        Print(EmployeeSheet);
    }
    public static void Fill(Employee[] EmployeeSheet)
    {
        for (int EmployeeNumber = 0; EmployeeNumber < EmployeeSheet.Length; EmployeeNumber++)
        {
            Employee NewEmployee = new Employee();

            Console.WriteLine($"Enter the id for employee No.{EmployeeNumber + 1}");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the name for employee No.{EmployeeNumber + 1}");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the salary for employee No.{EmployeeNumber + 1}");
            float salary = float.Parse(Console.ReadLine());

            NewEmployee = new Employee(id, name, salary);
            EmployeeSheet[EmployeeNumber] = NewEmployee;
        }
    }
    public static void Print(Employee[] EmployeeSheet)
    {
        int EmployeeNumber = 0;
        foreach (Employee NewEmployee in EmployeeSheet)
        {
            Console.WriteLine($"Employee : {EmployeeNumber + 1}");
            Console.WriteLine($"Employee ID: {NewEmployee.GetId()}");
            Console.WriteLine($"Employee Name: {NewEmployee.GetName()}");
            Console.WriteLine($"Employee Salary: {NewEmployee.GetSalary()}");
            EmployeeNumber++;
        }
    }
}