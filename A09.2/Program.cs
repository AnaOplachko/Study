namespace MyNamespace;

class Program
{
    public static int RabbitMoves(int n, int k)
    {
        int[] moves = new int[n + 1];
        moves[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            int start = Math.Max(0, i - k);
            moves[i] = 0;
            for (int j = start; j < i; j++)
            {
                moves[i] += moves[j];
            }
        }

        return moves[n];
    }
    static void Main()
    {
        Console.WriteLine(RabbitMoves(7,2));
    }
}