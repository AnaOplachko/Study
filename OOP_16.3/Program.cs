using System.Security.Cryptography;

namespace OOP_16._3
{
    public class House
    {//два поля
        //свойства
        private int index;
        private string adress;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public House()
        {
            
        }

        public override string ToString()
        {
            return string.Format("Индекс: {0}, Адрес: {1}", this.index, this.adress);
        }
       
        public House Clone(House lightHouse)
        {
            return lightHouse;
        }

        public House DeepClone(House deepHouse)
        {
            return deepHouse.MemberwiseClone() as House;
        }

    }


    class Program
    {
        
        static void Main()
        {
            House original = new House();
            original.Index = 655619;
            original.Adress = "Cheremushki 5 / 21";

            Console.WriteLine(original);

            House clone = new House();
            clone = clone.Clone(original);

            
            House deepCloneHouse = new House();
            deepCloneHouse = deepCloneHouse.DeepClone(original);
            
            Console.WriteLine("here we are");
            Console.WriteLine("original: {0}", original);
            Console.WriteLine("clone: {0}", clone);
            Console.WriteLine("deepCloneHouse: {0}", deepCloneHouse);

            Console.ReadLine();
            
            original.Index = 1;
            original.Adress = "moscowNeverSleep";
            
            Console.WriteLine("we change smth");
            Console.WriteLine("original: {0}", original);
            Console.WriteLine("clone: {0}", clone);
            Console.WriteLine("deepCloneHouse: {0}", deepCloneHouse);

        }
        
        
    }
}

