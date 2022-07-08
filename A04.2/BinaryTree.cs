using System.Collections;

namespace A04._2;

public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
{
    private BinaryTreeNode<T> _head;
    private int _count;

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

        else
        {
            if (node.Right == null)
            {
                node.Right = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(node.Right, value);
            }
        }
    }

    public int Count
    {
        get { return _count; }
    }

    /*
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
*/
    public BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
    {
        BinaryTreeNode<T> current = _head;
        parent = null;

        while (current != null)  //метод возвращает -1 если куррент меньше вэлью
                                 //                  0 если равны
                                 //                  1 если куррент больше вэлью
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

    public bool Contains(T value)
    {
        BinaryTreeNode<T> parent;
        return FindWithParent(value, out parent) != null;
    }

    public void InOrderTraversal()
    {
        InOrderTraversal(_head);
    }

    private void InOrderTraversal(BinaryTreeNode<T> node)
    {
        if (node.Left != null)
            InOrderTraversal(node.Left);

        Console.Write(node.Value + "  ");

        if (node.Right != null)
        {
            InOrderTraversal(node.Right);
        }
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

        Console.Write(node.Value + "  ");
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversal(_head);
    }

    private void PreOrderTraversal(BinaryTreeNode<T> node)
    {
        Console.Write(node.Value + "  ");
        
        if (node.Left!=null)
            PreOrderTraversal(node.Left);

        if (node.Right != null)
            PreOrderTraversal(node.Right);
    }
   
    public IEnumerator<T> GetEnumerator()
    {
        BinaryTreeNode<T> current = _head;

        while (current != null)
        {
            yield return current.Value;
            current = Method(current);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<T>)this).GetEnumerator();
    }

    private BinaryTreeNode<T> Method(BinaryTreeNode<T> node)
    {
        if (node.Left != null)
        {
            Method(node.Left);
        }
        
        if (node.Right != null)
        {
            Method(node.Right);
        }
        
        return (node);

    }
}


