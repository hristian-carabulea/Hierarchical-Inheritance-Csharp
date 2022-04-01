public class Manager:Employee
{
    private string _departmentName;

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