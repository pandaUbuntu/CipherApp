using System;
using CipherBase.Services;

namespace Cipher.Services
{
    internal class Cesar : CipherData, ICipher
    {
        private int checkIndexEncode(int index, int key)
        {
            int count = this.alphabetBase.Length - 1;

            if (index + key > count)
                return Math.Abs(count - (index + key - 1));
            
            return index + key;
        }

        private int checkIndexDecode(int index, int key)
        {
            int count = this.alphabetBase.Length - 1;

            if (index - key < 0)
                return Math.Abs(count + (index - key + 1));

            return Math.Abs(index - key);

        }

        public string decode(string text, string key = null)
        {
            string result = "";
            int keyInt = Convert.ToInt32(((string)key));

            foreach (char c in text)
            {
                if (c == ' ' || c == ',' || c == '.')
                {
                    result += c;
                }
                else
                {
                    result += this.alphabetBase[checkIndexDecode(this.alphabetBase.IndexOf(c), keyInt)];
                }
            }

            return result;
        }

        public string encode(string text, string key = null)
        {
            int keyInt = 0;

            if (!int.TryParse(key, out keyInt))
            {
                throw new Exception("Помилка! Неправильний тип ключа!");
            }

            string result = "";
      
            foreach (char c in text)
            {
                if (c == ' ' || c == ',' || c == '.')
                {
                    result += c;
                } else
                {
                    int test = checkIndexEncode(this.alphabetBase.IndexOf(c), keyInt);
                    result += this.alphabetBase[checkIndexEncode(this.alphabetBase.IndexOf(c), keyInt)];
                }
            }

            return result;
        }
    }
}
