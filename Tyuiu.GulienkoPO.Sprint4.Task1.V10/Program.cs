using Tyuiu.GulienkoPO.Sprint4.Task1.V10.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #4 | Выполнила: Гулиенко П. О. | ИСТНБ - 24 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Гулиенко Полина Олеговна    | ИСТНБ - 24 - 1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                     *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9               *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("* {8, 9, 4, 1, 2, 3, 4, 5, 6 ,7}                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int len;
            Console.Write("ВВедите количество элементов массива");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i < len - 1; i++)
            {
                Console.WriteLine("Введите значение" + i + "Элемент массива");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив");
            for (int i = 0; i < len - 1; i++)
            {
                Console.WriteLine(numsArry[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArry);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}