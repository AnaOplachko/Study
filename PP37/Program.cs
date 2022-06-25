namespace PP37
{
    class Program
    {
        public static int CalculateSum(int a, int b, int c)
        {
            Console.WriteLine("Первый метод");
          return  a + b + c;
        }

        public static int CalculateIncrementSum(ref int a, ref int b, ref int c)
        {
            Console.WriteLine("Второй метод");
            a++;
            b++;
            c++;
            return a + b + c;
        }

        public static int CalculateSomething(int a, int b, int c, bool isTrue)
        {
            Console.WriteLine("Третий метод");
            var sum = 0;
            if (isTrue == true)
                sum = CalculateSum(a, b, c);
            else
                sum = CalculateIncrementSum(ref a, ref b, ref c);
            return sum;
        }
        
        static void Main()
        {
            Console.Write("First number = ");
            var firstNumAsString = Console.ReadLine();
            var firstNum = Convert.ToInt32(firstNumAsString);

            Console.Write("Second number = ");
            var secondNumAsString = Console.ReadLine();
            var secondNum = Convert.ToInt32(secondNumAsString);
            
            Console.Write("Third number = ");
            var thirdNumAsString = Console.ReadLine();
            var thirdNum = Convert.ToInt32(thirdNumAsString);
            
            Console.WriteLine("Yes/No: ");
            var userRequest = Console.ReadLine();
            
            bool isTrue = userRequest == "Yes";

            int summary;
            summary = CalculateSomething(firstNum, secondNum, thirdNum, isTrue);
            
                Console.WriteLine(summary);
            


        }
    }
}