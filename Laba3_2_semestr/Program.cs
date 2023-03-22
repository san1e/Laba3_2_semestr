using System;
using System.Drawing;

namespace Laba3_2_semestr
{
    internal class Program
    {

        static int[,] Random(int n)
        {
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }
            return arr;
        }

        static int[,] Random1(int n, int m)
        {
            int[,] arr = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }
            return arr;
        }
        static int[,] Handly(int n)
        {
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(row[j]);
                }
            }
            return arr;
        }
        static int[,] Handly1(int n, int m)
        {
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(row[j]);
                }
            }
            return arr;
        }
        static void CW(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void SumNegativ(int[,] arr)
        {
            int[] SumNeg = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    SumNeg[0] += arr[i, j];
                    if (arr[i, j] < 0)
                    {
                        SumNeg[1]++;
                    }
                }
            }
            Console.WriteLine($"Сумма елементiв               = {SumNeg[0]}");
            Console.WriteLine($"Кiлькiсть вiд'ємних елементiв = {SumNeg[1]}");
            Console.WriteLine();
        }

        static int[,] Changed(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int temp = arr[i, i];
                arr[i, i] = arr[i, arr.GetLength(0) - 1 - i];
                arr[i, arr.GetLength(0) - 1 - i] = temp;
            }
            return arr;

        }



        static int[,] Sort(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int j = 0; j < cols; j += 2)
            {
                int[] column = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    column[i] = arr[i, j];
                }
                Array.Sort(column);
                Array.Reverse(column);
                for (int i = 0; i < rows; i++)
                {
                    arr[i, j] = column[i];
                }
            }

            for (int j = 1; j < cols; j += 2)
            {
                int[] column = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    column[i] = arr[i, j];
                }
                Array.Sort(column);
                for (int i = 0; i < rows; i++)
                {
                    arr[i, j] = column[i];
                }
            }

            return arr;
        }

        static int[,] Sort1(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int[] lastRow = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                lastRow[j] = arr[rows - 1, j];
            }

            for (int j = 0; j < cols; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (lastRow[k] < lastRow[j])
                    {
                        int temp = lastRow[j];
                        lastRow[j] = lastRow[k];
                        lastRow[k] = temp;

                        for (int i = 0; i < rows; i++)
                        {
                            temp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = temp;
                        }
                    }
                }
            }
            return arr;

        }

        static void Block1()
        {
            int choice;
            do
            {
                global::System.Console.WriteLine("Заповнення рандомно  - 1");
                global::System.Console.WriteLine("Заповнення власноруч - 2");
                global::System.Console.WriteLine("Повернутися назад    - 0");
                global::System.Console.WriteLine();
                global::System.Console.Write("Оберiть варiант заповнення: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        global::System.Console.Write("Введiть розмiрнiсть квадратного масиву: ");
                        int n = int.Parse(Console.ReadLine());
                        int[,] arr = Random(n);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        SumNegativ(arr);
                        break;
                    case 2:
                        global::System.Console.Write("Введiть розмiрнiсть квадратного масиву: ");
                        n = int.Parse(Console.ReadLine());
                        arr = Handly(n);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        SumNegativ(arr);
                        break;
                }
            } while (choice != 0);
        }

        static void Block2()
        {
            int choice;
            do
            {
                global::System.Console.WriteLine("Заповнення рандомно  - 1");
                global::System.Console.WriteLine("Заповнення власноруч - 2");
                global::System.Console.WriteLine("Повернутися назад    - 0");
                global::System.Console.WriteLine();
                global::System.Console.Write("Оберiть варiант заповнення: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        global::System.Console.Write("Введiть розмiрнiсть квадратного масиву: ");
                        int n = int.Parse(Console.ReadLine());
                        int[,] arr = Random(n);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        Console.WriteLine();
                        Console.WriteLine("Змiнений массив");
                        Console.WriteLine();
                        CW(Changed(arr));

                        break;
                    case 2:
                        global::System.Console.Write("Введiть розмiрнiсть квадратного масиву: ");
                        n = int.Parse(Console.ReadLine());
                        arr = Handly(n);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        Console.WriteLine();
                        Console.WriteLine("Змiнений массив");
                        Console.WriteLine();
                        CW(Changed(arr));
                        break;
                }
            } while (choice != 0);
        }

        static void Block3()
        {
            int choice;
            do {
                global::System.Console.WriteLine("Заповнення рандомно  - 1");
                global::System.Console.WriteLine("Заповнення власноруч - 2");
                global::System.Console.WriteLine("Повернутися назад    - 0");
                global::System.Console.WriteLine();
                global::System.Console.Write("Оберiть варiант заповнення: ");
                 choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        global::System.Console.Write("Введiть розмiрнiсть масиву: ");
                        int[] index = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        int n = index[0];
                        int m = index[1];
                        int[,] arr = Random1(n, m);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        Console.WriteLine();
                        Console.WriteLine("Вiдсортований массив");
                        Console.WriteLine();
                        CW(Sort(arr));

                        break;
                    case 2:
                        global::System.Console.Write("Введiть розмiрнiсть  масиву: ");
                        index = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        n = index[0];
                        m = index[1];
                        arr = Handly1(n, m);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        Console.WriteLine();
                        Console.WriteLine("Вiдсортований массив");
                        Console.WriteLine();
                        CW(Sort(arr));
                        break;
                }

                } while (choice != 0) ;

            } 

        static void Block4()
        {
            int choice;
            do
            {
                global::System.Console.WriteLine("Заповнення рандомно  - 1");
                global::System.Console.WriteLine("Заповнення власноруч - 2");
                global::System.Console.WriteLine("Повернутися назад    - 0");
                global::System.Console.WriteLine();
                global::System.Console.Write("Оберiть варiант заповнення: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        global::System.Console.Write("Введiть розмiрнiсть масиву: ");
                        int[] index = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        int n = index[0];
                        int m = index[1];
                        int[,] arr = Random1(n, m);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        Console.WriteLine();
                        Console.WriteLine("Вiдсортований массив");
                        Console.WriteLine();
                        CW(Sort1(arr));

                        break;
                    case 2:
                        global::System.Console.Write("Введiть розмiрнiсть  масиву: ");
                        index = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        n = index[0];
                        m = index[1];
                        arr = Handly1(n, m);
                        Console.Clear();
                        global::System.Console.WriteLine("Створений массив");
                        global::System.Console.WriteLine();
                        CW(arr);
                        Console.WriteLine();
                        Console.WriteLine("Вiдсортований массив");
                        Console.WriteLine();
                        CW(Sort1(arr));
                        break;

                }
            }  while (choice != 0);
        }
            static void Main(string[] args)
            {
              System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                int choice;
                int Case;
                do
                {
                    Console.WriteLine("Блок1 - 1");
                    Console.WriteLine("Блок2 - 2");
                    Console.WriteLine("Блок3 - 3");
                    Console.WriteLine("Блок4 - 4");
                    Console.WriteLine("Завершити програму - 0");
                    global::System.Console.WriteLine();
                    Console.Write("Оберiть блок завдань: ");
                    Case = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (Case)
                    {
                        case 1:
                            Block1();
                        break;

                        case 2:
                        Block2();
                        break;

                    case 3:
                        Block3();
                        break;
                    case 4:
                        Block4();
                        break;
                }


            } while (Case != 0);
            }
        
    }
}
