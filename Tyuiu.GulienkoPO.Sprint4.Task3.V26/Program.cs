using Tyuiu.GulienkoPO.Sprint4.Task3.V26.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Гулиенко П. О. | ИСТНб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Гулиенко Полина Олеговна | ИСТНб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный стат.  *");
            Console.WriteLine("* значениями. Найдите максимальный элемент во второй строке массива.      *");
            Console.WriteLine("*                                                                         *");
            int[,] mt = { { 4, 3, 2, 6, 2},
            { 5, 2, 2, 5, 6 },
            { 5, 2, 2, 5, 6 },
            { 4, 5, 2, 4, 6 },
            { 6, 5, 4, 3, 6 } };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            int row = mt.GetUpperBound(0) + 1;
            int colums = mt.GetUpperBound(1) + 1;
            Console.WriteLine("* Матрица:                                                                *");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mt[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(mt));
            Console.ReadLine();
        }
    }
}