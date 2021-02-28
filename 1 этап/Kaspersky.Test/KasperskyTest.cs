using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Kaspersky.Test
{
    [TestClass]
    public class KasperskyTest
    {
        [TestMethod]
        public void TestFileTXT()//существующий txt файл
        {
            FileProcessor fp = new FileProcessor();
            string fileName = "test.txt";
            string expected = "Содержимое файла txt";

            fp.ProcessFile(fileName);

            string actual = fp.parseText;
            Assert.AreEqual(expected, actual);

            
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestFileTXT_NotExistsFile()//не существующий txt файл
        {
            FileProcessor fp = new FileProcessor();
            string fileName = "asd.txt";

            fp.ProcessFile(fileName);
        }

        [TestMethod]
        public void TestFileJSON()//существующий json файл
        {
            FileProcessor fp = new FileProcessor();
            string fileName = "test.json";
            string expected = "Содержимое файла json";

            fp.ProcessFile(fileName);

            string actual = fp.parseText;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFileHTML()//существующий html файл
        {
            FileProcessor fp = new FileProcessor();
            string fileName = "test.html";
            string expected = "Содержимое файла html";

            fp.ProcessFile(fileName);

            string actual = fp.parseText;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFile_NotExistsFormat()//файл с незаявленным форматом
        {
            FileProcessor fp = new FileProcessor();
            string fileName = "test.doc";

            fp.ProcessFile(fileName);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFileWithNoFormat()//файл с некорректным названием
        {
            FileProcessor fp = new FileProcessor();
            string fileName = "txt";

            fp.ProcessFile(fileName);
        }

    }
}
