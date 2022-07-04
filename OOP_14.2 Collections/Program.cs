namespace OOP_14._2_Collections
{
    class Program
        {
            static void Main()
            {
                CarList<Car> carPark = new CarList<Car>();
                
                bool repeat;
                
                do
                {
                    Console.Write("Введите модель автомобиля для нашей коллекции: ");
                    var carModel = Console.ReadLine();
    
                    Console.Write("и ее год выпуска: ");
                    var carYear = Console.ReadLine();
    
                    Car car = new Car();
    
                    car.CarModel = carModel;
                    car.CarYear = carYear;
    
                    carPark.Add(car);
                    
                    Console.Write("Продолжаем добавлять в коллекцию? (yes/no): ");
                    var decision = Console.ReadLine();
    
                    repeat = false;
                    
                    if (decision == "yes")
                        repeat = true;
                    
                } while (repeat);

                Console.WriteLine("А вот что у нас в гараже!");    
                
                foreach (Car car in carPark.Power())
                {
                    Console.WriteLine("{0}, {1} года", car.CarModel, car.CarYear);
                }
                //carPark.Show();
    
                do
                {
                    Console.Write("Что бы узнать, что хранится у нас в списке, введите индекс: ");
                    var indexRequestAsString = Console.ReadLine();
                    var indexRequest = Convert.ToInt32(indexRequestAsString);
    
                    if (indexRequest <= carPark.Count)
                    {
                       Console.WriteLine("Под индексом {0} у нас хранится {1} {2} года", indexRequest,
                            carPark[indexRequest - 1].CarModel, carPark[indexRequest - 1].CarYear);
                    }
                    else
                    { 
                        Console.WriteLine("В парке не так много машин...");
                    }
                    
                    Console.Write("Продолжаем смотреть машины в коллекции? (yes/no):");
                    var decision = Console.ReadLine();
    
                    repeat = false;
    
                    if (decision == "yes" && decision != null) //понятно краш от не введенного числа
                        repeat = true;
    
                } while (repeat);
    
                Console.WriteLine("Всего заполнено строк: {0}", carPark.Count);
            }
        }
}
