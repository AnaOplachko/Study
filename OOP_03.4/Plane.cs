namespace OOP_03._4;

public class Plane : Vehicle
{
    private int height;
    private int capacity;

    public Plane(int coordinateX, int coordinateY, int price, int speed, string year, int height, int capacity)
    {
        this.coordinateX = coordinateX;
        this.coordinateY = coordinateY;
        this.price = price;
        this.speed = speed;
        this.year = year;
        this.height = height;
        this.capacity = capacity;
    }
    
}