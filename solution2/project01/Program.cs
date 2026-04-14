using System.Drawing;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //long y = 20000000;
            //short z = 1;
            //float Num2 = 2.3f;
            //double Num3 = 12.5;
            //decimal Num4 = 45.45m;
            //bool haswife = false;
            //char letter = 't';
            //string name = "tasnim";
            //var g = "tas";
            //const int x5 = 20;


            //Console.WriteLine("Enter Ur  name:");
            //string username01 = Console.ReadLine();

            //Console.WriteLine("Enter Ur  Age:");
            //string userage = Console.ReadLine();

            //Console.WriteLine($"My Name is { username01} , and I,m {userage}");


            //int t1 = 10;
            //Double result = t1;
            //Console.WriteLine(result);

            //double t1 = 10.5;
            //int s1 = (int)t1;
            //Console.WriteLine(s1);

            //int myInt = 9;
            //double myDouble = myInt;
            //Console.WriteLine( myInt );
            //Console.WriteLine( myDouble );

            //int x2 = 0;
            //Console.WriteLine(Convert.ToString(x2));

            Console.WriteLine("enter first num1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1}+ {num2} = {num1+num2}");
            Console.WriteLine($"{num1}- {num2} = {num1 - num2}");
            Console.WriteLine($"{num1}*{num2} = {num1 * num2}");
            Console.WriteLine($"{num1}/ {num2} = {num1 / num2}");

        }
    }
}
