using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AxyonovMA.Sprint5.Task6.V3.Lib;

namespace Tyuiu.AxyonovMA.Sprint5.Task6.V3.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Count_Latin_Letters_Correctly()
        {
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask6V3_Test.txt");

            string data = "Hello, Привет! abcXYZ123";
            File.WriteAllText(path, data);

            Class1 obj = new Class1();
            int actual = obj.LoadFromDataFile(path);

            int expected = 11; // Hello(5) + abc(3) + XYZ(3)
            Assert.AreEqual(expected, actual);
        }
    }
}
