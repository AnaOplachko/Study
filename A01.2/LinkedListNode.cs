namespace A01._2;

public class LinkedListNode<T>
{
    public LinkedListNode(T value)
    {
        Value = value;
    }

    public T Value
    {
        get;
        internal set;
    }

    public LinkedListNode<T> Next
    {
        get;
        internal set;
    }

    public LinkedListNode<T> Previous
    {
        get;
        internal set;
    }
}