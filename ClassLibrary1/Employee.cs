public class Employee
{
    private int _emplID;
    private string _emplName;
    //private string _location;
    protected string _location;

    public Employee (int emplID, string emplName, string location)
    {
        _emplID = emplID;
        _emplName = emplName;
        _location = location;
    }
    //properties of Employee class
    public int EmplID
    {
        set { _emplID = value; }    
        get { return _emplID; }
    }

    public string EmplName
    {
        set { _emplName = value; }
        get { return _emplName; }
    }

    public string Location
    {
        set { _location = value; }
        get { return _location; }
    }

}
