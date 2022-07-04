namespace OOP_03._4;

public class Ship : Vehicle
{
    private int capacity;
    private string port;

    public Ship(int coordinateX, int coordinateY, int price, int speed, string year, int capacity, string port)

    {
        this.coordinateX = coordinateX;
        this.coordinateY = coordinateY;
        this.price = price;
        this.speed = speed;
        this.year = year;
        this.capacity = capacity;
        this.port = port;
    }
}