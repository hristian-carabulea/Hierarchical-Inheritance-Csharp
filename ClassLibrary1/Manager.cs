public class Manager:Employee
{
    private string _departmentName;

    //child class constructor
    public Manager(int emplID, string emplName, string location, string departmentName):base(emplID, emplName, location)
    {
        _departmentName = departmentName;
    }

    //properties
    public string DepartmentName
    {
        set { _departmentName = value; } 
        get { return _departmentName; }
    }

    //methods

    public long GetTotalSalesForTheYear()
    {
        return 10000;
    }

    public string GetFullDeptName()
    {
        return DepartmentName + " at " + base.Location;
    }

}