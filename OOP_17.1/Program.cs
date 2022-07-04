using System.Net.Sockets;

namespace OOP_17._1
{
    class Calculator
    {
        private dynamic _firstNum;
        private dynamic _secondNum;

        public Calculator(dynamic a, dynamic b)
        {
            _firstNum = a;
            _secondNum = b;
        }

        public dynamic Add()
        {
            return _firstNum + _secondNum;
        }

        public dynamic Subtract()
        {
            return _firstNum - _secondNum;
        }

        public dynamic Multiply()
        {
            return _firstNum * _secondNum;
        }

        public dynamic Div()
        {
            return _firstNum / _secondNum;
        }
        
        
    }
    
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("1 num: ");
                var firstNumAsString = Console.ReadLine();
                var firstNum = Convert.ToInt32(firstNumAsString);   //что бы не ввел все будет стрингом((
                
                Console.Write("2 num: ");
                var secondNumAsString = Console.ReadLine();
                var secondNum = Convert.ToInt32(secondNumAsString);

                Calculator calculator = new Calculator(firstNum, secondNum);

                Console.WriteLine("{0} + {1} = {2}\n", firstNum, secondNum, calculator.Add());
                Console.WriteLine("{0} - {1} = {2}\n", firstNum, secondNum, calculator.Subtract());
                Console.WriteLine("{0} * {1} = {2}\n", firstNum, secondNum, calculator.Multiply());
                Console.WriteLine("{0} / {1} = {2}\n", firstNum, secondNum, calculator.Div());

            }
            
        }
    }
}

