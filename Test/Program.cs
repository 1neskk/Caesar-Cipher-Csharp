using System;
using System.IO;

//Testing
class Program
{
    static string Encrypt(string text, int s)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsUpper(text[i]))
            {
                result += (char)(((int)text[i] + s - 65) % 26 + 65);
            }
            else
            {
                result += (char)(((int)text[i] + s - 97) % 26 + 97);
            }
        }
        return result;
    }

    static string Decrypt(string text, int s)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsUpper(text[i]))
            {
                result += (char)(((int)text[i] - s - 65) % 26 + 65);
            }
            else
            {
                result += (char)(((int)text[i] - s - 97) % 26 + 97);
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        string text = "ATTACKATONCE";
        int s = 5;
        Console.WriteLine("Text : " + text);
        Console.WriteLine("Shift : " + s);
        string encryptedText = Encrypt(text, s);
        Console.WriteLine("Encrypted Text : " + encryptedText);
        Console.WriteLine("Decrypted Text : " + Decrypt(encryptedText, s));
    }
}
