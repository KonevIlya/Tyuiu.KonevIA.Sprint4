using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonevIA.Sprint4.Task6.V25.Lib;

public class DataService : ISprint4Task6V25
{
    public int Calculate(string[] array) =>
        Array.FindAll(array, value => value.Length > 6).Length;
}
