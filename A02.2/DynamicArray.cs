namespace A02._2;

public class DynamicArray<T>
{
    private T[] data;
    private int count;

    public DynamicArray() :
        this(4)
    {
    }

    public DynamicArray(int size)
    {
        data = new T[size];
        count = 0;
    }

    public void Resize()
    {
        int capacity = data.Length == 0 ? 4 : data.Length * 2;

        T[] newArray = new T [capacity];

        data.CopyTo(newArray, 0);

        data = newArray;
    }

    public void DynamicResize() //в рамках дз уменьшаю размер при необходимости
    
    {
        int capacity = data.Length / 2;
        
        T[] newArray = new T [capacity];

        for (int i = 0; i < capacity; i++)
        {
            newArray[i] = data[i];
        }
        
       data = newArray;
    }
    public bool IsFull()
    {
        return count == data.Length;
    }

    public void Add(T item)
    {
        if(this.IsFull())
            this.Resize();

        data[count++] = item;
    }

    public void Insert(T item, int index)
    {
        if (index > count)
            return;
        if(this.IsFull())
            this.Resize();
        
        Array.Copy(data, index, data, index + 1, count - index);
        data[index] = item;

        count++;
    }

    public void RemoveAt(int index)
    {
        int shiftStart = index + 1;

        if (index < count)
        {
            Array.Copy(data, shiftStart, data, index, count - shiftStart);
        }

        count--;
        data[count] = default(T);
    }
    
    public void DynamicRemoveAt(int index)  //в рамках дз для уменьшения размера массива
    {
        int shiftStart = index + 1;

        if (index < count)
        {
            Array.Copy(data, shiftStart, data, index, count - shiftStart);
        }

        count--;
        data[count] = default(T);

        if (count <= data.Length / 2)
        {
            this.DynamicResize();
        }
        
    }
    
    public bool Remove(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (data[i].Equals(item))
            {
                RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (data[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) != -1;
    }

    public void Show()
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(data[i] + " ");
        }
    }

    public void Capacity()
    {
        Console.WriteLine("\nCount = " + count);
        Console.WriteLine("Capacity = " + data.Length);
    }
}