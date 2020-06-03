 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace  WebApp.Models
{
    public class Cript
    {
        private TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();

        public Cript(string key)
        {

            TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8);
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
        }
        public Cript()
        {
             
        }
        private byte[] TruncateHash(string key, int length)
        {
            using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
            {
                byte[] keyBytes = System.Text.Encoding.Unicode.GetBytes(key);
                byte[] hash = sha1.ComputeHash(keyBytes);
                Array.Resize(ref hash, length);
                return hash;
            }

        }
        private static byte[] TruncateHash2(string key, int length)
        {
            using (SHA256CryptoServiceProvider sha1 = new SHA256CryptoServiceProvider())
            {
                byte[] keyBytes = System.Text.Encoding.Unicode.GetBytes(key);
                byte[] hash = sha1.ComputeHash(keyBytes);
                Array.Resize(ref hash, length);
                return hash;
            }
        }
        public string EncryptData(string plaintext)
        {
            byte[] plaintextBytes = System.Text.Encoding.Unicode.GetBytes(plaintext);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream encStream = new CryptoStream(ms, TripleDes.CreateEncryptor(), CryptoStreamMode.Write);
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
            encStream.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }
        public string GetSing(string value)
        {
            return "";
        }

        public string DecryptData(string encryptedtext)
        {
            // Debug.Write("DecryptData(string encryptedtext)     " + encryptedtext);
            byte[] encryptedBytes = Convert.FromBase64String(encryptedtext);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream decStream = new CryptoStream(ms, TripleDes.CreateDecryptor(), CryptoStreamMode.Write);
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            decStream.FlushFinalBlock();
            return System.Text.Encoding.Unicode.GetString(ms.ToArray());
        }
    }
}