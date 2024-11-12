using Tyuiu.GulienkoPO.Sprint4.Task6.V4.Lib;

namespace Tyuiu.GulienkoPO.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var array = new string[] { "Москва, Санкт-Петербург, Новосибирск, Екатеринбург, Нижний Новгород, Казахстан, Самара" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Москва, Самара" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}