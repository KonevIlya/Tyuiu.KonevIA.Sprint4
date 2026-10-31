using Tyuiu.KonevIA.Sprint4.Task1.V12.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task1.V12;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #4 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #4");
        Line("Тема: Одномерные массивы (ввод с клавиатуры)");
        Line("Задание #1");
        Line("Вариант #12");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Ввести 13 целых чисел от 4 до 9 и найти произведение нечётных.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int[] array = new int[13];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1} (4..9): ");
            while (!int.TryParse(Console.ReadLine(), out array[i]) || array[i] < 4 || array[i] > 9)
                Console.Write("Введите целое число от 4 до 9: ");
        }
        Console.WriteLine("{" + string.Join(", ", array) + "}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate(array));
        Console.ReadLine();
    }
}
