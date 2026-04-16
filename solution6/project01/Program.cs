using System.ComponentModel.Design;
using System.Text;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int x = 1;x<5; x++)
            //{
            //    Console.WriteLine("my age is 45");
            //}

            //for (int x = 1; x < 6; x++)
            //{
            //    Console.WriteLine("Pls enter number :");
            //    int num  = Convert.ToInt32(Console.ReadLine());
            //}


            //x =1

            //for (int x = 1; x < 6; x++)
            //{
            //    for (int i =1; i < 6; i++)
            //    {
            //        Console.WriteLine($"({x},{i})");
            //    }
            //}

            //Console.WriteLine("Pls enter number :");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine("The number is  not Prime ");
            //        return;
            //    }


            //}
            //Console.WriteLine("The number is  Prime ");



            //int rangeNum = Random.Shared.Next(1, 5);
            //Console.WriteLine("Pls enter number :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //while (num != rangeNum)
            //{

            //    Console.WriteLine("Not correct ");
            //    num = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("correct !!!!!!!!!!!!!!!!!!!!!");



            //int rangeNum = Random.Shared.Next(1, 5);
            //Console.WriteLine("Pls enter number :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int tries = 1;
            //while (num != rangeNum && tries < 3)
            //{

            //    Console.WriteLine("Not correct ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    tries++;

            //}
            //if (num == rangeNum)
            //{
            //    Console.WriteLine("correct !!!!!!!!!!!");
            //}
            //else
            //{
            //    Console.WriteLine("You can't try any more ");
            //}


            //FOR LOOP 
            //WHILE
            #region String


            //string text01 = "Hello World! ";
            //Console.WriteLine(text01);
            //Console.WriteLine(text01[0]);
            //Console.WriteLine(text01.Length);
            //Console.WriteLine(text01.Trim());
            //Console.WriteLine(text01.TrimEnd());
            //Console.WriteLine(text01.TrimStart());
            //Console.WriteLine(text01.ToUpper());
            //Console.WriteLine(text01.ToLower());
            //Console.WriteLine(text01.Contains('a'));
            //Console.WriteLine(text01.Replace("Hello","buy"));
            //Console.WriteLine(text01.Substring(0,3));

            //StringBuilder newText = new StringBuilder("Tasnim Masoud");
            //Console.WriteLine(newText.AppendLine("Tasnim"));
            //Console.WriteLine(newText.AppendLine(" Masoud"));
            //Console.WriteLine(newText.Insert(7,"ali"));

            //for (int i = 0; i < text01.Length; i++)
            //{
            //    Console.WriteLine(text01[i]);
            //}


            Console.WriteLine("pls enter word : ");
            string word = Console.ReadLine();
            StringBuilder newText = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                newText.Append(word[i]);
            }
            if(word == newText.ToString())
            {
                Console.WriteLine("Perfect!");
            }else
            {
                Console.WriteLine("Not perfect");
            }

            #endregion


        }
    }
}

