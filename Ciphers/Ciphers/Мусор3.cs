using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    class Class1
    {
        //Dictionary<char, double> cipherTextLettersProbabilities = new Dictionary<char, double>();
        //char mostFrequentLetterInAlphabet = GetMostFrequentAlphabetLetter(dictionaryLanguage);
        //int firstLetterUpperCase, lastLetterUpperCase, firstLetterLowerCase, lastLetterLowerCase, additionalLetterUpperCase,
        //   additionalLetterLowerCase;
        //SetAlphabetBorders(dictionaryLanguage, out firstLetterUpperCase, out lastLetterUpperCase, out firstLetterLowerCase,
        //    out lastLetterLowerCase, out additionalLetterUpperCase, out additionalLetterLowerCase);     
        //foreach (char letter in cipherText.ToLower().ToCharArray())
        //{
        //    if (char.IsLetter(letter))
        //    {
        //        if(cipherTextLettersProbabilities.ContainsKey(letter))
        //        //тут высчитываю сколько каждый раз каждой буква встретилась в тексте
        //        {
        //            double probabilityValue;
        //            cipherTextLettersProbabilities.TryGetValue(letter, out probabilityValue);
        //            cipherTextLettersProbabilities[letter] = (probabilityValue + 1);
        //        }
        //        else
        //        {
        //            cipherTextLettersProbabilities.Add(letter, 1);
        //        }
        //    }
        //}
        //char cipherTextLetterWithMaxProbability = cipherTextLettersProbabilities.First(x => x.Value == cipherTextLettersProbabilities.Values.Max()).Key;
        ////в этом выражении я нахожу Key для максимального Value в словаре
        //int shift;
        //if ((int)cipherTextLetterWithMaxProbability >= (int)mostFrequentLetterInAlphabet)
        ////определяю с какой сторны от самой часто встречающейся буквы алфавита находится самая часто встречающаяся буква зашифрованного текста,
        ////чтобы определить как высчитывать сдвиг
        //{
        //    shift = (int)cipherTextLetterWithMaxProbability - (int)mostFrequentLetterInAlphabet;
        //}
        //else
        //{
        //    shift = ((int)lastLetterLowerCase - (int)mostFrequentLetterInAlphabet) + ((int)cipherTextLetterWithMaxProbability - (int)firstLetterLowerCase) + 1;
        //    //здесь "+1" снова для того, чтобы имитировать переход с последней буквы алфавита на первую
        //}
        //return this.Decrypt(cipherText, shift, dictionaryLanguage);
    }
}
