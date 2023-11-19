using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorevKU.Sprint5.Task3.V12.Lib;
namespace Tyuiu.GrigorevKU.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\dmitr\source\repos\Tyuiu.GrigorevKU.Sprint5\Tyuiu.GrigorevKU.Sprint5.Task3.V12\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}
