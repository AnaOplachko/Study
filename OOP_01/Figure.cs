using System.Security.Cryptography.X509Certificates;

namespace OOP_01;

public class Figure
{
    private int[] arrayAbscissa;
    private int[] arrayOrdinate;

    public Figure(Point A, Point B, Point C)
    {
        arrayAbscissa[0] = A.Abscissa; 
        arrayOrdinate[0] = A.Ordinate; 
        arrayAbscissa[1] = B.Abscissa; 
        arrayOrdinate[1] = B.Ordinate;
        arrayAbscissa[2] = C.Abscissa;
        arrayOrdinate[2] = C.Ordinate;
    }

    public Figure(Point A, Point B, Point C, Point D)
    {
        arrayAbscissa[0] = A.Abscissa; 
        arrayOrdinate[0] = A.Ordinate; 
        arrayAbscissa[1] = B.Abscissa; 
        arrayOrdinate[1] = B.Ordinate;
        arrayAbscissa[2] = C.Abscissa;
        arrayOrdinate[2] = C.Ordinate;
        arrayAbscissa[3] = D.Abscissa;
        arrayOrdinate[3] = D.Ordinate;
    }

    public Figure(Point A, Point B, Point C, Point D, Point E)
    {
        arrayAbscissa[0] = A.Abscissa; 
        arrayOrdinate[0] = A.Ordinate; 
        arrayAbscissa[1] = B.Abscissa; 
        arrayOrdinate[1] = B.Ordinate;
        arrayAbscissa[2] = C.Abscissa;
        arrayOrdinate[2] = C.Ordinate;
        arrayAbscissa[3] = D.Abscissa;
        arrayOrdinate[3] = D.Ordinate;
        arrayAbscissa[4] = E.Abscissa;
        arrayOrdinate[5] = E.Ordinate;
    }

    public double lengthSide(Point, Point)
    {

    }
    
   
    public double CalculatePerimetr()
    {
        
    }

}

/* public void PerimetrCalculator(double lengthSide1, double lengthSide2, double lengthSide3)
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
 public double LengthSide(int x0, int y0, int x1, int y1)
     {
         return lengthSide = Math.Sqrt((x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1));
     }

*/

