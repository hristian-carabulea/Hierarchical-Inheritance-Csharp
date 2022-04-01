/// <summary>
/// Hierarchial inheritance: one parent, two children (in this case).
/// </summary>
class Program
{
    static void Main()
    {
        // create objects
        Employee empl1 = new Employee();
        empl1.EmplID = 101;
        empl1.EmplName = "Joe Blow";
        empl1.Location = "Detroit";
        System.Console.WriteLine("\nObject of Parent Class Employee: ");
        System.Console.WriteLine("Employee ID: " + empl1.EmplID);
        System.Console.WriteLine("Employee Name: " + empl1.EmplName);
        System.Console.WriteLine("Employee Location: " + empl1.Location);

        Salesperson salesm1 = new Salesperson();
        salesm1.EmplID = 102;
        salesm1.EmplName = "McKinny McKoona";
        salesm1.Location = "Troy";
        salesm1.Region = "East";
        System.Console.WriteLine("\nObject of Child Class Salesperson: ");
        System.Console.WriteLine("Salesperson ID: " + salesm1.EmplID);
        System.Console.WriteLine("Salesperson Name: " + salesm1.EmplName);
        System.Console.WriteLine("Salesperson Location: " + salesm1.Location);
        System.Console.WriteLine("Salesperson Region: " + salesm1.Region);
        System.Console.WriteLine("Sales for the current month: " + salesm1.GetSalesForTheCurrentMonth());

        Manager mgr1 = new Manager();
        mgr1.EmplID = 103;
        mgr1.EmplName = "Elvis Costello";
        mgr1.Location = "Dearborn";
        mgr1.DepartmentName = "Accounting";
        System.Console.WriteLine("\nObject of Child Class Manager: ");
        System.Console.WriteLine("Manager ID: " + mgr1.EmplID);
        System.Console.WriteLine("Manager Name: " + mgr1.EmplName);
        System.Console.WriteLine("Manager Location: " + mgr1.Location);
        System.Console.WriteLine("Manager full Location: " + mgr1.GetFullDeptName()); //location is protected. can access only via method
        System.Console.WriteLine("Total Sales for the Year: " + mgr1.GetTotalSalesForTheYear());

        System.Console.Write("\nEnter any key to end program: ");
        System.Console.ReadKey();
    }
}