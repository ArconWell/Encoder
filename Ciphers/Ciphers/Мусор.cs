using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    public class CaesarCipher1 /*: ICipher*/
    {
        static List<char> latinAlphabetUpper = new List<char>();
        static List<char> latinAlphabetLower = new List<char>();
        static CaesarCipher1()//сработает только при первом создании объекта класса или при первом обращении к статическим членам класса
        {
            for (int i = 65; i <= 90; i++)
                latinAlphabetUpper.Add((char)i);
            for (int i = 97; i <= 122; i++)
                latinAlphabetLower.Add((char)i);
        }
        public string Encrypt(string sourceText, int shift, string dictionaryLanguage)
        {
            StringBuilder sourceTextSB = new StringBuilder(sourceText);
            List<char> upperAlphabet, lowerAlphabet;
            if (string.Compare(dictionaryLanguage, "Latin", StringComparison.OrdinalIgnoreCase) == 0)
            {
                upperAlphabet = new List<char>(latinAlphabetUpper);
                lowerAlphabet = new List<char>(latinAlphabetLower);
            }
            else
            {
                throw new Exception("Некорректный язык.");
            }
            for (int i = 0; i < sourceTextSB.Length; i++)
            {
                if (char.IsLetter(sourceTextSB[i]))
                {
                    if (char.IsUpper(sourceTextSB[i]))
                    {
                        int oldCharIndex = upperAlphabet.IndexOf(sourceTextSB[i]);
                        int newCharIndex = oldCharIndex + shift;
                        if (newCharIndex > upperAlphabet.Count - 1)
                            newCharIndex = -1 + (shift - (upperAlphabet.Count - 1 - oldCharIndex));
                        sourceTextSB[i] = (char)newCharIndex;
                    }
                    else
                    {
                        int oldCharIndex = lowerAlphabet.IndexOf(sourceTextSB[i]);
                        int newCharIndex = oldCharIndex + shift;
                        if (newCharIndex > lowerAlphabet.Count - 1)
                            newCharIndex = -1 + (shift - (lowerAlphabet.Count - 1 - oldCharIndex));
                        sourceTextSB[i] = (char)newCharIndex;
                    }
                }
            }
            return sourceTextSB.ToString();
        }
    }
}