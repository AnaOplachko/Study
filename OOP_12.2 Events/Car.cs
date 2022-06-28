namespace OOP_12._2_Events;

public class Car
{
    private string _carModel;
    private string _carYear;

    public string CarModel
    {
        get { return _carModel;}
        set { _carModel = value; }
    }

    public string CarYear
    {
        get { return _carYear; }
        set { _carYear = value; }
    }
}