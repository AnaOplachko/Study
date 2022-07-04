using System.Threading.Channels;

namespace MyNamespace
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("here we are");
        }
    }
}

namespace OOP_18._1
{
    using MyNamespace;
    
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.Method();
            
        }
    }
}

