using System.Reflection;
using System.Threading.Channels;
using System.Transactions;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //control statment
            //Conditional statment(if , switch)
            //loop statment

            //int x =Convert.ToInt32(Console.ReadLine()  ) ; 
            //if (x >50)
            //{
            //    Console.WriteLine("Red ");
            //}
            //else if (x >40)
            //{
            //    Console.WriteLine("Green");
            //}
            //else 
            //{
            //    Console.WriteLine("Yellow");
            //}


            //Console.WriteLine("pls enter ur child gender:");
            //string gender = Console.ReadLine();
            //Console.WriteLine("Pls enter ur age :");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (gender == "boy")
            //{
            //    if (age > 16 || age < 4)
            //    {
            //        Console.WriteLine("We do not accept boyes from 4-16 years");
            //    }else if (age > 12)
            //    {
            //        Console.WriteLine("football");
            //    }else if (age > 9)
            //    {
            //        Console.WriteLine("Swimming");
            //    }
            //    else
            //    {
            //        Console.WriteLine("drawing");
            //    }

            //}
            //else if (gender == "girl")
            //{
            //    if (age > 16 || age < 4)
            //    {
            //        Console.WriteLine("We do not accept girls from 4-16 years");
            //    }else if (age > 12)
            //    {
            //        Console.WriteLine("football");
            //    }
            //    else if (age > 9)
            //    {
            //        Console.WriteLine("Swimming");
            //    }
            //    else
            //    {
            //        Console.WriteLine("drawing");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Ivalid information");
            //}

            //Console.WriteLine("pls enter ur child gender:");
            //string gender = Console.ReadLine();
            //Console.WriteLine("Pls enter ur age :");
            //int age = Convert.ToInt32(Console.ReadLine());

            //string fruits = "Apple";
            //switch (fruits)
            //{
            //    case "orange":
            //        Console.WriteLine("hello world");
            //        break;
            //    case "banana":
            //        Console.WriteLine("hiiiiii");
            //        break;
            //    case "Apple":



            //}


           // Task 1 - positive , negitive or zero
           // Console.WriteLine("pls enter Number:");
           // int num = Convert.ToInt32(Console.ReadLine());
           // if (num > 0)
           // {
           //     Console.WriteLine("Positive");
           // }
           // else if (num < 0)
           // {
           //     Console.WriteLine("Negitive");
           // }
           // else
           // {
           //     Console.WriteLine("Zero");
           // }
           // ;


           // Task 2 - Even or Odd


           //Console.WriteLine("pls enter Integer Number:");
           // int num = Convert.ToInt32(Console.ReadLine());

           // if (num % 2 == 0)
           // {
           //     Console.WriteLine("Even");
           // }
           // else
           // {
           //     Console.WriteLine("Odd");
           // }

           // Task 3 - Student Grade Sys :

           // Console.WriteLine("pls enter Ur Score");
           // int score = Convert.ToInt32(Console.ReadLine());
           // if (score >= 90 && score <= 100)
           // {
           //     Console.WriteLine("Excellent !!!!!!!!!");
           // }
           // else if (score >= 75 && score <= 89)
           // {
           //     Console.WriteLine("Very GOOD");
           // }
           // else if (score >= 60 && score <= 74)
           // {
           //     Console.WriteLine("Good");
           // }
           // else if (score >= 50 && score <= 59)
           // {
           //     Console.WriteLine("Pass");
           // }
           // else if (score >= 0 && score < 50)
           // {
           //     Console.WriteLine(" Fail");
           // }
           // else
           // {
           //     Console.WriteLine(" Ur score must be btween 0-100 ");
           // }

           // Task 4 - Simple login sys:

           //  Console.WriteLine("pls enter UserName");
           // string username = Console.ReadLine();
           // Console.WriteLine("pls enter the Password");
           // int password = Convert.ToInt32(Console.ReadLine());

           // if (username == "admin" && password == 1234)
           // {
           //     Console.WriteLine("login Successfuly");
           // }
           // else
           // {
           //     Console.WriteLine("Invalid Login ");
           // }

           // Task 5 - simple ATM sys:

           // int balance = 1000;
           // Console.WriteLine("pls enter the withdrawal amount:");
           //  int withdrawalamount = Convert.ToInt32(Console.ReadLine());

           // if (withdrawalamount <= 0)
           // {
           //     Console.WriteLine("Invalid Amount");
           // }
           // else if (withdrawalamount > balance) {
           //     Console.WriteLine("Insufficient Balance");
           // }
           // else 
           // {
           //     balance = balance - withdrawalamount;
           //     Console.WriteLine("Withdrawal Successful");
           //     Console.WriteLine("Ur Remaining Balance is :"+ balance);
           // }
        }


    }
}
