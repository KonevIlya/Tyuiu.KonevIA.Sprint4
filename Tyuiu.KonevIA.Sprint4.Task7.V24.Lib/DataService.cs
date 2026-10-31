using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonevIA.Sprint4.Task7.V24.Lib;

public class DataService : ISprint4Task7V24
{
    public int Calculate(int n, int m, string value)
    {
        int[,] matrix = new int[n, m];
        for (int row = 0; row < n; row++)
            for (int column = 0; column < m; column++)
                matrix[row, column] = int.Parse(value[row * m + column].ToString());

        int product = 1;
        foreach (int number in matrix)
            if (number % 2 == 0)
                product *= number;
        return product;
    }
}
