namespace A07._2;

class Program
{
    static void Main()
    {
        double[,] g = {
            { 0, 5, -1, 6, -1, 50 },
            { 5, 0, 7, -1, -1, -1 },
            { -1, 7, 0, 4, -1, 10 },
            { 6, -1, 4, 0, 10, -1 },
            { -1, -1, -1, 10, 0, 8 },
            {50, -1, 10, -1, 8, 0}
        };

        Graph graph = new Graph(g);

        int start = 0;

        IList<double> dist = graph.GetShortestPath(start);
        int i = 1;

        foreach (var item in dist)
        {
            Console.WriteLine("From {0} to {1} -> {2}", start +1, i , item);
            i++;
        }
    }
}