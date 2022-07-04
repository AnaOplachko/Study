namespace OOP_17._2
{
    public class Car
    {
        public string carBrand { get; set; }
        public string carModel { get; set; }
        public int carYear { get; set; }
        public string carColor { get; set; }
    }

    public class Client
    {
        public string carModel { get; set; }
        public string clientName { get; set; }
        public string clientTelephone { get; set; }
    }
    
    class Program
    {
        static void Main()
        {
            //коллекция автомобилей
            var carCollection = new List<Car>
            {
                new Car { carBrand = "ford", carModel = "gt", carYear = 1960, carColor = "black" },
                new Car { carBrand = "nissan", carModel = "skyline", carYear = 2000, carColor = "darkblue" },
                new Car { carBrand = "ferrari", carModel = "360", carYear = 1980, carColor = "red" },
                new Car { carBrand = "zaz", carModel = "tavria", carYear = 2005, carColor = "white" }
            };
            
            //лист клиентов

            var clientList = new List<Client>
            {
                new Client { clientName = "Walker", carModel = "skyline", clientTelephone = "333" },
                new Client { clientName = "Ludacris", carModel = "360", clientTelephone = "777" },
                new Client { clientName = "Grigory", carModel = "tavria", clientTelephone = "123" }
            };

            var query = from car in carCollection
                                                 join client in clientList
                                                   on car.carModel equals client.carModel
                                                   where client.clientName == "Ludacris"
               
                select new
                {
                    Car = car.carBrand,
                    Model = car.carModel,
                    Year = car.carYear,
                    Color = car.carColor,
                    Name = client.clientName,
                    Telephone = client.clientTelephone
                };

            foreach (var info in query)
            {

                Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", info.Car, info.Model, info.Year, info.Color,
                    info.Name, info.Telephone);
            }
        }
    }
}