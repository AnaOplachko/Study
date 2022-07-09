namespace A08
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("get shortest path");
            
            double[,] g = new double[,]
            {
                { 0, 5, 0, 6, 0, 50 },
                { 5, 0, 7, 0, 0, 0 },
                { 0, 7, 0, 4, 0, 10 },
                { 6, 0, 4, 0, 10, 0 },
                { 0, 0, 0, 10, 0, 8 },
                { 50, 0, 10, 0, 8, 0 }
            };

            Graph graph = new Graph(g);

            double[,] dist = graph.GetAllShortestPath();

            Console.WriteLine(dist[0,5]);
            
            //метод подсчитывает взаимосвязанные группы

            double[,] arr = new double[,]
            {
                { 0, 1, 1, 0 },
                { 1, 0, 0, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            Graph graph2 = new Graph(arr);

            var dict = graph2.GetComponents();
            
            //топологическая сортировка
            Console.WriteLine("topological sort");
            
            double[,] arra = {
                { 0, 1, 1, 0, 1 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };

            Graph graph3 = new Graph(arra);

            var list = graph3.TopologicalSort();

            foreach (var item in list)
            {
                Console.Write("{0} ", item + 1);
            }
            
            //задача

            Console.WriteLine("tasks\n");
            
            Console.WriteLine("enter number of tasks n = ");
            var numberOfTasksAsString = Console.ReadLine();
            var numberOfTasks = Convert.ToInt32(numberOfTasksAsString);

            double[,] taskArray = new double[numberOfTasks, numberOfTasks];

            for (int i = 0; i < numberOfTasks; i++)
            {
                for (int j = 0; j < numberOfTasks; j++)
                {
                    taskArray[i, j] = 0;
                }
            }

            Console.WriteLine("enter numbers of links = ");
            var numberOfLinksAsString = Console.ReadLine();
            var numberOfLinks = Convert.ToInt32(numberOfLinksAsString);

            for (int i = 0; i < numberOfLinks; i++)
            {
                Console.WriteLine("enter number of first task: ");
                var firstTaskAsString = Console.ReadLine();
                var firstTask = Convert.ToInt32(firstTaskAsString);

                Console.WriteLine("enter number of second task: ");
                var secondTaskAsString = Console.ReadLine();
                var secondTask = Convert.ToInt32(secondTaskAsString);

                taskArray[firstTask-1,secondTask-1] = 1;
            }

            Console.WriteLine("here we are\n");

            for (int i = 0; i < numberOfTasks; i++)
            {
                for (int j = 0; j < numberOfTasks; j++)
                {
                    Console.Write(taskArray[i,j] + " ");
                }

                Console.WriteLine();
            }

            Graph taskGraph = new Graph(taskArray);

            var taskList = taskGraph.TopologicalSort();

            Console.WriteLine("\nafter sort");
            
            foreach (var item in taskList)
            {
                Console.Write(item+1 + " ");
            }
        }
    }
}

