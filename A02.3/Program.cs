namespace A02._3;

class Program
{
    static void Main()
    {
        PriorityQueue taskList = new PriorityQueue(4);
        
        taskList.Add("first task p1", 1);
        taskList.Add("second task p1", 1);
        taskList.Add("first task p2", 2);
        taskList.Add("third task p1", 1);
        
        taskList.Show();
    }
}
