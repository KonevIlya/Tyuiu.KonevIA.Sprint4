using Tyuiu.KonevIA.Sprint4.Task6.V25.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task6.V25;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #4 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #4");
        Line("Тема: Класс Array");
        Line("Задание #6");
        Line("Вариант #25");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Используя класс Array, подсчитать количество строк длиннее 6.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
        foreach (string value in array)
            Console.WriteLine(value);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate(array));
        Console.ReadLine();
    }
}
