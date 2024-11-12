using Tyuiu.GulienkoPO.Sprint4.Task5.V2.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Гулиенко П. О. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Гулиенко Полина Олеговна | ИСТНб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая считает количество         *");
            Console.WriteLine("* отрицательных значений матрицы.                                         *");
            Console.WriteLine("***************************************************************************");
            int[,] res = new int[5, 5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    res[i, j] = r.Next(-7, 5);
                }
            }
            Console.WriteLine("* Исходная матрица:                                                       *");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != 4)
                    {
                        Console.Write(res[i, j] + " ");
                        if (res[i, j + 1] >= 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(res[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(res));
        }
    }
}