using Tyuiu.KonevIA.Sprint4.Task5.V1.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task5.V1;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #4 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                    Console.Write($"{matrix[row, column],4}");
                Console.WriteLine();
            }
        }
        Console.WriteLine(border);
        Line("Спринт #4");
        Line("Тема: Двумерные массивы (генератор случайных чисел)");
        Line("Задание #5");
        Line("Вариант #1");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Создать матрицу 5 на 5 случайных целых чисел от -9 до 8.");
        Line("Заменить положительные элементы на 1.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int[,] array = new int[5, 5];
        var random = new Random();
        for (int row = 0; row < array.GetLength(0); row++)
            for (int column = 0; column < array.GetLength(1); column++)
                array[row, column] = random.Next(-9, 9);
        PrintMatrix(array);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        PrintMatrix(new DataService().Calculate(array));
        Console.ReadLine();
    }
}

