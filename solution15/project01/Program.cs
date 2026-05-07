using System.Security.Principal;
using System.Threading.Channels;

namespace project01
{
    internal class Program
    {
        //class Account
        //{
        //    private double balance;
        //    public double Balance
        //    {
        //        get { return balance; }
        //         private set // برايفت لاان ما نبغى اي حد يجي ويغير البلنس
        //        {
        //            if (value >= 0)
        //                balance = value;
        //        }
        //    }
        //    public void Deposit (double amount)
        //    {
        //        if (amount>0)
        //        {
        //            balance += amount;
        //        }
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    //Encapsolation : نغلف الداتا مالنا يعني نمنع الوصول اليها 
        //   Account account = new Account();
        //    account.Deposit(99.99);
        //    Console.WriteLine(account.Balance);
        //}

        //---------------------------Task------------------------------//
        // Create 3 function 2 of them vertual , child inhert from parent ,
        // child override 2 function, and then take instanse from child , call 2 function

        //class Animal
        //{
        //    public int age;

        //  // F 1
        //    public virtual void Eat()
        //    {
        //        Console.WriteLine("Animal is eating");
        //    }

        //    //  F 2
        //    public virtual void Sleep()
        //    {
        //        Console.WriteLine("Animal is sleeping");
        //    }

        //    //  Function : ما نقدر نسويلها overriding 
        //    public void Run()
        //    {
        //        Console.WriteLine("Animal is running");
        //    }
        //}

        //// Child Class
        //class Dog : Animal
        //{
        //    // Override Function 1
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Dog is eating meat");
        //    }

        //    // Override Function 2
        //    public override void Sleep()
        //    {
        //        Console.WriteLine("Dog is sleeping in the Garden");
        //    }


        //    public void Bark()
        //    {
        //        Console.WriteLine("Dog is barking");
        //    }
        //}


        //static void Main(string[] args)
        //{

        //    Dog dog = new Dog();

        //    // Call 2 overridden functions
        //    dog.Eat();
        //    dog.Sleep();
        //}

        //---------------------------------------------//

        // 1. compile time polymorphism == method overloading
        //2. run time polymorphism == method overriding

        //    class Shape
        //    {
        //        public virtual void Drow()
        //        {
        //            Console.WriteLine("Drowing shape");
        //        }
        //    }

        //    class Circle: Shape
        //    {
        //        public override void Drow()
        //        {
        //            Console.WriteLine("Drowing circle");
        //        }
        //    }

        //class Rectangle : Shape
        //    {
        //        public override void Drow()
        //        {
        //            Console.WriteLine("drowing rectangle ");
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //       Shape s1 = new Shape();
        //        Shape s2 = new Rectangle();
        //        s1.Drow();
        //        s2.Drow();
        //    }

        // ----------------------------------------------------------------------//

        //abstract :
        //interface: castomize object 

        //    abstract class Animal
        //    {
        //        interface Animal00
        //        {
        //            string Name { get; }

        //        }
        //        public abstract void SayHi();

        //    }
        //    class Dog : Animal
        //    {
        //        public override void SayHi()
        //        {
        //            Console.WriteLine("dog is barking");
        //        }
        //    }

     
       
    }
}
