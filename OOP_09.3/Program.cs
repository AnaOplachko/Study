namespace OOP_09._3

{
    public delegate int Random ();
    
    public delegate int Average (int[] delegatesArray);

    class RandomNumeros
    {
        public int Randomize()
        {
            System.Random number = new System.Random();
            var randomNum = number.Next(10);
            return randomNum;
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество случайных элементов: ");
            var quantityAsString = Console.ReadLine();
            var quantity = Convert.ToInt32(quantityAsString);
            
            int [] delegatesArray = new int [quantity];
            RandomNumeros randomNumber = new RandomNumeros();
            
            Random randomDelegate = randomNumber.Randomize;

            for (int i = 0; i < quantity; i++)
            {
                delegatesArray[i] = randomDelegate.Invoke(); //это массив делегатов или массив возвращенных значений сообщенных с делегатами методов?
                Console.WriteLine(delegatesArray[i]);
            }

            Average average = delegate(int[] array) 
                { var sum = 0;
                    
                    foreach (var n in array) { sum += n; }
                
                return sum / array.Length; };

            var result = average(delegatesArray);
           
           Console.WriteLine("Среднее значение рандомного массива из {0} элементов = {1}", quantity, result);




           //создать анонимный метод, который принимает в качестве аргументов массив делегатов и
           //возвращает авераж возвращаемых значений методов, сообщенных с делегатами в массиве

           //методы сообщенные с делегатами из массива возвращают случайное значение типа инт



        }
    }
} 

