using Tyuiu.KonevIA.Sprint4.Task4.V10.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task4.V10;

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
        Line("Тема: Двумерные массивы (ввод с клавиатуры)");
        Line("Задание #4");
        Line("Вариант #10");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Ввести матрицу 5 на 5 из целых чисел от 1 до 7.");
        Line("Заменить нечётные элементы на 0.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int[,] array = new int[5, 5];
        for (int row = 0; row < array.GetLength(0); row++)
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write($"Элемент [{row + 1}, {column + 1}] (1..7): ");
                int value;
                while (!int.TryParse(Console.ReadLine(), out value) || value < 1 || value > 7)
                    Console.Write("Введите целое число от 1 до 7: ");
                array[row, column] = value;
            }
        PrintMatrix(array);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        PrintMatrix(new DataService().Calculate(array));
        Console.ReadLine();
    }
}
