using System.Collections;

namespace OOP_11._1
{
    class Program
    {
        static void Main()
        {
            int a = 111;
            char b = 'b';
            bool c = true;
            string d = "privet";

            ArrayList arrayList = new ArrayList();

            arrayList.Add(a);
            arrayList.Add(b);
            arrayList.Add(c);
            arrayList.Add(d);
            
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine("{0}. {1} типа {2}", i, arrayList[i], arrayList[i].GetType());
        }
    }
}
//хз вроде все ок.