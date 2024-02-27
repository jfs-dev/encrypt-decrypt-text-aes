using System.Security.Cryptography;
using System.Text;

namespace encrypt_decrypt_text_aes.Services;

public class CryptographyService(string keyString, string ivString)
{
    private readonly byte[] key = Encoding.UTF8.GetBytes(keyString);
    private readonly byte[] iv = Encoding.UTF8.GetBytes(ivString);

    public byte[] Encrypt(string text)
    {
        byte[] encryptedText;

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using MemoryStream msEncrypt = new();
            using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
            using (StreamWriter swEncrypt = new(csEncrypt))
            {
                swEncrypt.Write(text);
            }
            
            encryptedText = msEncrypt.ToArray();
        }

        return encryptedText;
    }

    public string Decrypt(byte[] encryptedText)
    {
        string decryptedText = string.Empty;

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using MemoryStream msDecrypt = new(encryptedText);
            using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
            using StreamReader srDecrypt = new(csDecrypt);
            decryptedText = srDecrypt.ReadToEnd();
        }

        return decryptedText;
    }
}