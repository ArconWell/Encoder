using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ciphers;

namespace CaesarCipherTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DecryptionTest()
        {
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual("АбВгдеЁжЗюЯё", cipher.Decrypt("ДеЖзийЁкЛвГё", 4, "Cyrillic"));
            Assert.AreEqual("AbCdefGhIjKl", cipher.Decrypt("EfGhijKlMnOp", 4, "Latin"));
        }

        [TestMethod]
        public void EncryptionTest()
        {
            CaesarCipher cipher = new CaesarCipher();
            Assert.AreEqual("ДеЖзийЁкЛвГё", cipher.Encrypt("АбВгдеЁжЗюЯё", 4, "Cyrillic"));
            Assert.AreEqual("EfGhijKlMnOp", cipher.Encrypt("AbCdefGhIjKl", 4, "Latin"));
        }
    }
}
