using System.Security.Cryptography.X509Certificates;
using System;

namespace OOP_07._2
{
    class Program
    {
        static void Main()
        {
            /*const int destinationQuantity = 8;
            Train[] schedule = new Train [destinationQuantity];

            for (int i = 0; i < destinationQuantity; i++)
            {
                Console.Write("Введите направление: ");
                var destination = Console.ReadLine();

                Console.Write("Введите номер поезда: ");
                var trainNumberAsString = Console.ReadLine();
                var trainNumber = Convert.ToInt32(trainNumberAsString);
                
                Console.Write("Введите время отправления: ");
                var time = Console.ReadLine();
                
                Train train = new Train(destination, trainNumber, time);
                schedule[i] = train;
            }
            */
            
            const int destinationQuantity = 8;  //задано по условию задачи
            int[] trainNumbers = new int [destinationQuantity];
            string[] destinations = new string [destinationQuantity];
            string[] departureTimes = new string [destinationQuantity];

            for (int i = 0; i < destinationQuantity; i++)
            {
                Console.Write("Введите номер поезда: ");
                var trainNumberAsString = Console.ReadLine();
                trainNumbers[i] = Convert.ToInt32(trainNumberAsString);
                
                Console.Write("Введите направление: ");
                destinations[i] = Console.ReadLine();
                                
                Console.Write("Введите время отправления: ");
                departureTimes[i] = Console.ReadLine();
            }
            
            //сортировка по возрастанию номеров поезда
            int tempNumber;
            string tempDestination;
            string tempTime;
            
            for (int i = 0; i < trainNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < trainNumbers.Length; j++)
                {
                    if (trainNumbers[i] > trainNumbers[j])
                    {
                        tempNumber = trainNumbers[i];
                        trainNumbers[i] = trainNumbers[j];
                        trainNumbers[j] = tempNumber;

                        tempDestination = destinations[i];
                        destinations[i] = destinations[j];
                        destinations[j] = tempDestination;

                        tempTime = departureTimes[i];
                        departureTimes[i] = departureTimes[j];
                        departureTimes[j] = tempTime;
                    }
                }
            }

            //занесение информации о расписании в структуру
            Train[] schedule = new Train [destinationQuantity];

            for (int i = 0; i < destinationQuantity; i++)
            {
                Train train = new Train(destinations[i], trainNumbers[i], departureTimes[i]);
                schedule[i] = train;
            }
            
            Console.ReadLine();

            while (true)
            {
                int counterForAbsenceTrainCheck = 0;
                
                Console.Write("Введите номер интересующего вас поезда: ");
                var trainNumberRequestAsString = Console.ReadLine();
                var trainNumberRequest = Convert.ToInt32(trainNumberRequestAsString);

                for (int i = 0; i < destinationQuantity; i++)
                {
                    if (schedule[i].trainNumber == trainNumberRequest)
                    {
                        Console.WriteLine("Поезд в {0}, по номеру {1} отправляется в {2}", schedule[i].destination,
                            schedule[i].trainNumber, schedule[i].time);
                    }
                    else counterForAbsenceTrainCheck++;
                }
                //проверка на отсутствие поезда в расписании
                if (counterForAbsenceTrainCheck == destinationQuantity)
                {
                    Console.WriteLine("Вы ошиблись, поезда под таким номером нет в расписании");
                }

                Console.ReadLine();
            }
        }
    }
}
