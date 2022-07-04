namespace OOP_03._1

{
    public class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
        
    }
    public class LaserPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }

    public class Plotter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
    
    class Program
    {
        static void Main()
        {
            string stroka = "ParamPamPam";

            Printer printer = new Printer();
            printer.Print(stroka);
            Console.ReadKey();
            
            Plotter plotter = new Plotter();
            plotter.Print(stroka);
            Console.ReadKey();

            LaserPrinter laserPrinter = new LaserPrinter();
            laserPrinter.Print(stroka);
            
            
        }
    }
}