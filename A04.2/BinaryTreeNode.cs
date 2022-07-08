namespace A04._2;

public class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
{
    public BinaryTreeNode(TNode value)
    {
        Value = value;
    }

    public BinaryTreeNode<TNode> Left
    {
        get;
        set;
    }

    public BinaryTreeNode<TNode> Right
    {
        get;
        set;
    }

    public TNode Value
    {
        get;
        private set;
    }
    
    //метод возвращает -1 если вэлью меньше 
    //                  0 если равны
    //                  1 если вылью больше

    public int CompareTo(TNode other)
    {
        return Value.CompareTo(other);
    }

    public int CompareNode(BinaryTreeNode<TNode> other)
    {
        return Value.CompareTo(other.Value);
    }

}