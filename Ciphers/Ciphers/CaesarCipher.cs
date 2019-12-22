using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    /// <summary>
    /// Класс, реализующий шифрование текста при помощи шифра Цезаря, а также расшифрование текста и взлом ключа по тексту,
    /// зашифрованных при помощи шифра Цезаря.
    /// </summary>
    public class CaesarCipher : ICipher
    {
        #region Encrypt

        /// <summary>
        /// Зашифровывает строку.
        /// </summary>
        /// <param name="sourceText">Исходная строка</param>
        /// <param name="shift">Сдвиг вперёд по алфавиту каждого символа в строке</param>
        /// <param name="dictionaryLanguage">Язык алфавита</param>
        /// <returns>Зашифрованная строка</returns>
        public string Encrypt(string sourceText, int shift, string dictionaryLanguage)
        {
            StringBuilder sourceTextSB = new StringBuilder(sourceText);
            int firstLetterUpperCase, lastLetterUpperCase, firstLetterLowerCase, lastLetterLowerCase, additionalLetterUpperCase,
                additionalLetterLowerCase;
            SetAlphabetBorders(dictionaryLanguage, out firstLetterUpperCase, out lastLetterUpperCase, out firstLetterLowerCase,
                out lastLetterLowerCase, out additionalLetterUpperCase, out additionalLetterLowerCase);
            if (shift > lastLetterUpperCase - firstLetterUpperCase)//можно также сравнить и по нижнему регистру, но это равнозначно
                throw new Exception("Максимальный сдвиг больше, длина алфавита языка минус 1");
            for (int i = 0; i < sourceTextSB.Length; i++)
            {
                if (Char.IsLetter(sourceTextSB[i]) && sourceTextSB[i] != additionalLetterLowerCase && sourceTextSB[i] != additionalLetterUpperCase)
                //здесь дополнительно проверям не является ли буква "исключением". Если является, то просто пропускаем её(для кириллицы - "Ё" и "ё")
                {
                    int leftBorder, rightBorder;
                    if (char.IsUpper(sourceTextSB[i]))
                    {
                        leftBorder = firstLetterUpperCase;
                        rightBorder = lastLetterUpperCase;
                    }
                    else
                    {
                        leftBorder = firstLetterLowerCase;
                        rightBorder = lastLetterLowerCase;
                    }
                    sourceTextSB[i] = EncryptCharShift(sourceTextSB[i], shift, leftBorder, rightBorder);
                }
            }
            return sourceTextSB.ToString();
        }

        /// <summary>
        /// Заменяет символ на другой символ дальше по алфавиту с заданным сдвигом.
        /// </summary>
        /// <param name="letter">Исходный(заменяемый) символ</param>
        /// <param name="shift">Сдвиг - количество символов, на которое нужно сместить исходный</param>
        /// <param name="bordersArray">Границы алфавита в UNICODE, которому принадлежит символ. Массив должен состоять из двух элементов: первый - левая граница; второй - правая граница</param>
        /// <returns>Новый получившийся символ</returns>
        private char EncryptCharShift(char letter, int shift, params int[] bordersArray)
        {
            int letterNumber = (int)letter;
            int newLetter = letterNumber + shift;
            if (newLetter > bordersArray[1])
                newLetter = (bordersArray[0] - 1) + (shift - (bordersArray[1] - letterNumber));//"-1" используется для того, чтобы имитировать
                                                                                               //переход с последней буквы алфавита на первую букву алфавита, так как без "-1" буква преобразуется в следующую за той, которая должна была бы быть
            return (char)newLetter;
        }

        #endregion

        #region Decrypt

        /// <summary>
        /// Расшифровывает строку.
        /// </summary>
        /// <param name="cipherText">Зашифрованная строка</param>
        /// <param name="shift">Сдвиг назад по алфавиту каждого символа в строке</param>
        /// <param name="dictionaryLanguage">Язык алфавита</param>
        /// <returns>Расшифрованная строка</returns>
        public string Decrypt(string cipherText, int shift, string dictionaryLanguage)
        {
            StringBuilder cipherTextSB = new StringBuilder(cipherText);
            int firstLetterUpperCase, lastLetterUpperCase, firstLetterLowerCase, lastLetterLowerCase, additionalLetterUpperCase,
              additionalLetterLowerCase;
            SetAlphabetBorders(dictionaryLanguage, out firstLetterUpperCase, out lastLetterUpperCase, out firstLetterLowerCase,
                out lastLetterLowerCase, out additionalLetterUpperCase, out additionalLetterLowerCase);
            if (shift > lastLetterUpperCase - firstLetterUpperCase)
                throw new Exception("Максимальный сдвиг равен длине алфавита языка минус 1");
            for (int i = 0; i < cipherTextSB.Length; i++)
            {
                if (Char.IsLetter(cipherTextSB[i]) && cipherTextSB[i] != additionalLetterLowerCase && cipherTextSB[i] != additionalLetterUpperCase)
                //здесь дополнительно проверям не является ли буква "исключением". Если является, то просто пропускаем её(для кириллицы - "Ё" и "ё")
                {
                    int leftBorder, rightBorder;
                    if (char.IsUpper(cipherTextSB[i]))
                    {
                        leftBorder = firstLetterUpperCase;
                        rightBorder = lastLetterUpperCase;
                    }
                    else
                    {
                        leftBorder = firstLetterLowerCase;
                        rightBorder = lastLetterLowerCase;
                    }
                    cipherTextSB[i] = DecryptCharShift(cipherTextSB[i], shift, leftBorder, rightBorder);
                }
            }
            return cipherTextSB.ToString();
        }

        /// <summary>
        /// Заменяет символ на другой символ раньше по алфавиту с заданным сдвигом.
        /// </summary>
        /// <param name="letter">Заменяемый символ</param>
        /// <param name="shift">Сдвиг - количество символов, на которое нужно сместить исходны</param>
        /// <param name="bordersArray">Границы алфавита в UNICODE, которому принадлежит символ. Массив должен состоять из двух элементов: первый - левая граница; второй - правая граница</param>
        /// <returns>Новый получившийся символ</returns>
        private char DecryptCharShift(char letter, int shift, params int[] bordersArray)
        {
            int letterNumber = (int)letter;
            int newLetter = letterNumber - shift;
            if (newLetter < bordersArray[0])
                newLetter = (bordersArray[1] + 1) - (shift - (letterNumber - bordersArray[0]));//"+1" используется для того, чтобы имитировать
                                                                                               //переход с первой буквы алфавита на последнюю букву алфавита, так как без "+1" буква преобразуется в предыдущую той, которая должна была бы быть
            return (char)newLetter;
        }

        #endregion

        #region Hack

        /// <summary>
        /// Расшифровывает строку, взломав шифр Цезаря.
        /// </summary>
        /// <param name="cipherText">Зашифрованная строка</param>
        /// <param name="dictionaryLanguage">Язык алфавита</param>
        /// <returns>Расшифрованная строка</returns>
        public string Hack(string cipherText, string dictionaryLanguage)
        {

        }

        #endregion

        /// <summary>
        /// Устанавливает границы алфавита в зависимости от указанного языка.
        /// </summary>
        /// <param name="dictionaryLanguage">Язык алфавита.</param>
        /// <param name="firstLetterUpperCase">Номер первой буквы алфавита верхнего регистра в десятичном виде в UNICODE</param>
        /// <param name="lastLetterUpperCase">Номер последней буквы алфавита верхнего регистра в десятичном виде в UNICODE</param>
        /// <param name="firstLetterLowerCase">Номер первой буквы алфавита нижнего регистра в десятичном виде в UNICODE</param>
        /// <param name="lastLetterLowerCase">Номер последней буквы алфавита нижнего регистра в десятичном виде в UNICODE</param>
        /// <param name="additionalLetterUpperCase">Дополнительная буква верхнего регистра(если она находится не рядом с основным алфавитом в UNICODE)</param>
        /// <param name="additionalLetterLowerCase">Дополнительная буква нижнего регистра(если она находится не рядом с основным алфавитом в UNICODE)</param>
        private void SetAlphabetBorders(string dictionaryLanguage, out int firstLetterUpperCase, out int lastLetterUpperCase,
            out int firstLetterLowerCase, out int lastLetterLowerCase, out int additionalLetterUpperCase, out int additionalLetterLowerCase)
        {
            if (string.Compare(dictionaryLanguage, "Cyrillic", StringComparison.OrdinalIgnoreCase) == 0)//если исходный текст на кириллице
            {
                firstLetterUpperCase = 1040;
                lastLetterUpperCase = 1071;
                firstLetterLowerCase = 1072;
                lastLetterLowerCase = 1103;
                additionalLetterUpperCase = 1025;//для букв "Ё" и "ё", так как они расположены в UNICODE отдельно от остальных букв алфавита
                additionalLetterLowerCase = 1105;
            }
            else
            {
                if (string.Compare(dictionaryLanguage, "Latin", StringComparison.OrdinalIgnoreCase) == 0)//если исходный текст на латинице
                {
                    firstLetterUpperCase = 65;
                    lastLetterUpperCase = 90;
                    firstLetterLowerCase = 97;
                    lastLetterLowerCase = 122;
                    additionalLetterUpperCase = default;
                    additionalLetterLowerCase = default;
                }
                else
                {
                    throw new Exception("Несовместимый язык.");
                }
            }
        }
    }
}
