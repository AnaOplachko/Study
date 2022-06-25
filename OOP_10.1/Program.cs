namespace OOP_10._1
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("Создаем экземпляр класса продукт");
        }
    }

    static class Factory<T>
    {
        public static T FactoryMethod()
        {
            return new Product();
        }
    }
    class Program
    {
        static void Main()
        {
            Factory<> factory = new Factory();
            Product product = factory.FactoryMethod();
        }
    }
}

