public class Land
{
    public int Id
    {
        get;
        set;
    }
    public string LandCode
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }

    // The size of the land in square meters
    public decimal Acreage
    {
        get;
        set;
    }

    public decimal PricePaid
    {
        get;
        set;
    }

    public DateTime AcquisitionDate
    {
        get;
        set;
    }
}
