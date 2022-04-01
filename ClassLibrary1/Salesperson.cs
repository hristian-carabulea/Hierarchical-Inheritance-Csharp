public class Salesperson:Employee
{
    private string _region;

    //constructor
    public Salesperson(int emplID, string emplName, string location, string region) : base(emplID, emplName, location)
    {
        _region = region;
    }

    public string Region
    {
        set { _region = value; }
        get { return _region; }
    }

    public long GetSalesForTheCurrentMonth()
    {
        return 1000;
    }
}
