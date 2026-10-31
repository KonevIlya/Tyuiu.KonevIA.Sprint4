using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task1.V12.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task1.V12.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenArray() =>
        Assert.AreEqual(2205, new DataService().Calculate(new[] { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 }));

    [TestMethod]
    public void RepeatedOddValues() =>
        Assert.AreEqual(81, new DataService().Calculate(new[] { 9, 4, 9 }));

    [TestMethod]
    public void SingleOddValue() =>
        Assert.AreEqual(7, new DataService().Calculate(new[] { 4, 7, 8 }));
}
