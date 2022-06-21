namespace OOP_07._1
{
    struct Notebook
    {
        public string model;
        public string brand;
        public string price;

        public Notebook(string brand, string model, string price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine("Мой ноутбук фирмы {0}, модели {1} за {2} рублев", brand, model, price);
        }
    }

    class  Program
    {
        static void Main()
        {
            Notebook myNotebook = new Notebook("Apple", "MacBookPro14,3", "78 тысяч");
            
            myNotebook.Show();

        }
    }
} 


