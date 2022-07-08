namespace A02._3;

public class SimpleQueue<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }
        public int Priority { get; set; }

        public Node (T data, Node next, int priority)
        {
            Data = data;
            Next = next;
            Priority = priority;
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

    public void Enqueque(T item, int priority)
    {
        if (tail == null)
        {
            head = tail = new Node(item, null, priority);
        }
        else
        {
            if ()
            
            tail.Next = new Node(item, null);
            tail = tail.Next;
        }

        count++;
    }

    public T Peek()
    {
        if (head == null)
        {
            return default(T);
        }

        return head.Data;
    }
    
    public T Dequeue()         //count?
    {
        if (head == null)
        {
            return default(T);
        }

        T result = head.Data;
        head = head.Next;
        return result;
    }

    
/*
 Реализуйте очередь с приоритетами. В качестве примера используйте список задач работника –
когда он заканчивает одну задачу, он переходит к следующей (самой приоритетной). Начальник,
добавляя элемент в очередь, указывает ее приоритет. По сравнению с обычной очередью,
каждый элемент такой очереди будет иметь свой приоритет.
 
 */

    
}