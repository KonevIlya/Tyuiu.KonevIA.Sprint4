using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task7.V24.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task7.V24.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenMatrix() =>
        Assert.AreEqual(1179648, new DataService().Calculate(5, 3, "651827384219648"));

    [TestMethod]
    public void ZeroMakesProductZero() =>
        Assert.AreEqual(0, new DataService().Calculate(2, 2, "2046"));

    [TestMethod]
    public void DifferentDimensions() =>
        Assert.AreEqual(48, new DataService().Calculate(2, 3, "123456"));
}

