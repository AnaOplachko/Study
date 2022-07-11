namespace MyNamespace;

class Graph
{
    private int[,] array;
    private int n;

    public Graph(int[,] array)
    {
        this.array = array;
        n = array.GetLength(0);
    }
    
    public void DFS(int from)
    {
        DFS(from, new bool[n]);
    }

    private void DFS(int from, bool[] visited)
    {
        visited[from] = true;

        Console.WriteLine(from + 1);

        for (int i = 0; i < n; i++)
        {
            if (!visited[i] && array[from, i] != 0)
            {
                DFS(i, visited);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 },  
            { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1 },
            { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }
        };

        Graph graph = new Graph(array);
        
        graph.DFS(0);
    }
    
            /*{ 0, 1, 1, 0, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 1, 1, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0 }
*/}