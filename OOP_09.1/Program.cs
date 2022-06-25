namespace OOP_09._1

{
    public delegate double MyDelegate(int a, int b, int c);
    class Program
    {
        static void Main()
        {
            // MyDelegate myDelegate = delegate(int a, int b, int c) { return (a + b + c) / 3; };
            //average = myDelegate(firstNumber, secondNumber, thirdNumber);

            MyDelegate myDelegate;
            
            //особенность си шарпа, нужно избавляться от интов.
            myDelegate = (firstNumber, secondNumber, thirdNumber) => (firstNumber + secondNumber + thirdNumber) / 3;
            var average = myDelegate(1, 3, 1);

            //double average = (1 + 3 + 1) / 3;
            
            Console.WriteLine("Average = {0:F2}", average);
        }
    }
}