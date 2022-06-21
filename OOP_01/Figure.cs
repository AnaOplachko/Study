using System.Security.Cryptography.X509Certificates;

namespace OOP_01;

public class Figure
{
    private int x0, x1, x2, x3, x4;
    private int y0, y1, y2, y3, y4;
    
    public Figure(Point A, Point B, Point C)
    {
        this.x0 = x0;
        this.y0 = y0;
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
    
    public Figure(Point A, Point B, Point C, Point D)
    {
        this.x0 = x0;
        this.y0 = y0;
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
    }

    public Figure(Point A, Point B, Point C, Point D, Point E)
    {
        this.x0 = x0;
        this.y0 = y0;
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
        this.x4 = x4;
        this.y4 = y4;
    }

    public double lengthSide(Point, Point)
    {
        
    };
    public double LengthSide(int x0, int y0, int x1, int y1)
    {
        return lengthSide = Math.Sqrt((x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1));
    }

    public void PerimetrCalculator(double lengthSide1, double lengthSide2, double lengthSide3)
    {
        double trianglePerimetr = lengthSide1 + lengthSide2 + lengthSide3;
        Console.WriteLine("Периметр треугольника = {0:F2}", trianglePerimetr);
    }

    public void PerimetrCalculator(double lengthSide1, double lengthSide2, double lengthSide3, double lengthSide4)
    {
        double guadrilateralPerimetr = lengthSide1 + lengthSide2 + lengthSide3 + lengthSide4;
        Console.WriteLine("Периметр четырехугольника = {0:F2}", guadrilateralPerimetr);
    }

    public void PerimetrCalculator(double lengthSide1, double lengthSide2, double lengthSide3, double lengthSide4, double lengthSide5)
    {
        double pentagonPerimetr = lengthSide1 + lengthSide2 + lengthSide3 + lengthSide4 + lengthSide5;
        Console.WriteLine("Периметр пятиугольника = {0:F2}", pentagonPerimetr);
    }
}


