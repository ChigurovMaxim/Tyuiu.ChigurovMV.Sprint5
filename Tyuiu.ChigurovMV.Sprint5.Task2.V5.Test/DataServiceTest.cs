namespace Tyuiu.ChigurovMV.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExisted()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}