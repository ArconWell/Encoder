using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ciphers;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher cipher = new CaesarCipher();
            Stopwatch sw = new Stopwatch();
            sw.Start();
           // cipher.Encrypt("АбВгдеЁжЗюЯё", 4, "Cyrillic");
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine(ts);
            Console.WriteLine(cipher.Encrypt("АбВгдеЁжЗюЯё", 4, "Cyrillic"));
            Console.WriteLine(cipher.Encrypt("AbCdefGhIjKl", 4, "Latin"));
            Console.WriteLine(cipher.Decrypt("ДеЖзийЁкЛвГё", 4, "Cyrillic"));
            Console.WriteLine(cipher.Decrypt("EfGhijKlMnOp", 4, "Latin"));
            Console.ReadLine();
        }
    }
}
