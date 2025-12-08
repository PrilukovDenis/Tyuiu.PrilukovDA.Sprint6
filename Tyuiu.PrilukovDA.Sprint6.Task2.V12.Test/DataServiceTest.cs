using Tyuiu.PrilukovDA.Sprint6.Task2.V12.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] expected =
            {
                1.59, 1.45, 1.47, 1.83, 3.00, 3.00,
                -0.59, -1.34, -1.67, -1.83, -1.92
            };

            double[] actual = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
