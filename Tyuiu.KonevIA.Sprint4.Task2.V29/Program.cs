using Tyuiu.KonevIA.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task2.V29;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #4 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #4");
        Line("Тема: Одномерные массивы (генератор случайных чисел)");
        Line("Задание #2");
        Line("Вариант #29");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Создать массив из 11 случайных целых чисел от 1 до 8.");
        Line("Найти произведение чётных элементов массива.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int[] array = new int[11];
        var random = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(1, 9);
        Console.WriteLine("{" + string.Join(", ", array) + "}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate(array));
        Console.ReadLine();
    }
}
