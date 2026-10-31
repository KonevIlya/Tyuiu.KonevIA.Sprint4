using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task4.V10.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task4.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenMatrix()
    {
        int[,] input =
        {
            {6,6,5,3,3}, {5,7,4,6,4}, {1,2,4,1,5},
            {1,7,2,5,7}, {4,2,6,5,6}
        };
        int[,] expected =
        {
            {6,6,0,0,0}, {0,0,4,6,4}, {0,2,4,0,0},
            {0,0,2,0,0}, {4,2,6,0,6}
        };
        CollectionAssert.AreEqual(expected, new DataService().Calculate(input));
    }

    [TestMethod]
    public void RectangularMatrix() =>
        CollectionAssert.AreEqual(new int[,] {{0,2,0},{4,0,6}},
            new DataService().Calculate(new int[,] {{1,2,3},{4,5,6}}));

    [TestMethod]
    public void EvenValuesUnchanged() =>
        CollectionAssert.AreEqual(new int[,] {{2,4},{6,0}},
            new DataService().Calculate(new int[,] {{2,4},{6,0}}));
}
