using System.Diagnostics;

namespace OOP_15._1

{
 class Program
 {
  static void Main()
  {
   Console.Write("Enter first Num: ");
   var firstNumAsString = Console.ReadLine();
   var firstNum = Convert.ToDouble(firstNumAsString);

   Console.Write("Enter second Num: ");
   var secondNumAsString = Console.ReadLine();
   var secondNum = Convert.ToDouble(secondNumAsString);

   Console.Write("Enter operation (Add/Sub/Mul/Div): ");
   var operation = Console.ReadLine();

   Calculator calculator = new Calculator(firstNum, secondNum, operation);
   
   var result = calculator.Calculate();

   Console.WriteLine("{0} {1} {2} = {3}", firstNum, operation, secondNum, result);
  }
 }
}

