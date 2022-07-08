namespace A07._2;

public class Graph
{
    private int n;
    private double[,] list;

    public Graph(int n)
    {
        list = new double[n, n];
        this.n = n;
    }

    public Graph(double[,] array)
    {
        list = array;
        n = array.GetLength(0);
    }

    public IList<double> GetShortestPath(int start)
    {
        List<double> distance = new List<double>();
        bool[] visited = new bool [n];
        
        for (int i = 0; i < n; i++)
        {
            visited[i] = false;
            distance.Add(double.MaxValue);
        }

        distance[start] = 0;
        int index = -1;

        for (int i = 0; i < n; i++)
        {
            double min = double.MaxValue;

            for (int j = 0; j < n; j++)
            {
                if (!visited[j] && distance[j] <= min)
                {
                    min = distance[j];
                    index = j;
                }
            }

            visited[index] = true;

            for (int j = 0; j < n; j++)
            {
                if (!visited[j] && list[index, j] > -1 && distance[index] != double.MaxValue &&
                    distance[index] + list[index, j] < distance[j])
                    distance[j] = distance[index] + list[index, j];
            }
        }

        return distance;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}