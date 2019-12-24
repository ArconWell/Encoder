using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphers
{
    public class CaesarCipher2 /*: ICipher*/
    {
        static List<char> cirilAlphabetUpper = new List<char>();
        static List<char> cirilAlphabetLower = new List<char>();
        static CaesarCipher2()//сработает только при первом создании объекта класса или при первом обращении к статическим членам класса
        {
            for (int i = 1040; i <= 1071; i++)
            {
                cirilAlphabetUpper.Add((char)i);
                if (i == 1045)
                    cirilAlphabetUpper.Add((char)1025);
            }
            for (int i = 1072; i <= 1103; i++)
            {
                cirilAlphabetLower.Add((char)i);
                if (i == 1077)
                    cirilAlphabetLower.Add((char)1105);
            }
        }
        public string Encrypt(string sourceText, int shift, string dictionaryLanguage)
        {
            StringBuilder sourceTextSB = new StringBuilder(sourceText);
            List<char> upperAlphabet, lowerAlphabet;
            if (string.Compare(dictionaryLanguage, "Cyrillic", StringComparison.OrdinalIgnoreCase) == 0)
            {
                upperAlphabet = new List<char>(cirilAlphabetUpper);
                lowerAlphabet = new List<char>(cirilAlphabetLower);
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
