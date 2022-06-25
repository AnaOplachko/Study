namespace OOP_01;

class Program
{
    static void Main()
    {
        Console.Write("Введите число точек на плоскости = ");
        var quantityAsString = Console.ReadLine();
        var quantity = Convert.ToInt32(quantityAsString);

        Point[] points = new Point [quantity];

        for (int i = 0; i < quantity; i++)
            var pointsQuantity = Convert.ToInt32(quantityAsString);

        Point[] points = new Point [pointsQuantity];

        for (int i = 0; i < pointsQuantity; i++)
            >>>>>>> 976970f (Initial commit)
        {
            Console.Write("Введите имя точки {0}: ", i+1);
            var userPointName = Console.ReadLine();

            Console.Write("Введите Х-координату точки {0}: ", i+1);
            var userXCoordinateAsString = Console.ReadLine();
            var userXCoordinate = Convert.ToInt32(userXCoordinateAsString);

            Console.Write("Введите Y-координату точки {0}: ", i+1);
            var userYCoordinateAsString = Console.ReadLine();
            var userYCoordinate = Convert.ToInt32(userYCoordinateAsString);

            Point point = new Point(userPointName, userXCoordinate, userYCoordinate);
            points[i] = point;
        }

     }