namespace OOP_12._1_Events
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyQ = null;
        public event PressKeyEventHandler PressKeyS = null;

        public void PressKeyQEvent()
        {
            if (PressKeyQ != null)
            {
                PressKeyQ.Invoke();
            }
        }

        public void PressKeySEvent()
        {
            if (PressKeyS != null)
            {
                PressKeyS.Invoke();   
            }
                
        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();

                switch (s)
                {
                    case "S":
                    case "s":
                        PressKeySEvent();
                        break;

                    case "Q":
                    case "q":
                        PressKeyQEvent();
                        break;

                    default:
                        Console.WriteLine("Нет обрабочика нажатия на клавишу {0}", s);
                        break;
                }
            }
        }

        class Program
        {
            static private void PressKeyQ_Handler()
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine();
                Console.WriteLine("          QQQ              ");
                Console.WriteLine("        Q     Q            ");
                Console.WriteLine("       Q       Q           ");
                Console.WriteLine("      Q         Q          ");
                Console.WriteLine("       Q     q Q           ");
                Console.WriteLine("         Q   Q q           ");
                Console.WriteLine("          QQQ   q q        ");
                Console.WriteLine();
                Console.ForegroundColor = default;
            }

            static private void PressLeyS_Handler()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.WriteLine("          SSS              ");
                Console.WriteLine("       SS     SS           ");
                Console.WriteLine("        SS                 ");
                Console.WriteLine("          SSS              ");
                Console.WriteLine("             SS            ");
                Console.WriteLine("       SS     SS           ");
                Console.WriteLine("          SSS              ");
                Console.WriteLine();
                Console.ForegroundColor = default;

            }

            static void Main()
            {
                Keyboard keybord = new Keyboard();

                keybord.PressKeyQ += PressKeyQ_Handler;
                keybord.PressKeyS += PressLeyS_Handler;
                
                keybord.Start();
                
            }
        }
    }
}