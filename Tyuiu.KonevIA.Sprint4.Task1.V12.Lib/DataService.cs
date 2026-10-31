using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonevIA.Sprint4.Task1.V12.Lib;

public class DataService : ISprint4Task1V12
{
    public int Calculate(int[] array)
    {
        int product = 1;
        foreach (int value in array)
        {
            if (value % 2 != 0)
                product *= value;
        }
        return product;
    }
}
