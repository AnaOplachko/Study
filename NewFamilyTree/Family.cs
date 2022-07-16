namespace NewFamilyTree;

public class Family
{
    private SocialUnit _head;
    private int _count;

    public void Add(SocialUnit unit)
    {
        _count++;
        
        if (_head == null)
            _head = unit;
        AddTo(_head, unit);
    }

    private void AddTo(SocialUnit parents, SocialUnit unit)
    {
        if (parents.Children[0] == unit || parents.Children[1] == unit)
        {
            
        }
    }
    
    
}