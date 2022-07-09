namespace A08;

public class Graph
{
    private double[,] list;
    private int n;

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

    public void Add(int from, int to, int cost)
    {
        list[from, to] = cost;
    }

    public IList<int> DFS(int from)
    {
        bool[] visited = new bool [n];
        Stack<int> stack = new Stack<int>();
        IList<int> result = new List<int>();

        visited[from] = true;
        stack.Push(from);

        while (stack.Count != 0)
        {
            int index = stack.Pop();
            
            result.Add(index);

            for (int i = 0; i < n; i++)
            {
                if (!visited[index] && list[index, i] != 0)
                {
                    stack.Push(i);
                    visited[i] = true;
                }
            }
        }

        return result;
    }

    public int DegreeOfVertex(int vertex)
    {
        int degree = 0;
        for (int i = 0; i < n; i++)
        {
            if (list[vertex, i] != 0)
                degree++;
        }

        return degree;
    }

    public double[,] GetAllShortestPath()
    {
        double[,] distance = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                distance[i, j] = list[i, j];
            }
        }

        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (distance[i, k] != 0 && distance[k, j] != 0 && i != j)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j] || distance[i, j] == 0)
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                        }
                    }
                }
            }
        }

        return distance;
    }

    public IDictionary<int, IList<int>> GetComponents()
    {
        int color = 1;
        IDictionary<int, IList<int>> table = new Dictionary<int, IList<int>>();

        int count = n;

        while (count > 0)
        {
            int vertex = 0;
            bool[] visited = new bool[n];
            int[] colors = new int[n];
            
            while (visited[vertex] && DegreeOfVertex(vertex) == 0)
            {
                vertex++;
            }

            var vertices = DFS(vertex);

            foreach (int item in vertices)
            {
                visited[item] = true;
                colors[item] = color;
            }

            count -= vertices.Count;
            
            table.Add(color, vertices);
            color++;
        }

        return table;
    }

    enum Colors
    {
        White,
        Grey,
        Black
    };

    public IList<int> TopologicalSort()
    {
        Stack<int> result = new Stack<int>();
        Colors[] colors = new Colors[n];
        Stack<int> path = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int vertex = i;
            int saved = i;

            if (path.Count > 0)
            {
                i--;
                vertex = path.Pop();
                saved = vertex;
            }
            
            if (colors[vertex] == Colors.Black)
                continue;

            colors[vertex] = Colors.Grey;
            path.Push(vertex);

            for (int j = 0; j < n; j++)
            {
                if (list[vertex, j] != 0 && colors[j] != Colors.Black)
                {
                    if (colors[j] == Colors.Grey)
                        return null;

                    vertex = j;
                    path.Push(vertex);
                    break;
                }
            }

            if (vertex == saved)
            {
                colors[vertex] = Colors.Black;
                result.Push(vertex);
                path.Pop();
            }
        }

        return result.ToList();
    }


















}