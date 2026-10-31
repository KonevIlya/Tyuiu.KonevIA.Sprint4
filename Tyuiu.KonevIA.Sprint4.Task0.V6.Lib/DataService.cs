using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonevIA.Sprint4.Task0.V6.Lib;

public class DataService : ISprint4Task0V6
{
    public int GetSumOddArrEl(int[] array)
    {
        int sum = 0;
        foreach (int value in array)
        {
            if (value % 2 != 0)
                sum += value;
        }
        return sum;
    }
}
