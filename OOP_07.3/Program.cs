namespace OOP_07._3 //кругом залупа не могу понять что от меня хотят и что я не правильно делаю не понятно тоже
{
    class Program
    {
        static void Main()
            {
                MyClass myClass = new MyClass();
                myClass.change = "ismeneno";
                
                
                static void ClassTaker(MyClass myClass)
                {
                    myClass.change = "изменено";
                }
                MySruct mySruct = new MySruct();
                mySruct.change = "ismeneno";
        
                static void StructTaker(MySruct mySruct)
                {
                    mySruct.change = "изменено";
                }
        
                
                
                Console.WriteLine("myClass change = {0}", myClass.change);
                Console.WriteLine("myStruct change = {0}", mySruct.change);
            }
    }
    
}

