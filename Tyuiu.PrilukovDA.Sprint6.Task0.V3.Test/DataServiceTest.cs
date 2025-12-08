using Tyuiu.PrilukovDA.Sprint6.Task0.V3.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(4.154, ds.Calculate(3));

        }
    }
}
