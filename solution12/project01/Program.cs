namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //last in first out

            //Stack<int> numbers = new Stack<int>();// generic
            //numbers.Push(1);
            //numbers.Push(2);
            //numbers.Push(3);
            //numbers.Push(4);
            //numbers.Pop();//delete element

            #region Queue
            //Queue<string> names = new Queue<string>();
            //Enqueue == push
            //DeQueue == pop
            //peek
            //count
            //names.Enqueue("yahia");
            //names.Enqueue("ahmad");
            //names.Enqueue("salim");

            //Console.WriteLine(names.Peek());


            //-----------Task------------//

            //Stack<string> s = new Stack<string>();
            //string first = "";


            //for (int i = 0; i < 5; i++)
            //{
            //    string input = Console.ReadLine();
            //    if (i == 0) first = input; 
            //    s.Push(input);
            //}


            //Console.WriteLine("First: " + first);


            //s.Pop();


            //Console.WriteLine("Element:");
            //foreach (var x in s)
            //    Console.WriteLine(x);


            //------------------------------------//

            //Stack<string> stack = new Stack<string>();


            //stack.Push("t");
            //stack.Push("A");
            //stack.Push("sh");
            //stack.Push("M");
            //stack.Push("l");

            //int choice;

            //do
            //{
            //    Console.WriteLine("\n1. Add String");
            //    Console.WriteLine("2. Print Strings");
            //    Console.WriteLine("3. Delete Last Element");
            //    Console.WriteLine("4. Show All Elements");
            //    Console.WriteLine("5. Exit");

            //    Console.Write("Enter your choice: ");
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter name: ");
            //            string name = Console.ReadLine();
            //            stack.Push(name);
            //            break;

            //        case 2:
            //            if (stack.Count > 0)
            //                Console.WriteLine("Top: " + stack.Peek());
            //            else
            //                Console.WriteLine("Stack is empty");
            //            break;

            //        case 3:
            //            if (stack.Count > 0)
            //                Console.WriteLine("Removed: " + stack.Pop());
            //            else
            //                Console.WriteLine("Stack is empty");
            //            break;

            //        case 4:
            //            if (stack.Count > 0)
            //            {
            //                Console.WriteLine("All elements:");
            //                foreach (var item in stack)
            //                {
            //                    Console.WriteLine(item);
            //                }
            //            }
            //            else
            //                Console.WriteLine("Stack is empty");
            //            break;

            //        case 5:
            //            Console.WriteLine("Exiting...");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }

            //} while (choice != 5);


            //-----------------------------------------//

            //Dictionary 

            //    Dictionary<string, int> studentData = new Dictionary<string, int>();
            //    studentData.Add("Ali", 25);
            //    studentData.Add("Tasnim", 23);
            //    studentData.Add("Shahad", 23);


            //    try
            //    {
            //        Console.WriteLine($"ali is " + studentData["Ali"] + "years old");
            //    }
            //    catch (Exception ex) {
            //        Console.WriteLine(ex.Message);
            //    }
            //    try { 
            //    studentData["Ali"] = 33;
            //    Console.WriteLine("Ali's age has been update");
            //}
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    try
            //    {
            //        studentData.Remove("Ali");
            //        Console.WriteLine(studentData.ContainsValue(33));
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            #endregion




        }
    }
}
