using System;

namespace CipherBase.Services
{
    internal interface ICipher
    {
        string encode(string text, string key = null);
        string decode(string text, string key = null);
    }

    abstract class CipherData
    {
        protected string alphabetBase = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        public string getAlphabetBase() => alphabetBase;    
    }
}
