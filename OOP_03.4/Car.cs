namespace OOP_03._4;

public class Car : Vehicle
{
    public Car(int coordinateX, int coordinateY, int price, int speed, string year)
    {
        this.coordinateX = coordinateX;
        this.coordinateY = coordinateY;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public override void Show()
    {
        Console.WriteLine("Наше авто находится по координатам Х: {0}, Y: {1}, стоит {2}  рублев, несется со скоростью {3} км/ч и выпущено в {4} году", coordinateX, coordinateY, price, speed, year);
    }
}