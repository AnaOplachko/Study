namespace A04._1;

public class HashTable<TKey, TValue>
{
    private LinkedList<HashTableItem<TKey, TValue>>[] _array;
    private int _size;
    private int _capacity;
    private const double LoadFactor = 0.75;

    public HashTable(int size)
    {
        _capacity = size;
        _array = new LinkedList<HashTableItem<TKey, TValue>>[_capacity];
    }

    private int hash(TKey key)
    {
        return Math.Abs(key.GetHashCode()) % _capacity;
        
        //return ((Math.Abs(key.GetHashCode()) << 5) + 13) % _capacity;
        //return (int)Math.Floor((Math.Abs(key.GetHashCode()) * 0.13 % 1) * _capacity;
    }

    private double GetLoadFactor()
    {
        return _size / _capacity;
    }
    private void Resize()
    {
        _capacity = _capacity * 2 + 1;
        var oldArr = _array;
        _size = 0;
        _array = new LinkedList<HashTableItem<TKey, TValue>>[_capacity];

        foreach (var list in oldArr)
        {
            if (list != null)
            {
                foreach (var pair in list)
                {
                    if (pair != null)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }
    }
    public void Add(TKey key, TValue value)
    {
        if (GetLoadFactor() >= LoadFactor)
            this.Resize();

        int index = hash(key);

        {
            if (_array[index] == null)
            {
                _array[index] = new LinkedList<HashTableItem<TKey, TValue>>();
            }

            var hashTableItem = new HashTableItem<TKey, TValue>(key, value);

            var listNode = new LinkedListNode<HashTable<TKey, TValue>>(hashTableItem);

            _array[index].AddFirst(listNode);

            _size++;
        }
    }

    public TValue GetValue(TKey key)
    {
        int index = hash(key);

        if (_array[index] == null)
        {
            return default(TValue);
        }

        foreach (var item in _array[index])
        {
            if (item.Key.Equals(key))
            {
                return item.Value;
            }
        }

        return default(TValue);
    }

    public bool Remove(TKey key)
    {
        int index = hash(key);

        if (_array[index] == null)
            return false;

        foreach (var item in _array[index])
        {
            if (_array[index].Equals(key))
            {
                _array[index].Remove(item);
                break;
            }
        }

        return true;
    }

    public void Clear()
    {
        _size = 0;
        _array = new LinkedList<HashTableItem<TKey, TValue>>[_capacity];
    }
}