namespace project01
{
    internal class Program
    {
        //static void Increase( out int x) {

        //    x = 1;
        //}
        //int num;//1

        //int num ;//1
        //Increase( out num);
        //Console.WriteLine(num);//1
        // ref : initial value - yes //change value : may//Usage:change exist value
        //out : initial value - no //change value : must//Usage:Assign new value

        // Recursion : A method that calls itself to solve a problem.

        static void Hello()
        {
            Console.WriteLine("Plz enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
                Hello();
            else
                return;
        }

        static void Main(string[] args)
        {
            Hello();
        }

    }
}


   


