using Tyuiu.KonevIA.Sprint4.Task3.V19.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task3.V19;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #4 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #4");
        Line("Тема: Двумерные массивы (статический ввод)");
        Line("Задание #3");
        Line("Вариант #19");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Подсчитать количество чётных элементов в матрице 5 на 5.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int[,] array =
        {
            { 6, 5, 6, 3, 8 },
            { 9, 4, 4, 3, 4 },
            { 3, 3, 6, 8, 6 },
            { 6, 5, 3, 4, 3 },
            { 9, 3, 5, 3, 7 }
        };
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
                Console.Write($"{array[row, column],4}");
            Console.WriteLine();
        }
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate(array));
        Console.ReadLine();
    }
}
