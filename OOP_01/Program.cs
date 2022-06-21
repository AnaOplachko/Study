namespace OOP_01
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Введите число точек на плоскости = ");
            var quantityAsString = Console.ReadLine();
            var quantity = Convert.ToInt32(quantityAsString);

            Point[] points = new Point [quantity];

            for (int i = 0; i < quantity; i++)
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
            
            if (quantity == 3)
            {
                Figure triangle = new Figure(points[0], points[1], points [2]); 
                
                double firstSideLength = triangle.LengthSide(points[0].Abscissa, points[0].Ordinate, points[1].Abscissa, points[1].Ordinate);
                double secondSideLength = triangle.LengthSide(points[1].Abscissa, points[1].Ordinate, points[2].Abscissa, points[2].Ordinate);
                double thirdSideLength = triangle.LengthSide(points[0].Abscissa, points[0].Ordinate, points[2].Abscissa, points[2].Ordinate);

                triangle.PerimetrCalculator(firstSideLength, secondSideLength, thirdSideLength);
            }
            else if (quantity == 4)
            {
                Figure guadrilateral = new Figure(points[0],points[1],points[2], points[3]);
                
                double firstSideLength = guadrilateral.LengthSide(points[0].Abscissa, points[0].Ordinate, points[1].Abscissa, points[1].Ordinate);
                double secondSideLength = guadrilateral.LengthSide(points[1].Abscissa, points[1].Ordinate, points[2].Abscissa, points[2].Ordinate);
                double thirdSideLength = guadrilateral.LengthSide(points[2].Abscissa, points[2].Ordinate, points[3].Abscissa, points[3].Ordinate);
                double forthSideLength = guadrilateral.LengthSide(points[0].Abscissa, points[0].Ordinate, points[3].Abscissa, points[3].Ordinate);
                
                guadrilateral.PerimetrCalculator(firstSideLength, secondSideLength, thirdSideLength, forthSideLength);
            }
            else
            {
                Figure pentagon = new Figure(points[0].Abscissa, points[0].Ordinate,
                    points[1].Abscissa, points[1].Ordinate,
                    points[2].Abscissa, points[2].Ordinate,
                    points[3].Abscissa, points[3].Ordinate,
                    points[4].Abscissa, points[4].Ordinate);
                
                double firstSideLength = pentagon.LengthSide(points[0].Abscissa, points[0].Ordinate, points[1].Abscissa, points[1].Ordinate);
                double secondSideLength = pentagon.LengthSide(points[1].Abscissa, points[1].Ordinate, points[2].Abscissa, points[2].Ordinate);
                double thirdSideLength = pentagon.LengthSide(points[2].Abscissa, points[2].Ordinate, points[3].Abscissa, points[3].Ordinate);
                double forthSideLength = pentagon.LengthSide(points[3].Abscissa, points[3].Ordinate, points[4].Abscissa, points[4].Ordinate);
                double fifthSideLength = pentagon.LengthSide(points[0].Abscissa, points[0].Ordinate, points[4].Abscissa, points[4].Ordinate);

                pentagon.PerimetrCalculator(firstSideLength, secondSideLength, thirdSideLength, forthSideLength, fifthSideLength);
            }
            
        }
        
    }
}
