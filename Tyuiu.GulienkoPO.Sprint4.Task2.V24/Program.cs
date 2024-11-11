using Tyuiu.GulienkoPO.Sprint4.Task2.V24.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #4 | Выполнила: Гулиенко П. О. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Гулиенко Полина Олеговна | ИСТНб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от 4 до 9. Подсчитать сумму           *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*    Массив: [значения массива будут сгенерированы случайно]              *");
            Console.WriteLine("*                                                                         *");
            Random rnd = new Random();

            int[] array = new int[12];
            DataService ds = new DataService();

            Console.WriteLine("| {0,2:d} | {1,3:d} |", '№', "num");
            Console.WriteLine("+----+-----+");
            for (int i = 0; i < 12; i++)
            {
                array[i] = rnd.Next(4, 9);
                Console.WriteLine("| {0,2:d} | {1,3:d} |", i, array[i]);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*                                                                         *");
            //Console.WriteLine(ds.Calculate(array));
            string result = ds.Calculate(array).ToString().PadLeft(39).PadRight(73);
            Console.WriteLine($"*{result}*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");




        }
    }
}