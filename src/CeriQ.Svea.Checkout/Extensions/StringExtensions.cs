using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class StringExtensions
    {
        public static String ToSveaAuthorizationHeader(this String body, string merchantId, string sharedSecret, DateTime dateTime)
        {
            byte[] hash;
            string hashString = body + sharedSecret + dateTime.ToSveaString();
            using (var sha = new System.Security.Cryptography.SHA512Managed())
            {
                hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(hashString));
            }
            StringBuilder hashHexSb = new StringBuilder();
            foreach (var b in hash)
            {
                hashHexSb.Append(String.Format("{0:x2}", b));
            }
            return $"Svea {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{merchantId}:{hashHexSb.ToString()}"))}";
        }
    }
}
