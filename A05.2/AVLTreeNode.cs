namespace A05._2;

public class AVLTreeNode<TNode> : IComparable<TNode> where TNode : IComparable
{
    private AVLTreeNode<TNode> _left;
    private AVLTreeNode<TNode> _right;
    private AVLTree<TNode> _tree;
    
    #region Balance

    enum TreeState
    {
        Balanced,
        LeftHeavy,
        RightHeavy
    }
    
    internal void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactor < 0)
                {
                    LeftRightRotation();
                }
    
                else
                {
                    LeftRotation();
                }
            }
            
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactor > 0)
                {
                    RightLeftRotation();
                }
    
                else
                {
                    RightRotation();
                }
            }
        }

    #endregion

    #region ReplaceRoot

    private void ReplaceRoot(AVLTreeNode<TNode> newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
            }
            else
            {
                _tree.Head = newRoot;
            }
    
            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }

    #endregion

    #region LeftRotation

    private void LeftRotation()
        {
            AVLTreeNode<TNode> newRoot = Right;
            ReplaceRoot(newRoot);
    
            Right = newRoot._left;
            newRoot._left = this;
        }

    #endregion

    #region RightRotation

    private void RightRotation()
        {
            AVLTreeNode<TNode> newRoot = Left;
            ReplaceRoot(newRoot);
    
            Left = newRoot.Right;
            newRoot.Right = this;
        }

    #endregion

    #region LeftRightRotation

    private void LeftRightRotation()
        {
            Right.RightRotation();
            LeftRotation();
        }

    #endregion

    #region RightLeftRotation

    private void RightLeftRotation()
        {
            Left.LeftRotation();
            RightRotation();
        }

    #endregion

    #region MaxChildHeight

    private int MaxChildHeight(AVLTreeNode<TNode> node)
    {
        if (node != null)
        {
            return 1 + Math.Max(MaxChildHeight(node._left), MaxChildHeight(node._right));
        }

        return 0;
    }

    #endregion

    #region LeftHeight

    private int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }

    #endregion

    #region RightHeight

    private int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

    #endregion

    #region State

    private TreeState State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeState.LeftHeavy;
                }
    
                if (RightHeight - LeftHeight > 1)
                {
                    return TreeState.RightHeavy;
                }
    
                return TreeState.Balanced;
            }
        }

    #endregion

    #region BalanceFactor

    private int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }

    #endregion
    

    public TNode Value
    {
        get;
        private set;
    }

    public AVLTreeNode<TNode> Parent
    {
        get;
        internal set;
    }

    public AVLTreeNode(TNode value, AVLTreeNode<TNode> parent, AVLTree<TNode> tree)
    {
        Value = value;
        Parent = parent;
        _tree = tree;
    }

    public int CompareTo(TNode other)
    {
        return Value.CompareTo(other);
    }

    public AVLTreeNode<TNode> Left
    {
        get
        {
            return _left;
        }
        
        internal set
        {
            _left = value;
            
            if (_left != null)
            {
                _left.Parent = this;
            }
        }
    }
    
    public AVLTreeNode<TNode> Right
    {
        get
        {
            return _right;
        }
        
        internal set
        {
            _right = value;
            
            if (_right != null)
            {
                _right.Parent = this;
            }
        }
    }
    
}