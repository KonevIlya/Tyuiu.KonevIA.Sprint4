using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task0.V6.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task0.V6.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenArray() =>
        Assert.AreEqual(32, new DataService().GetSumOddArrEl(new[] { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 }));

    [TestMethod]
    public void EvenValues() =>
        Assert.AreEqual(0, new DataService().GetSumOddArrEl(new[] { 0, 2, 4, 6 }));

    [TestMethod]
    public void NegativeOddValues() =>
        Assert.AreEqual(-4, new DataService().GetSumOddArrEl(new[] { -3, -2, -1 }));

    [TestMethod]
    public void EmptyArray() =>
        Assert.AreEqual(0, new DataService().GetSumOddArrEl(Array.Empty<int>()));
}
