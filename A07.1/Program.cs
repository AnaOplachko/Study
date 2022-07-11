﻿namespace A07._1;

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 0, 1, 0, 1, 0, 0, 0, 1 },
            { 0, 0, 1, 0, 1, 0, 1, 1 },
            { 1, 1, 0, 0, 1, 0, 0, 1 },
            { 0, 0, 1, 0, 1, 1, 1, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 1, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0 },
            { 1, 0, 0, 1, 1, 0, 1, 1 }
        };

        Graph g = new Graph(array);
        
       g.Wave(array, 0, 7, 8, 8 );

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write("{0} ", array[i,j]);
            }

            Console.WriteLine();
        }

        //реализовать волновой алгоритм для проверки пути между двумя вершинами
        //желательно кратчайший путь

        Console.WriteLine("Cheking path availability");
        
        Console.WriteLine(g.CheckPath(array, 0, 7, 0,0, 8,8));
       
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write("{0} ", array[i,j]);
            }

            Console.WriteLine();
        }
        
        //реализовать поиск кратчайшего пути между двумя вершинами на основе волнового алгоритма
        //метод должен возвращать список вершин, по которым нужно пройти
        //реализовать метод, который подсчитает стоимость прохода между двумф вершинами на базе предыдущего метода
        
        int [,] secondArray = new int[,]
        {
            {  0,  7, -1,  3, -1, -1, -1, -1 },
            {  7,  0,  2,  2, -1, -1, 11, -1 },  
            {  0,  2,  0, -1, 10, -1, -1, -1 },
            {  3,  2, -1,  0, 14,  6, 10, -1 },
            { -1, -1, 10, 14,  0, -1, -1, 15 },
            { -1, -1, -1,  6, -1 , 0,  9, -1 },
            { -1, 11, -1, 10, -1,  9,  0,  3 },
            { -1, -1, -1, -1, 15, -1,  3,  0 }
        };

        Graph g2 = new Graph(secondArray);

        Random random = new Random();
        
        int start = random.Next(0,7);
        int finish = random.Next(0,7);

        Console.WriteLine("start point is {0}, finish point is {1}", start, finish);
        
        g2.FindShortestPathWithWave(start, finish);
        /*задаем матрицу смежности
         задаем точку старта
         задаем точку финиша
         смотрим связи первой точки с остальными требование больше ноля
         рекурсивно ищем путь из следующих точек
         нужен массив посещенных точек
         смысл волнового алгоритма в этом случае теряется*/





    }
}