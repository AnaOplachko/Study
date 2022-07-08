namespace A02._1;

class Program
{
    static void Main()
    {
        SimpleQueue<String> queue = new SimpleQueue<string>();
        
        queue.Enqueque("Hello");
        queue.Enqueque("world");
        queue.Enqueque("!!!!!");

        Console.WriteLine(queue.DequequeLast());
        Console.WriteLine(queue.DequequeLast());
    }
}
