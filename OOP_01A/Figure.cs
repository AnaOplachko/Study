namespace OOP_01A;
public class Figure
{
    private int[] abscisse;
    private int[] ordinate;
    private string[] pointName;
    
    public Figure(Point[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            pointName[i] = array[i].PointName;
            abscisse[i] = array[i].Abscissa;
            ordinate[i] = array[i].Ordinate;
        }
    }
    public double CalculatePerimetr()
    {
        double perimetr = 0;
        var summond1 = 0;
        var summond2 = 0;
        double sum;

        for (int i = 0; i < pointName.Length - 1; i++)
        {
            summond1 = abscisse[i+1] - abscisse[i];
            summond2 = ordinate[i+1] - ordinate[i];
            sum = Math.Pow(summond1, 2) + Math.Pow(summond2, 2);
            perimetr += Math.Sqrt(sum);
        }
        
        var lastSideSummond1 = abscisse[abscisse.Length-1] - abscisse[0];
        var lastSideSummond2 = ordinate[ordinate.Length-1] - ordinate[0];
        var lastSideSum = Math.Pow(lastSideSummond1, 2) + Math.Pow(lastSideSummond2, 2);
        perimetr += Math.Sqrt(lastSideSum);

        return perimetr;
    }

    public string figureName;
    public string GetFigureName()
    {
        for (int i = 0; i < pointName.Length; i++)
        {
            figureName += pointName[i];
        }

        return figureName;
    }

    public string figureType;
    
    public string GetFigureType()
    {
       switch (pointName.Length)
           {
               case 3:
               figureType = "Треугольник";
               break;
               case 4:
               figureType = "Четырехугольник";
               break;
               case 5:
               figureType = "Пятиугольник";
               break;
           }
       return figureType;
    }
}