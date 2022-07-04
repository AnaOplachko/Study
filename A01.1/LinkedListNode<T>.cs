using System.Collections;

namespace A01._1;

public class LinkedListNode<T>
{
    public LinkedListNode(T value)
    {
        Value = value;
    }

    public T Value
    {
        get;
        set;
    }

    public LinkedListNode<T> Next
    {
        get;
        set;
    }
}