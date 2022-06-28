namespace OOP_10._2;

public class MyList<T>
{
    private T[] _listAsArray = new T[4];
    private int _counter;

    public int Counter
    {
        get
        {
            return _counter;
        } 
    }
    
    public T this[int index]
    {
        get
        {
            return _listAsArray[index];
        }
        set
        {
            _listAsArray[index] = value;
        }
    }
    
    public void Add(T listItem)
    {
        if (_counter < _listAsArray.Length)
        {
            _listAsArray[_counter] = listItem;
            Console.WriteLine("мы добавили {0} типа {1}", listItem, listItem.GetType());
            _counter++;
            return;
        }
        
        Array.Resize(ref _listAsArray, _listAsArray.Length * 2); 
        _listAsArray[_counter] = listItem;
        Console.WriteLine("мы увеличели лист в два раза и добавили {0} типа {1}", listItem, listItem.GetType());
        _counter++;
    }
    
    public void Show()
    {
        for (int i = 0; i < _listAsArray.Length; i++)
            if (_listAsArray[i] != null)
                Console.WriteLine("{0}. {1}, длина массива {2}", i + 1, _listAsArray[i], _listAsArray.Length);
    }
}
