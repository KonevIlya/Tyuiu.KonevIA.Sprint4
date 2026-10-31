using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task3.V19.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task3.V19.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenMatrix() =>
        Assert.AreEqual(11, new DataService().Calculate(new int[,]
        {
            { 6, 5, 6, 3, 8 },
            { 9, 4, 4, 3, 4 },
            { 3, 3, 6, 8, 6 },
            { 6, 5, 3, 4, 3 },
            { 9, 3, 5, 3, 7 }
        }));

    [TestMethod]
    public void RectangularMatrix() =>
        Assert.AreEqual(3, new DataService().Calculate(new int[,] { { 2, 3, 4 }, { 5, 6, 7 } }));

    [TestMethod]
    public void NoEvenValues() =>
        Assert.AreEqual(0, new DataService().Calculate(new int[,] { { 3, 5 }, { 7, 9 } }));

    [TestMethod]
    public void ZeroAndNegativeEvenValues() =>
        Assert.AreEqual(2, new DataService().Calculate(new int[,] { { 0, -2, -3 } }));
}
