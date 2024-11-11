using Tyuiu.GulienkoPO.Sprint4.Task3.V26.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mt = new int[3, 3] { { 1, 2, 8 }, { 1, 2, 5 }, { 1, 2, 4 } };
            var res = ds.Calculate(mt);
            Assert.AreEqual(5, res);
        }
    }
}