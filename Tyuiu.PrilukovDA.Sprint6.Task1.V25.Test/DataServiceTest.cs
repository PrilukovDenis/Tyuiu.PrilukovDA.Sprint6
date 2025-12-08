using Tyuiu.PrilukovDA.Sprint6.Task1.V25.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] expected = new double[]
            {
                4.99, 4.56, 3.66, 2.34, 1.17,
                1.25, 2.83, 4.52, 5.35, 5.73, 5.91
            };

            double[] result = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
