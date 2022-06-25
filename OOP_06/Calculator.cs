namespace OOP_06;

public static class Calculator
{
    static Calculator()
    {
        Console.WriteLine("я работаю");   
    }
    
    public static int GetSum(int addend1, int addend2)
    {
        return addend1 + addend2;
    }

    public static int GetSub(int minuend, int subtracted)
    {
        return minuend - subtracted;
    }

   public static int GetMul(int multiplicanda, int multiplier)
   {
       return multiplicanda * multiplier;
   }

    public static int GetDiv(int dividiend, int divisor)
    {
        return dividiend / divisor;
    }
}