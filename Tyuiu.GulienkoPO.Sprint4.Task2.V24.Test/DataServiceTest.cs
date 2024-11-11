using Tyuiu.GulienkoPO.Sprint4.Task2.V24.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 5, 6, 7, 4, 9, 8, 5, 6, 7, 4, 8, 9 };

            int wait = 42;

            Assert.AreEqual(wait, ds.Calculate(array));

        }
    }
}