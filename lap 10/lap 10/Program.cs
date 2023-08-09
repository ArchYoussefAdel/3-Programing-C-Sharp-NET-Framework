using System;

class Person
{
    protected string name;
    public string GetName()
    {
        return name;
    }
    public virtual void PrintData(Employee[] EmployeeSheet)
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
        Console.WriteLine($"Employees Work at: {Employee.GetCompany()}");
        Console.WriteLine($"Employee Count: {Employee.GetCounter()}");
    }
}
class Employee : Person
{
    private static string companyName = "GOOGLE";
    private static int counter = 0;
    private int id;
    private float salary;
    public int GetId()
    {
        return id;
    }
    public float GetSalary()
    {
        return salary;
    }
    public static int GetCounter()
    {
        return counter;
    }
    public static string GetCompany()
    {
        return companyName;
    }
    public Employee() { }
    public Employee(int i) { id = i; counter++; }
    public Employee(int i, string n) { id = i; name = n; counter++; }
    public Employee(int i, string n, float s) { id = i; name = n; salary = s; counter++; }
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
    public override void PrintData(Employee[] EmployeeSheet)
    {
        int EmployeeNumber = 0;
        foreach (Employee NewEmployee in EmployeeSheet)
        {
            Console.WriteLine($"\nEmployee : {EmployeeNumber + 1}");
            Console.WriteLine($"Employee ID: {NewEmployee.GetId()}");
            Console.WriteLine($"Employee Name: {NewEmployee.GetName()}");
            Console.WriteLine($"Employee Salary: {NewEmployee.GetSalary()}");
            EmployeeNumber++;
        }
        Console.WriteLine($"\nEmployees Work at: {Employee.GetCompany()}");
        Console.WriteLine($"Employee Count: {Employee.GetCounter()}\n");
    }
}
class Customer : Person
{
    private static string companyName = "GOOGLE";
    private static int counter = 0;
    private int id;
    public int GetId()
    {
        return id;
    }
    public static int GetCounter()
    {
        return counter;
    }
    public static string GetCompany()
    {
        return companyName;
    }
    public Customer() { }
    public Customer(int i) { id = i; counter++; }
    public Customer(int i, string n) { id = i; name = n; counter++; }
    public static void Fill(Customer[] CustomerSheet)
    {
        for (int CustomerNumber = 0; CustomerNumber < CustomerSheet.Length; CustomerNumber++)
        {
            Customer NewCustomer = new Customer();

            Console.WriteLine($"Enter the id for Customer No.{CustomerNumber + 1}");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the name for Customer No.{CustomerNumber + 1}");
            string name = Console.ReadLine();

            NewCustomer = new Customer(id, name);
            CustomerSheet[CustomerNumber] = NewCustomer;
        }
    }
    public void PrintData(Customer[] CustomerSheet)
    {
        int CustomerNumber = 0;
        foreach (Customer NewCustomer in CustomerSheet)
        {
            Console.WriteLine($"\nCustomer : {CustomerNumber + 1}");
            Console.WriteLine($"Customer ID: {NewCustomer.GetId()}");
            Console.WriteLine($"Customer Name: {NewCustomer.GetName()}");
            CustomerNumber++;
        }
        Console.WriteLine($"\nCustomers of: {Customer.GetCompany()}");
        Console.WriteLine($"Customer Count: {Customer.GetCounter()}\n");
    }
}
class Lap_10_1_1
{
    public static void Main()
    {
        Console.WriteLine($"Enter the Count of employees ");
        int EmployeeCount = int.Parse(Console.ReadLine());

        Employee[] EmployeeSheet = new Employee[EmployeeCount];

        Employee.Fill(EmployeeSheet);

        Employee e = new Employee();

        e.PrintData(EmployeeSheet);

        //Console.WriteLine($"Enter the Number of customers ");
        //int CustomerCount = int.Parse(Console.ReadLine());
        //Customer[] CustomerSheet = new Customer[CustomerCount];
        //Customer.Fill(CustomerSheet);
        //Customer c = new Customer();
        //c.PrintData(CustomerSheet);
    }
}