public class Salesperson:Employee
{
    private string _region;
    private string Region
    {
        set { _region = value; }
        get { return _region; }
    }

    public long GetSalesForTheCurrentMonth()
    {
        return 1000;
    }
}
