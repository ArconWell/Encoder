using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    interface ICipher
    {
        string Encrypt(string sourceText, int shift, string dictionaryLanguage);
        string Decrypt(string sourceText, int shift, string dictionaryLanguage);
        string Hack(string sourceText, string dictionaryLanguage);
    }
}
