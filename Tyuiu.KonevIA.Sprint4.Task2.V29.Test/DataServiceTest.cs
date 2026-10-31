using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task2.V29.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void MixedArray() =>
        Assert.AreEqual(384, new DataService().Calculate(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 3, 5 }));

    [TestMethod]
    public void RepeatedEvenValues() =>
        Assert.AreEqual(64, new DataService().Calculate(new[] { 8, 3, 8 }));

    [TestMethod]
    public void NoEvenValues() =>
        Assert.AreEqual(1, new DataService().Calculate(new[] { 1, 3, 5, 7 }));
}
