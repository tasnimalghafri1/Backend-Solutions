namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //Console.WriteLine("Enter number of rows:");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter number of columns:");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //int[,] numbers = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter value for [{i},{j}]: ");
            //        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matrix:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(numbers[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            // Way 2 to write an array:

            ////Console.WriteLine("Enter number of rows:");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter number of columns:");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //int[,] num = new int[rows, cols];
            //int[][] num02 = new int[3][];

            //num02[0] = new int[3];
            //num02[1] = new int[2];
            //num02[2] = new int[4];
            //num02[0][0] = 1;
            //num02[0][1] = 20;
            //num02[0][2] = 30;
            //num02[1][0] = 40;
            //num02[1][1] = 50;
            //num02[2][0] = 60;
            //num02[2][1] = 70;
            //num02[2][2] = 80;
            //num02[2][0] = 90;


            //int[][] num03 =
            //{
            //    new int []{10,20,30},
            //    new int []{40,50},
            //    new int []{60,70,80,90},
            //};
            //Console.WriteLine(num03[0][2]);



            //Student Management Sys Using Array Assignment:

            int studentCount = 5;
            int subjectCount = 3;

            string[] studentNames = new string[studentCount];
            string[] subjectNames = { "Math", "Science", "English" };

            int[,] grades = new int[studentCount, subjectCount];

            // ---------------- Part 1 : Student Names ----------------

            Console.WriteLine("Enter 5 student names:");

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Student {i + 1}: ");
                studentNames[i] = Console.ReadLine();
            }

            Console.WriteLine("\nStudent Names:");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i}: {studentNames[i]}");
            }

            // ---------------- Part 2 : Grades Input ----------------

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"\nEnter grades for {studentNames[i]}:");

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write($"{subjectNames[j]}: ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // ---------------- Part 3 : Display Table ----------------

            Console.WriteLine("\n--- Grades Table ---");
            Console.Write("Student\t");

            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write(subjectNames[j] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{studentNames[i]}\t");

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write(grades[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // ---------------- Part 4 : Average ----------------

            Console.WriteLine("\n--- Student Averages ---");

            for (int i = 0; i < studentCount; i++)
            {
                int sum = 0;

                for (int j = 0; j < subjectCount; j++)
                {
                    sum += grades[i, j];
                }

                double avg = (double)sum / subjectCount;
                Console.WriteLine($"{studentNames[i]} Average: {avg:F2}");
            }

            // ---------------- Part 5 : Jagged Array ----------------

            Console.WriteLine("\n--- Jagged Array ---");

            int[][] jaggedGrades = new int[studentCount][];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"\nHow many subjects for {studentNames[i]}!!!! ");
                int n = Convert.ToInt32(Console.ReadLine());

                jaggedGrades[i] = new int[n];

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Grade {j + 1}: ");
                    jaggedGrades[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n--- Jagged Output ---");

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{studentNames[i]} ({jaggedGrades[i].Length} subjects): ");

                for (int j = 0; j < jaggedGrades[i].Length; j++)
                {
                    Console.Write(jaggedGrades[i][j] + " ");
                }

                Console.WriteLine();
            }

            // ---------------- Part 6 : Search ----------------

            Console.Write("\n pls Enter student name to search: ");
            string searchName = Console.ReadLine();


            int index = -1;

            for (int i = 0; i < studentCount; i++)
            {
                if (studentNames[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine($"Student found at index: {index}");
            else
                Console.WriteLine(" Sorry Student not found.");

            // ---------------- Part 7 : Highest Grade ----------------

            int highest = grades[0, 0];

            for (int i = 0; i < studentCount; i++)
            {
                for (int j = 0; j < subjectCount; j++)
                {
                    if (grades[i, j] > highest)
                    {
                        highest = grades[i, j];
                    }
                }
            }

            Console.WriteLine($"\nHighest grade in system: {highest}");

            #endregion
        }
    }
}
