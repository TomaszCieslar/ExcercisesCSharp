using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.MoreOnClasses
{
    public class MoreOnClassesEncrypter
    {
        public void Main()
        {


            string newText = Encrypter.Encrypt("Hola");
            Console.WriteLine(newText);

            string TextDescripted = Encrypter.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);

            Console.ReadLine();

        }
    }

    internal class Encrypter
    {

        public static string Encrypt(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {

                sb.Append(Encoding.ASCII.GetString(new byte[] { Convert.ToByte(text[i] + 1) }));

            }
            return sb.ToString();
        }

        public static string Decrypt(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {

                sb.Append(Encoding.ASCII.GetString(new byte[] { Convert.ToByte(text[i] - 1) }));

            }
            return sb.ToString();
        }


    }
}
