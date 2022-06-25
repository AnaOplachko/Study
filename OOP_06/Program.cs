namespace OOP_06
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            var firstNumAsString = Console.ReadLine();
            var firstNum = Convert.ToInt32(firstNumAsString);

            Console.Write("Введите второе число: ");
            var secondNumAsString = Console.ReadLine();
            var secondNum = Convert.ToInt32(secondNumAsString);
            

            var sum = Calculator.GetSum(firstNum, secondNum);
            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, sum);

            var res = Calculator.GetSub(firstNum, secondNum);
            Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, res);

            var mul = Calculator.GetMul(firstNum, secondNum);
            Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, mul);

            var div = Calculator.GetDiv(firstNum, secondNum);
            Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, div);

        }
    }
}

