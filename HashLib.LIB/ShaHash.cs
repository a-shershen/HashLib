using System;
using System.Security.Cryptography;

namespace HashLib.LIB
{
    public static class ShaHash
    {
        public static string GetHash(string plainText)
        {
            if(plainText==null)
            {
                throw new ArgumentNullException();
            }

            if(plainText=="")
            {
                throw new ArgumentException();
            }
            
            else
            {
                using (SHA256 sha = SHA256.Create())
                {
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(plainText);

                    buffer = sha.ComputeHash(buffer);

                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    foreach(byte b in buffer)
                    {
                        sb.Append(b.ToString("x2"));
                    }

                    return sb.ToString();
                }
            }
        }
    }
}
