﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorevKU.Sprint5.Task7.V3.Lib;
namespace Tyuiu.GrigorevKU.Sprint5.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V3.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}
