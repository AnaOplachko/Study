namespace A02._3;

class PriorityQueue
{
  private Queue<string>[] arrayList;
  private int n;

  public PriorityQueue(int n)
  {
    arrayList = new Queue<string>[n];
    this.n = n;

    for (int i = 0; i < n; i++)
    {
      arrayList[i] = new Queue<string>();
    }
  }

  public void Add(string task, int priority)
  {
    arrayList[priority - 1].Enqueue(task);
  }

  public void Show()
  {
    for (int i = 0; i < n; i++)
    {
      foreach (var item in arrayList[i])
      {
        Console.WriteLine(item);
      }
    }
  }
}