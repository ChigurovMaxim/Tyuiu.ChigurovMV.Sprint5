namespace Tyuiu.ChigurovMV.Sprint5.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}