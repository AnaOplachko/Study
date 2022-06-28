namespace OOP_01A;

public readonly struct Point
{
    private readonly int _abscissa;
    private readonly int _ordinate;
    private readonly string _pointName;

    public int Abscissa
    {
        get { return _abscissa; }
    }

    public int Ordinate
    {
        get { return _ordinate; }
    }

    public string PointName
    {
        get { return _pointName; }
    }

    public Point(string name, int x, int y)
    {
        _pointName = name;
        _abscissa = x; 
        _ordinate = y;
    }
}