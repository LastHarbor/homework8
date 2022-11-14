namespace homework8._3;

public struct Worker
{
    private string FIO;
    private string Street;
    private string  HouseNumber;
    private string FlatNumber;
    private string MobilePhone;
    private string FlatPhone;
    
    public string fio
    {
        get { return this.FIO;}
        set { this.FIO = value; }
    }

    public string street
    {
        get { return this.Street; }
        set { this.Street = value; }
    }

    public string houseNumber
    {
        get { return this.HouseNumber;}
        set { this.HouseNumber = value; }
    }

    public string flatNumber
    {
        get { return this.FlatNumber;}
        set { this.FlatNumber = value; }
    }

    public string mobilePhone
    {
        get { return this.MobilePhone;}
        set { this.MobilePhone = value; }
    }

    public string flatPhone
    {
        get { return this.FlatPhone;}
        set { this.FlatPhone = value; }
    }
}