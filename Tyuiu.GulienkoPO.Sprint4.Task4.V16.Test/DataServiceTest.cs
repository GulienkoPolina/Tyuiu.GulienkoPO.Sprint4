using Tyuiu.GulienkoPO.Sprint4.Task4.V16.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mass = { { 1, 2, 3 }, { 1, 4, 4 } };
            var res = ds.Calculate(mass);
            int[,] wait = { { 1, 1, 3 }, { 1, 1, 1 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}