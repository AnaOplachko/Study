namespace OOP_10._2
{
   class Program
   {
      static void Main()
      {
         MyList<string> myFilmList = new MyList<string>();
         myFilmList.Add("Бешенные псы");
         myFilmList.Add("Джеки Браун");
         myFilmList.Add("Убить Билла");
         myFilmList.Add("Бесславные ублюдки");
         myFilmList.Add("Джанго освобожденный");
         myFilmList.Add("Омерзительная восьмерка");
         myFilmList.Add("Однажды в... Голливуде");
         
         myFilmList.Show();

         Console.Write("Что бы узнать, что хранится у нас в списке, введите индекс: ");
         var indexRequestAsString = Console.ReadLine();
         var indexRequest = Convert.ToInt32(indexRequestAsString);
         
         Console.WriteLine("Под индексом {0} у нас хранится {1}",indexRequest, myFilmList[indexRequest-1]);

         Console.WriteLine("Всего заполнено строк: {0}", myFilmList.Counter);
      }
   }
}


