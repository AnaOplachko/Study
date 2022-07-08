namespace A02._3;

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
        
        
        //очередь из очередей с каждым приоритетом
        //массив очередей
    }
}
