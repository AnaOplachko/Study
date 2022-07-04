namespace OOP_15._3
{
    static class ExtensionClass
    {
        public static Price[] SortArrayByName(this Price[] staff)
        {
            
            for (int i = 0; i < staff.Length - 1; i++)
            {
                for (int j = i + 1; j < staff.Length; j++)
                {
                    if (String.Compare(staff[i].Store, staff[j].Store) == 1)
                    {
                        (staff[i].Store, staff[j].Store) = (staff[j].Store, staff[i].Store);

                        (staff[i].ProductName, staff[j].ProductName) = (staff[j].ProductName, staff[i].ProductName);

                        (staff[i].ProductPrice, staff[j].ProductPrice) = (staff[j].ProductPrice, staff[i].ProductPrice);
                    }
                }
            }
            
            return staff;
        }
    }
    
    struct Price
    {
        public string Store { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public Price(string store, string product, int price)
        {
            Store = store;
            ProductName = product;
            ProductPrice = price;
        }
        
        public override string ToString()
        {
            return string.Format("Store: {0}, Goods: {1}, Price: {2}", this.Store, this.ProductName, this.ProductPrice);
        }
    }
    class Program
    {
        
        static void Main()
        {
            var storeQuantity = 2;
            
            Price record = new Price();
            List <Price> priceList= new List<Price>();
            
            for (int i = 0; i < storeQuantity; i++)
            {
                Console.Write("Store: ");
                var store = Console.ReadLine();

                for (int j = 0; j < 1; j++)                     //dowhile
                {
                    Console.Write("Product: ");
                    var product = Console.ReadLine();

                    Console.Write("Price: ");
                    var priceAsString = Console.ReadLine();
                    var price = Convert.ToInt32(priceAsString);

                    record = new Price(store, product, price);
                    priceList.Add(record);
                    
                    Console.Write("Add more goods in store {0}? (yes/no): ", store);
                    var needMoreProducts = Console.ReadLine();

                    if (needMoreProducts == "yes")
                    {
                        j--;
                    }
                }
            }
            
            Console.WriteLine("\nBefore sort\n");

            foreach (var position in priceList)
            {
                Console.WriteLine(position);
            }

            var elementsNum = priceList.Count;                      //linq
            
            Price[] priceListAsArray = new Price[elementsNum];
            priceListAsArray = priceList.ToArray();

            priceListAsArray = priceListAsArray.SortArrayByName();      //linq

            Console.WriteLine("\nAfter sort\n");
            
            for (int i = 0; i < priceListAsArray.Length; i++)
            {
                Console.WriteLine(priceListAsArray[i]);
            }

            while (true)
            {
                Console.Write("\nWhich store? ({0}/{1}): ", priceListAsArray[0].Store, priceListAsArray[elementsNum-1].Store);
                var userStoreRequest = Console.ReadLine();

                try
                {
                    bool isCorrect = userStoreRequest != priceListAsArray[0].Store ||
                                     userStoreRequest != priceListAsArray[elementsNum - 1].Store;
                    if (isCorrect == false)
                    {
                        throw new ArgumentException(paramName: nameof(userStoreRequest),
                            message: "no store like this");
                    }
                        
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }

                for (int i = 0; i < elementsNum-1; i++)
                {
                    if (priceListAsArray[i].Store == userStoreRequest)
                        Console.WriteLine(priceListAsArray[i]);
                }

            }
            
        }
    }
   /* class Program
    {
        static void ProcessString(string s)
        {
            if (s == "оплачко")
            {
                Console.WriteLine("i here");
                throw new ArgumentNullException(paramName: nameof(s), message: "parametr cant be null");
            }
        }
        
        static void Main()
        {
            string s = null;

            s = Console.ReadLine();

            try
            {
                ProcessString(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }*/
}

//если такого магазина нет то вывести исключение.