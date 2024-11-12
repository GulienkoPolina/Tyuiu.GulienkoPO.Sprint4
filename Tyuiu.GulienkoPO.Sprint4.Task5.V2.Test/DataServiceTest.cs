using Tyuiu.GulienkoPO.Sprint4.Task5.V2.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcValid()
        {
            DataService ds = new DataService();
            int[,] r = {{ -1, 2 },
                        { 3, -4 }};
            Assert.AreEqual(ds.Calculate(r), 2);
        }
    }
}