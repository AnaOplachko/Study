namespace OOP_03._4

{
    class Program
    {
        static void Main()
        {
            Car ford = new Car(33, 22, 10000, 160, "1990");
            Car ferrari = new Car(22, 33, 100000, 320, "2022");

            Plane cornPlane = new Plane(11, 11, 2000, 120, "1960", 3000, 2);
            Plane airbus = new Plane(1, 1, 10000000, 800, "2022", 10000, 230);

            Ship boat = new Ship(2, 2, 300, 20, "2000", 3, "cheremushki");
            Ship titanic = new Ship(3123, 1212, 10000000, 45, "1919", 2000, "london");
            ford.Show();
            ferrari.Show();

        }
    }
}