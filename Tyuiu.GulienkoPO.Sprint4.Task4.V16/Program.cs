using Tyuiu.GulienkoPO.Sprint4.Task4.V16.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Гулиенко П. О. | ИСТНб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Гулиенко Полина Олеговна | ИСТНб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить четные элементы на 1.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество строк в массиве: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] mt = new int[row, cols];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mt[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mt[i, j]}\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            int[,] wait = ds.Calculate(mt);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{wait[i, j]}\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}