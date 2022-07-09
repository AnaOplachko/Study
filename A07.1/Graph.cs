namespace A07._1;

public class Graph
{
    private int[,] list;
    private int n;

    public Graph(int n)
    {
        list = new int[n, n];
        this.n = n;
    }
    
    public Graph(int [,] arr)
    {
        list = arr;
        n = arr.GetLength(0);
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

    public void Add(int from, int to, int cost)
    {
        list[from, to] = cost;
    }

    public IList<int> BFS(int from)
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
                if (list[index, i] != 0 && !visited[i])
                {
                    visited[i] = true;
                    turn.Enqueue(i);
                }
            }
        }

        return result;
    }

    public IList<int> DFS(int from)
    {
        bool[] visited = new bool[n];
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
                if (list[index, i] != 0 && !visited[i])
                {
                    visited[i] = true;
                    stack.Push(i);
                }
            }
        }

        return result;
    }

    private bool IsValid(int i, int j, int n, int m)
    {
        return i >= 0 && i < n && j >= 0 && j < m;
    }

    public void DoWave(int[,] arr, int i, int j, int k, int n, int m, Queue<KeyValuePair<int, int>> turn)
    {
        if (IsValid(i - 1, j, n, m) && arr[i - 1, j] == 1)
        {
            arr[i - 1, j] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i - 1, j));
        }

        if (IsValid(i - 1, j + 1, n, m) && arr[i - 1, j + 1] == 1)
        {
            arr[i - 1, j + 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i - 1, j + 1));
        }

        if (IsValid(i, j + 1, n, m) && arr[i, j + 1] == 1)
        {
            arr[i, j + 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i, j + 1));
        }

        if (IsValid(i + 1, j + 1, n, m) && arr[i + 1, j + 1] == 1)
        {
            arr[i + 1, j + 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i + 1, j + 1));
        }

        if (IsValid(i + 1, j, n, m) && arr[i + 1, j] == 1)
        {
            arr[i + 1, j] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i + 1, j));
        }

        if (IsValid(i + 1, j - 1, n, m) && arr[i + 1, j - 1] == 1)
        {
            arr[i + 1, j - 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i + 1, j - 1));
        }

        if (IsValid(i, j - 1, n, m) && arr[i, j - 1] == 1)
        {
            arr[i, j - 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i, j - 1));
        }

        if (IsValid(i - 1, j - 1, n, m) && arr[i - 1, j - 1] == 1)
        {
            arr[i - 1, j - 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i - 1, j - 1));
        }
    }

    public void Wave(int[,] arr, int x, int y, int n, int m)
    {
        if (arr[x, y] == 0)
            return;

        int k = 2;

        arr[x, y] = k;

        Queue<KeyValuePair<int, int>> turn = new Queue<KeyValuePair<int, int>>();
        
        turn.Enqueue(new KeyValuePair<int, int>(x, y));

        while (turn.Count > 0)
        {
            int count = turn.Count;

            k++;

            while (count > 0)
            {
                KeyValuePair<int, int> point = turn.Dequeue();
                int i = point.Key;
                int j = point.Value;

                DoWave(arr, i, j, k, n, m, turn);
                count--;
            }
        }
    }
    
    /*public void DoWaveCheck(int[,] arr, int i, int j, int k, int n, int m, Queue<KeyValuePair<int, int>> turn)
    {
        if (IsValid(i - 1, j, n, m) && arr[i - 1, j] == 1)
        {
            arr[i - 1, j] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i - 1, j));
        }

        if (IsValid(i - 1, j + 1, n, m) && arr[i - 1, j + 1] == 1)
        {
            arr[i - 1, j + 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i - 1, j + 1));
        }

        if (IsValid(i, j + 1, n, m) && arr[i, j + 1] == 1)
        {
            arr[i, j + 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i, j + 1));
        }

        if (IsValid(i + 1, j + 1, n, m) && arr[i + 1, j + 1] == 1)
        {
            arr[i + 1, j + 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i + 1, j + 1));
        }

        if (IsValid(i + 1, j, n, m) && arr[i + 1, j] == 1)
        {
            arr[i + 1, j] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i + 1, j));
        }

        if (IsValid(i + 1, j - 1, n, m) && arr[i + 1, j - 1] == 1)
        {
            arr[i + 1, j - 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i + 1, j - 1));
        }

        if (IsValid(i, j - 1, n, m) && arr[i, j - 1] == 1)
        {
            arr[i, j - 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i, j - 1));
        }

        if (IsValid(i - 1, j - 1, n, m) && arr[i - 1, j - 1] == 1)
        {
            arr[i - 1, j - 1] = k;
            turn.Enqueue(new KeyValuePair<int, int>(i - 1, j - 1));
        }
    }*/

    public bool CheckPath(int[,] array, int x1, int y1, int x2, int y2, int n, int m)
    {
        if (array[x1, y1] == 0 || array[x2, y2] == 0)
            return false;

        int k = 2;
        
        array[x1, y1] = k;

        Queue<KeyValuePair<int, int>> path = new Queue<KeyValuePair<int, int>>();

        path.Enqueue(new KeyValuePair<int, int>(x1, y1));

        while (path.Count > 0)
        {
            int count = path.Count;

            k++;

            while (count > 0)
            {
               KeyValuePair<int, int> point = path.Dequeue();
               int i = point.Key;
               int j = point.Value;

               DoWave(array, i, j, k, n, m, path);
               count--;
            }
        }

        return array[x2, y2] > 1 ;
    }

    public void FindShortestPathWithWave(int start, int finish)
    {
        int index = start;
        int distance = int.MaxValue;

        Queue<int> path = new Queue<int>();
        Queue<int> result = new Queue<int>();
        result.Enqueue(index);
        path.Enqueue(index);

        while (path.Count > 0)
        {
            
            for (int i = 0; i < 8; i++)
            {
                if (list[index, i] > 0)
                {
                    if (distance < list[index, i])
                    {
                        distance = list[index, i];
                    }
                }
            }
        }
        
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}