using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonevIA.Sprint4.Task4.V10.Lib;

public class DataService : ISprint4Task4V10
{
    public int[,] Calculate(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
            for (int column = 0; column < array.GetLength(1); column++)
                if (array[row, column] % 2 != 0)
                    array[row, column] = 0;
        return array;
    }
}
