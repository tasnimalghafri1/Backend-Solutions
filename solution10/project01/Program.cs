using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;



namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file managment :
            //---------------------------------------------------------------------------//

            //File.Create("test01.txt"); // create file
            //File.WriteAllText("testc01.txt","hello fromC#");
            //string[] lines =
            //    {
            //    "Tasnim",
            //    "Shahad",
            //    "Shrouq"
            //};
            //File.WriteAllLines("test01.txt", lines);// To write inside the file

            //string[] lines02 = { "salim", "Noor" };
            //File.WriteAllLines("testc01.txt", lines02);
            //File.AppendAllText("test02.txt", "\n This the new line");
            //string myFile = File.ReadAllText("test02.txt");
            //Console.WriteLine(myFile);

            //string[] mylines = File.ReadAllLines("test02.txt");
            //Console.WriteLine(mylines[2]);


            //------------------------------------Create Test03 file------------------------

            //File.Create("test03.txt");
            //string myFile = File.ReadAllText("test03.txt");
            //Console.WriteLine(myFile);

            //File.AppendAllText("test03.txt", "\n ----------------------------------- Problems they were trying to solve in the software industry:\r\n1. Projects took too long and often delivered software that no longer met\r\ncustomer needs.\r\n2. Changing requirements were hard to handle with rigid plans.\r\n3. There was poor communication between developers, managers, and clients.\r\n4. Teams often delivered software full of bugs or that didn’t provide real value");

            //string[] mylines = File.ReadAllLines("test03.txt");
            //Console.WriteLine(mylines[2]);

            //-----------------------------------------------------------------------

            //File.Delete("test01.txt");
            //Console.WriteLine(File.Exists("test01.txt"));


            // --------------------Copy file from file --------------------//

            //File.Create("copy01.txt");

            //try
            //{
            //    File.Copy("test03.txt", "copy02.txt"); // should be in try always
            //}
            //catch (Exception e) 
            //{
            //    Console.WriteLine("e.Massage");
            //}
            //Console.WriteLine(File.ReadAllText("test03.txt"));


            //--------------------MOVE FILE TO NEW FILE -------------------------//
            //try
            //{
            //    File.Move("test03.txt", "copy03.txt"); // should be in try always
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("e.Massage");
            //}

            //------------------------ Task  --------------------------------//


            File.WriteAllText("quiz1.txt", " What is the correct file extension for C# files?\r\na) .cs\r\nb) .csharp\r\nc) .cpp\r\nd) .java");
            File.WriteAllText("quiz2.txt", "Which keyword is used to define a class in C#?\r\na) define\r\nb) class\r\nc) object\r\nd) struct");
            File.WriteAllText("quiz3.txt", "Which method is the entry point of a C# program?\r\na) Start()\r\nb) Main()\r\nc) Run()\r\nd) Init()");

            Console.WriteLine(" PLS Choose which quiz to solve it : ");
            string input = Console.ReadLine();

            string name = "";

            switch (input)
            {
                case "1":
                    name = "quiz1.txt";
                    break;
                case "2":
                    name = "quiz2.txt";
                    break;
                case "3":
                    name = "quiz3.txt";
                    break;

            }

            //try
            //{
            //    string file = File.ReadAllText(name);
            //    Console.WriteLine("\nQuiz:");
            //    Console.WriteLine(file);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                Process.Start("notepad.exe", name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}

