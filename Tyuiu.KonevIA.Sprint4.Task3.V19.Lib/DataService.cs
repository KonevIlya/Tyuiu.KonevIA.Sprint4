using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonevIA.Sprint4.Task3.V19.Lib;

public class DataService : ISprint4Task3V19
{
    public int Calculate(int[,] array)
    {
        int count = 0;
        foreach (int value in array)
        {
            if (value % 2 == 0)
                count++;
        }
        return count;
    }
}
