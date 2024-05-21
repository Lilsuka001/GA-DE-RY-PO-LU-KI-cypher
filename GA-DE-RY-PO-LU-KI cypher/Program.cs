using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Ala has a cat";
            Encode(inputString);
        }
        private static Dictionary<char, char> cipher = new Dictionary<char, char>()
            {
            {'G', 'A'}, {'A', 'G'}, {'g', 'a'}, {'a', 'g'},
            {'D', 'E'}, {'E', 'D'}, {'d', 'e'}, {'e', 'd'},
            {'R', 'Y'}, {'Y', 'R'}, {'r', 'y'}, {'y', 'r'},
            {'P', 'O'}, {'O', 'P'}, {'p', 'o'}, {'o', 'p'},
            {'L', 'U'}, {'U', 'L'}, {'l', 'u'}, {'u', 'l'},
            {'K', 'I'}, {'I', 'K'}, {'k', 'i'}, {'i', 'k'}

            };
        public static string Encode(string str)
        {


            StringBuilder encryptedStr = new StringBuilder();

            foreach (char c in str)
            {
                if (cipher.ContainsValue(c))
                {
                    encryptedStr.Append(cipher[c]);
                }
                else
                {
                    encryptedStr.Append(c);
                }
            }
            return encryptedStr.ToString();
        }

        public static string Decode(string str)
        {

            StringBuilder encryptedStr = new StringBuilder();
            foreach (char c in str)
            {
                if (cipher.ContainsValue(c))
                {
                    encryptedStr.Append(cipher[c]);
                }
                else
                {
                    encryptedStr.Append(c);
                }
            }
            return encryptedStr.ToString();
        }

    }
}