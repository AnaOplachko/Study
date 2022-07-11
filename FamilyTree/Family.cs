using System.Threading.Channels;

namespace FamilyTree;

public class Family
{
    private int[,] familyLinks;
    private int n;
    private List<Person> familyMembers;

    public Family(int[,] array, List <Person> familyMembers)
    {
        familyLinks = array;
        n = array.GetLength(0);
        this.familyMembers = familyMembers;
    }

    private int sumAge;
    public int GetSumAgeDFS(Person current)
    {
        GetSumAgeDFS(current, new bool[n]);
        return sumAge;
    }

    private void GetSumAgeDFS(Person current, bool[] visited)
    {
        visited[current.Index] = true;
        int index = current.Index;
        sumAge += current.Age;
        
        Console.WriteLine(current.Name);
        
        for (int i = 0; i < n; i++)
        {
            if (!visited[i] && familyLinks[index,i] != 0)
            {
                foreach (var member in familyMembers)
                {
                    if (member.Index == i)
                    {
                        current = member;
                    }
                }

                GetSumAgeDFS(current, visited);
            }
        }
    }

   public int GetSumAgeDFSNoRecurcion(Person current)
    {
        bool[] visited = new bool [n];
        Stack<Person> stack = new Stack<Person>();
        
        stack.Push(current);
        visited[current.Index] = true;
        int sumAge = current.Age;

        while (stack.Count != 0)
        {
            var person = stack.Pop();
            int index = person.Index;
            Console.WriteLine(person.Name);

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && familyLinks[index, i] != 0)
                {
                    foreach (var member in familyMembers)
                    {
                        if (member.Index == i)
                        {
                            current = member;
                        }
                    }
                    stack.Push(current);
                    visited[i] = true;
                    sumAge += current.Age;
                }
            }
        }

        return sumAge;
    } 

    public int GetSumAgeBFSNoRecurcion(Person current)
    {
        bool[] visited = new bool [n];
        Queue<Person> queue = new Queue<Person>();
        Person person;
        
        queue.Enqueue(current);
        visited[current.Index] = true;
        int sumAge = current.Age;

        while (queue.Count != 0)
        {
            person = queue.Dequeue();
            int index = person.Index;

            Console.WriteLine(person.Name);

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && familyLinks[index, i] != 0)
                {
                    foreach (var member in familyMembers)
                    {
                        if (member.Index == i)
                        {
                            current = member;
                        }
                    }

                    visited[i] = true;
                    queue.Enqueue(current);
                    sumAge += current.Age;
                    
                }
            }
        }
        
        return sumAge;
    }  
}