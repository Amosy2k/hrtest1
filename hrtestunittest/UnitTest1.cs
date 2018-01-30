using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hrtest;
using System.Collections.Generic;
using System.IO;

namespace hrtestunittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Class_DBlink()
        {
            var dblink = new TestMain();
            var dblinkexpected = "ture";
            var dblinkfunction = dblink.Dblinkmethod();
            Assert.AreEqual(dblinkexpected, dblinkfunction);
        }
        [TestMethod]
        public void Class_Upload()
        {
            var upload = new TestMain();
            var uploadexpected = "ture";
            string fileName = "test.txt";
            string sourcePath = @"C:\test1";
            string targetPath = @"C:\test2";
            var uploadfunction = upload.Uploadmethod(fileName, sourcePath, targetPath);
            Assert.AreEqual(uploadexpected, uploadexpected);
        }


    }
}
