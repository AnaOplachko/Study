namespace OOP_01A
{
   class Program
   {
      static void Main()
      {
         Console.Write("Введите число точек на плоскости = ");
         var quantityAsString = Console.ReadLine();
         var pointsQuantity = Convert.ToInt32(quantityAsString);

         Point[] points = new Point[pointsQuantity];

         for (int i = 0; i < pointsQuantity; i++)
         {
            Console.Write("Введите имя точки {0}: ", i + 1);
            var userPointName = Console.ReadLine();

            Console.Write("Введите Х-координату точки {0}: ", i + 1);
            var userXCoordinateAsString = Console.ReadLine();
            var userXCoordinate = Convert.ToInt32(userXCoordinateAsString);

            Console.Write("Введите Y-координату точки {0}: ", i + 1);
            var userYCoordinateAsString = Console.ReadLine();
            var userYCoordinate = Convert.ToInt32(userYCoordinateAsString);

            Point point = new Point(userPointName, userXCoordinate, userYCoordinate);
            points[i] = point;
         }

         Figure figure = new Figure(points);
         var figurePerimetr = figure.CalculatePerimetr();

         var figureName = figure.GetFigureName();

         var figureType = figure.GetFigureType();

         Console.WriteLine("{0} {1} имеет периметр {2:F2}", figureType, figureName, figurePerimetr);
      }
   }
}