using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashLib.LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashLib.LIB.Tests
{
    [TestClass()]
    public class ShaHashTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArgument()
        {
            ShaHash.GetHash(null);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroLenght()
        {
            ShaHash.GetHash("");
        }

        [TestMethod()]
        public void GetHash()
        {
            string plainText = "123123";
            string hash = "96cae35ce8a9b0244178bf28e4966c2ce1b8385723a96a6b838858cdd6ca0a1e";

            Assert.AreEqual(hash, ShaHash.GetHash(plainText));
        }
    }
}