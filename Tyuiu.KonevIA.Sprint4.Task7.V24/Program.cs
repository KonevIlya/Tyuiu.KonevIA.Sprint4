using Tyuiu.KonevIA.Sprint4.Task7.V24.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task7.V24;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #4 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #4");
        Line("Тема: Итоговые проекты по спринту");
        Line("Задание #7");
        Line("Вариант #24");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Преобразовать строку цифр в матрицу 5 на 3.");
        Line("Найти произведение чётных элементов.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        string value = "651827384219648";
        int n = 5;
        int m = 3;
        Console.WriteLine(value);
        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < m; column++)
                Console.Write($"{value[row * m + column],4}");
            Console.WriteLine();
        }
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate(n, m, value));
        Console.ReadLine();
    }
}
