using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint4.Task5.V1.Lib;

namespace Tyuiu.KonevIA.Sprint4.Task5.V1.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void MixedMatrix() =>
        CollectionAssert.AreEqual(new int[,] {{-9,0,1},{1,-3,1}},
            new DataService().Calculate(new int[,] {{-9,0,8},{2,-3,1}}));

    [TestMethod]
    public void NonPositiveValuesUnchanged() =>
        CollectionAssert.AreEqual(new int[,] {{-9,-1},{0,-4}},
            new DataService().Calculate(new int[,] {{-9,-1},{0,-4}}));

    [TestMethod]
    public void AllPositiveValuesBecomeOne() =>
        CollectionAssert.AreEqual(new int[,] {{1,1},{1,1}},
            new DataService().Calculate(new int[,] {{2,8},{5,4}}));
}
