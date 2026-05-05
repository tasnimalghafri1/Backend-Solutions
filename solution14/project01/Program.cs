namespace project01
{
    internal class Program
    {
        class Car
        {
            public string color;
            public int age;
            // public int model_year;
            // private int temp ;
            //public int Speed 
            // {
            //     get { return temp; } 
            //     set {
            //         if (value > 0)
            //             temp = value;
            //     }
            // }

            //public void Drive()
            //{
            //    temp += 45;
            //    Console.WriteLine("HIIIIIIIIIII");
            //}

            public Car(string c, int a)
            {
                color = c;
                age = a;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter color:");
            string color = Console.ReadLine();
            Console.WriteLine("Enter ur age:");
            int age = Convert.ToInt32 (Console.ReadLine());
            Car my_car = new Car(color,age);
            Console.WriteLine(my_car.color);
            Console.WriteLine(my_car.age);
            //my_car.color = "Red";
            //my_car.model_year = 2002;

            //Console.WriteLine("Enter Speed");
            //my_car.Speed = Convert.ToInt32(Console.ReadLine());
            //my_car.temp = 56;


        }
    }
}
