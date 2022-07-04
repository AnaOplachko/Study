namespace OOP_03._4;

public class Vehicle
{
    protected int coordinateX;
    protected int coordinateY;

    protected int price;
    protected int speed;
    protected string year;

    public virtual void Show()
    {
        Console.WriteLine();
    }
}