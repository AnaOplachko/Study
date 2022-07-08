using System.Transactions;

namespace A05._1;

public class BinaryTreeNode<TNode> : IComparable <TNode> where TNode : IComparable<TNode> 
{
    public BinaryTreeNode(TNode value)
    {
        Value = value;
    }

    public BinaryTreeNode<TNode> Left { get; set; }

    public BinaryTreeNode<TNode> Right { get; set; }

    public TNode Value { get; private set; }

    public int CompareTo(TNode other)
    {
        return Value.CompareTo(other);
    }

    public int CompareNode (BinaryTreeNode<TNode> other)
    {
        return Value.CompareTo(other.Value);
    }
}