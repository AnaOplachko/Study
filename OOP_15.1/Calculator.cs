namespace OOP_15._1;

public class Calculator
{
    private double firstNum;
    private double secondNum;
    private string arithmeticMethod;

    public Calculator(double a, double b, string method)
    {
        firstNum = a;
        secondNum = b;
        arithmeticMethod = method;
    }

    int result;
    public double Calculate()
    {
        switch (arithmeticMethod)
        {
            case "Add":
                return firstNum + secondNum;

            case "Sub":
                return firstNum - secondNum;

            case "Mul":
                return firstNum * secondNum;

            case "Div":
            {
                try
                {
                   result = (int)firstNum / (int)secondNum; //double пох, он смекает как делить на бесконечно малые числа
                   return firstNum / secondNum;
                }
                catch (Exception e)
                {
                    Console.WriteLine("AyAyAy");
                    Console.WriteLine(e);
                    throw;
                }
                
                
            
                
            }
                
    
            default: return 0;
        }
    }
}