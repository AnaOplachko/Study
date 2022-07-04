namespace MyNamespace
{
    using External_dll;
    public class MyClass
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
    using External_dll;
    
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.Method();

            External_dll.Class1 myClass = new Class1();
            myClass.Show();
        }
    }
}