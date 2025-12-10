using Tyuiu.PrilukovDA.Sprint6.Task5.V30.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(@"C:\Users\prilu\source\repos\Tyuiu.PrilukovDA.Sprint6\Tyuiu.PrilukovDA.Sprint6.Task5.V30\bin\Debug\net8.0-windows\InPutFileTask5V30.txt");

            Assert.AreEqual(5, result[0]);
        }
    }
}
