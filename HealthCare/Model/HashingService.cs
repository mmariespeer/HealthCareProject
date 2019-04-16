using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    class HashingService
    {
        public String PasswordHashing(string password)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            System.Security.Cryptography.SHA256Managed sha256string =
                new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256string.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }

        private string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach(byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}
