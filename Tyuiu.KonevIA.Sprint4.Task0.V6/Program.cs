using Tyuiu.KonevIA.Sprint4.Task0.V6.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task0.V6;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #4 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #4");
        Line("Тема: Одномерные массивы (статический ввод)");
        Line("Задание #0");
        Line("Вариант #6");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Найти сумму нечётных элементов целочисленного массива.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
        Console.WriteLine("{" + string.Join(", ", array) + "}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().GetSumOddArrEl(array));
        Console.ReadLine();
    }
}
