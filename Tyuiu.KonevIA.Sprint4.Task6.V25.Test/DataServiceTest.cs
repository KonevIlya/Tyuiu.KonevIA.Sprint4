using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task6.V25.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task6.V25.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenArray() =>
        Assert.AreEqual(2, new DataService().Calculate(new[]
        {
            "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей"
        }));

    [TestMethod]
    public void StrictLengthBoundary() =>
        Assert.AreEqual(1, new DataService().Calculate(new[] { "123456", "1234567", "" }));

    [TestMethod]
    public void EmptyArray() =>
        Assert.AreEqual(0, new DataService().Calculate(Array.Empty<string>()));
}
