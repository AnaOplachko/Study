namespace A06._1_Graph;

public class Graph
{
    private double[,] list;
    private int n;

    public Graph(int n)
    {
        list = new double[n, n];
        this.n = n;
    }
    
    public Graph (double [,] array)
    {
        list = array;
        n = array.GetLength(0);
    }

    public void Add(int from, int to, double cost)
    {
        list[from, to] = cost;
    }

    public void BFS(int from)
    {
        bool[] visited = new bool[n];
        Queue<int> turn = new Queue<int>();
        visited[from] = true;
        turn.Enqueue(from);

        while (turn.Count != 0)
        {
            int index = turn.Dequeue();

            Console.WriteLine(index);

            for (int i = 0; i < n; i++)
            {
                if (list[index, i] != 0 && !visited[i])
                {
                    visited[i] = true;
                    
                    turn.Enqueue(i);
                }
            }
        }
    }

    public int RoadsNumber()
    {
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (list[i, j] == 1)
                {
                    result++;
                }
            }
        }
        
        return result;
    }

    public IList<int> BFSToList(int from)
    {
        bool[] visited = new bool[n];
        Queue<int> turn = new Queue<int>();
        IList<int> result = new List<int>();
        
        turn.Enqueue(from);
        visited[from] = true;

        while (turn.Count != 0)
        {
            int index = turn.Dequeue();
            
            result.Add(index);

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && list[index, i] != 0)
                {
                    visited[i] = true;
                    turn.Enqueue(i);
                }
            }
        }

        return result;
    }

    public void DFS(int from)
    {
        DFS(from, new bool[n]);
    }

    private void DFS(int from, bool[] visited)
    {
        visited[from] = true;

        Console.WriteLine(from);

        for (int i = 0; i < n; i++)
        {
            if (list[from, i] != 0 && !visited[i])
            {
                DFS(i, visited);
            }
        }
    }

    public void DFSNoRecurcion(int from)
    {
        bool[] visited = new bool[n];
        Stack<int> stack = new Stack<int>();
        
        stack.Push(from);
        visited[from] = true;

        while (stack.Count != 0)
        {
            int index = stack.Pop();

            Console.WriteLine(index);

            for (int i = n; i > 0; i--) //проверить и вернуть как было
            {
                if (!visited[i] && list[index, i] != 0)
                {
                    stack.Push(i);
                    visited[i] = true;
                }
            }
        }
    }

    public IList<int> DFSToList(int from)
    {
        bool[] visited = new bool[n];
        Stack<int> stack = new Stack<int>();
        IList<int> result = new List<int>();

        stack.Push(from);
        visited[from] = true;

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

































}