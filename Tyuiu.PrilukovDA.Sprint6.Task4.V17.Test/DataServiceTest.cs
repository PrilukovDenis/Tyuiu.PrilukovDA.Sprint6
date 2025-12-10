using Tyuiu.PrilukovDA.Sprint6.Task4.V17.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(-0.62, result[0]);
        }
    }
}
