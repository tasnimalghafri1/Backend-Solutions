namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------List --------------------------------------//

            //List<int> list01 = new List<int>();
            // list data
            //int datatype (inside the list)
            //list02 list name
            //int[] newarr = { 50,110, 60, 70, 80, 90 };
            //list01.Add(10);
            //list01.Add(20);
            //list01.Add(30);
            //list01.Add(30);

            //list01.Add(10);
            //list01.Add(40);
            //list01.AddRange(newarr);



            //try
            //{
            //   list01.RemoveAt(4);

            //    foreach (int i in list01)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("//---------------------------------//");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //1. add() add element
            // 2. Remove() remove first wanted element
            //3. removeAt() remove with index 
            // 4. removeall() remove every element applying with condition 
            //5.count know the number of element in the list
            // 6.addrange()
            //7.clear() clear all of the list 
            //8.contains() return true or false to know if the element exists
            //9. indexof()  return the first index of element
            //10. find() return the first element applying with condition
            //11. ex

            //foreach (int i in list01)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("//-----------------------------//");
            //Console.WriteLine(list01.Count);

            //try
            //{
            //    if (list01.Exists(x => x == 10)) ;
            //    Console.WriteLine("");
            //    Console.WriteLine(list01.Find(x => x==10));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #region Functions

            //void AddTwoNumbers(int x , int y){
            //    Console.WriteLine(x+y);
            //}
            //int fnum = Convert.ToInt32(Console.ReadLine());
            //int snum = Convert.ToInt32(Console.ReadLine());
            //AddTwoNumbers(fnum, snum);


            //--------------------------------------------------//
            bool continueCalc = true;
            double result = 0;

            while (continueCalc)
            {
                Console.Write("enter num 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("enter num 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Choose (+ - * /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                            continue;
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong operation");
                        continue;
                }

                Console.WriteLine("Result = " + result);

                Console.Write("Do you want another calculation? (y/n): ");
                char answer = Convert.ToChar(Console.ReadLine());

                if (answer != 'y' && answer != 'Y')
                    continueCalc = false;
            }

            Console.WriteLine("Finish!");

            #endregion
        }
    }
}
