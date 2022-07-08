using System.ComponentModel;

namespace A05._1;

public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
{
    private BinaryTreeNode<T> _head;

    private int _count;

    public int Count
    {
        get { return _count; }
    }

    public void Add(T value)
    {
        if (_head == null)
        {
            _head = new BinaryTreeNode<T>(value);
        }
        else
        {
            AddTo(_head, value);
        }

        _count++;
    }

    private void AddTo(BinaryTreeNode<T> node, T value)
    {
        if (value.CompareTo(node.Value) < 0)
        {
            if (node.Left == null)
            {
                node.Left = new BinaryTreeNode<T>(value);
            }
            else
            {
            AddTo(node.Left, value);
            }
        }
    }

    public bool Contains (T value)
    {
        BinaryTreeNode<T> parent;
        return FindWithParent(value, out parent) != null;
    }
    private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
    {
        BinaryTreeNode<T> current = _head;
        parent = null;

        while (current != null)
        {
            int result = current.CompareTo(value);

            if (result > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if (result < 0)
            {
                parent = current;
                current = current.Right;
            }
            else
            {
                break;
            }
        }

        return current;
    }

    public bool Remove(T value)
    {
        BinaryTreeNode<T> current;
        BinaryTreeNode<T> parent;

        current = FindWithParent(value, out parent);

        if (current == null)
            return false;

        _count--;

        if (current.Right == null)
        {
            if (parent == null)
            {
                _head = current.Left;
            }
            else
            {
                int result = parent.CompareTo(current.Value);

                if (result > 0)
                    parent.Left = current.Left;
                
                else if (result < 0)
                    parent.Right = current.Left;
            }
        }       //1 нет правого потомка
        
        else if (current.Right.Left == null)    //2 удаляемый узел имеет правого потомка, у которого нет левого потомка
        {
            if (parent == null)
            {
                _head = current.Right;
            }

            else
            {
                int result = parent.CompareTo(current.Value);

                if (result > 0)
                {
                    parent.Left = current.Right;
                }
                
                else if (result < 0)
                {
                    parent.Right = current.Right;
                }
            }
        }

        else           //3 удаляемый узел имеет правого потомка, у которого есть левый потомок
        {
            BinaryTreeNode<T> leftmost = current.Right.Left;
            BinaryTreeNode<T> leftmostParent = current.Right;

            while (leftmost != null)
            {
                leftmostParent = leftmost;
                leftmost = leftmost.Left;
            }

            leftmost.Left = current.Left;
            leftmost.Right = current.Right;

            if (parent == null)
            {
                _head = leftmost;
            }

            else
            {
                int result = parent.CompareTo(current.Value);

                if (result > 0)
                {
                    parent.Left = leftmost;
                }
                else if (result < 0)
                {
                    parent.Right = leftmost;
                }
            }
        }

        return true;
    }

    public void InOrderTraversal()
    {
        InOrderTraversal(_head);
    }

    public void InOrderTraversal(BinaryTreeNode<T> node)
    {
        if (node.Left != null)
            InOrderTraversal(node.Left);

        Console.WriteLine(node.Value);
        
        if (node.Right != null)
            InOrderTraversal(node.Right);
    }

    public void PostOrderTraversal()
    {
        PostOrderTraversal(_head);
    }

    private void PostOrderTraversal(BinaryTreeNode<T> node)
    {
        if (node.Left != null)
            PostOrderTraversal(node.Left);
        
        if (node.Right != null)
            PostOrderTraversal(node.Right);

        Console.WriteLine(node.Value);
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversal(_head);
    }

    private void PreOrderTraversal(BinaryTreeNode<T> node)
    {
        Console.WriteLine(node.Value);
        
        if (node.Left != null)
            PreOrderTraversal(node.Left);
        
        if (node.Right != null)
            PreOrderTraversal(node.Right);
    }
}