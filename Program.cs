using System;
using System.IO;

namespace Ascii_To_Binary
{
    internal class Program
    {
        static void AsciiToBinary(string text)
        {
            string binaryText = "";
            for(int i = 0; i < text.Length; i++)
            {
                binaryText += DecimnalToBinary(text[i]) + " ";
            }
            File.WriteAllText(@"filename.txt", binaryText);
        }
        static string DecimnalToBinary(int num)
        {
            string binaryStringTemp = "";
            while(num > 0)
            {
                binaryStringTemp += num % 2;
                num /= 2;
            }
            for(int i = binaryStringTemp.Length; i < 8; i++)
            {
                binaryStringTemp += "0";
            }
            // Reverse
            string binaryString = "";
            for(int i = 0; i < binaryStringTemp.Length; i++)
            {
                binaryString += binaryStringTemp[binaryStringTemp.Length - i - 1];
            }
            return binaryString;
        }
        static void Main(string[] args)
        {
        }
    }
}
