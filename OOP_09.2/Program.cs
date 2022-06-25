using System.Diagnostics;
using System.Threading.Channels;

namespace OOP_09._2
{
    public delegate int MyDelegate(int a, int b);
    
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение первого аргумента: ");
            var firstNumberAsString = Console.ReadLine();
            var firstNumber = Convert.ToInt32(firstNumberAsString);

            Console.Write("Введите значение второго аргумента: ");
            var secondNumberAsString = Console.ReadLine();
            var secondNumber = Convert.ToInt32(secondNumberAsString);
            
            Console.Write("Мы умеем Add, Sub, Mul, Div. Какая операция Вас интересует?: ");
            var arithmetics = Console.ReadLine();

            MyDelegate myDelegate;
            int result = 0;

            switch(arithmetics)
            {
                case "Add":
                {
                    myDelegate = (firstAddend, secondAddend) => firstAddend + secondAddend;
                    result = myDelegate(firstNumber, secondNumber);
                    break;
                }
                case "Sub":
                {
                    myDelegate = (minuend, subtracted) => minuend - subtracted;
                    result = myDelegate(firstNumber, secondNumber);
                    break;
                }
                case "Mul":
                {
                    myDelegate = (multiplicanda, multiplier) => multiplicanda * multiplier;
                    result = myDelegate(firstNumber, secondNumber);
                    break;
                }
                case "Div": 
                {
                    myDelegate = (dividend, divisor) =>
                    {
                        if (secondNumber != 0)
                        {
                            myDelegate = (dividend, divisor) => dividend / divisor;
                            result = myDelegate(firstNumber, secondNumber);
                        }
                        else
                        {
                            Console.WriteLine("Сцук не ноль делить нельзя");
                        }
                        return result;
                    };
                    result = myDelegate(firstNumber, secondNumber);
                    break;
                }
                default:
                    Console.WriteLine("Вы ошиблись, такой операции нет(");
                    break;
            }
            Console.WriteLine($"Мы получили = {result}");
        }
    }
}

