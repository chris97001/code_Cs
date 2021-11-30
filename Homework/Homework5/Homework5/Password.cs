using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class PasswordSubstituter
    {
        public String Alphabet;
        public String Substitution;
        public PasswordSubstituter()
        {
            Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Substitution = Alphabet;
        }
        public void Generate()
        {
            Random rnd = new Random();
            bool[] hasUsed = new bool[52];
            for (int i = 0; i < 52; i++){
                hasUsed[i] = false;
            }
            Substitution = "";
            for(int i = 0; i < 52; i++)
            {
                int a = rnd.Next(0, 52);
                while (hasUsed[a])
                {
                    if (a >= 51){
                        a = 0;
                        continue;
                    }else{
                        a++;
                    }
                }
                hasUsed[a] = true;
                Substitution += Alphabet[a];
            }
        }
        public bool IsValid(String crypto)
        {
            if (crypto.Length != Alphabet.Length){
                return false;
            }

            int[] letterCount = new int[100];
            for(int i = 0; i < 100; i++){
                letterCount[i] = 0;
            }
            for(int i = 0; i < crypto.Length; i++)
            {
                letterCount[crypto[i]-'A']++;
                if (letterCount[crypto[i] - 'A'] >= 2){
                    return false;
                }
            }
            return true;
        }
        public String Encrypt(String text)
        {
            String Crypto = "";
            for (int i = 0; i < text.Length; i++) 
            {
                if (('Z' >= text[i] && text[i] >= 'A') || ('z' >= text[i] && text[i] >= 'a'))
                    Crypto += Substitution[Alphabet.IndexOf(text[i])];
                else
                    Crypto += text[i];
            }
            return Crypto;
        }
        public String Decrypt(String text)
        {
            String Decrypto = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (('Z' >= text[i] && text[i] >= 'A') || ('z' >= text[i] && text[i] >= 'a'))
                    Decrypto += Alphabet[Substitution.IndexOf(text[i])];
                else
                    Decrypto += text[i];
            }
            return Decrypto;
        }
    }
}
