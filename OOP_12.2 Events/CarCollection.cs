namespace OOP_12._2_Events;

public class CarCollection<T> where T : Car
{
    private T[] _listAsArray = new T[4];
    private int _counter;

    public event Action NewAutoEvent = null;

    public void InvokeNewAutoEvent()
    {
        NewAutoEvent.Invoke();
    }

    public int Count
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
            Console.WriteLine("мы добавили {0}  {1} года типа {2}", listItem.CarModel, listItem.CarYear, listItem.GetType());
            _counter++;
            return;
        }
            
        Array.Resize(ref _listAsArray, _listAsArray.Length * 2);
        _listAsArray[_counter] = listItem;
        Console.WriteLine("мы увеличели коллекцию в два раза и добавили {0} {1} года типа {2}", listItem.CarModel, listItem.CarYear, listItem.GetType());
        _counter++;
    }
    
    public void Show()
    {
        for (int i = 0; i < _listAsArray.Length; i++)
            if (_listAsArray[i] != null)
                Console.WriteLine("{0}. {1}, {2} года", i + 1, _listAsArray[i].CarModel, _listAsArray[i].CarYear);
    }

}