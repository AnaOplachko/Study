namespace A02._1;

public class SimpleQueue<T>
{
    private class Node
    {
        public T data { get; set; }
        public Node next { get; set; }

        public Node (T data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public SimpleQueue()
    {
        head = tail = null;
        count = 0;
    }

    public void Enqueque(T item)
    {
        if (tail == null)
        {
            head = tail = new Node(item, null);
        }
        else
        {
            tail.next = new Node(item, null);
            tail = tail.next;
        }

        count++;
    }

    public T Peek()
    {
        if (head == null)
        {
            return default(T);
        }

        return head.data;
    }
    
    public T Dequeue()         //count?
    {
        if (head == null)
        {
            return default(T);
        }

        T result = head.data;
        head = head.next;
        return result;
    }

    public T DequequeLast()
    {
        if (head == null)
        {
            return default(T);
        }

        T result = tail.data;   //не понимаю как этого добиться без введения свойства previous
        tail = null;
        return result;
    }

    
    
    //DequeueLast()
    //DequeueFirst()    //какой смысл, если это реализуется стандартным алгоритмом деке?
    
    
}