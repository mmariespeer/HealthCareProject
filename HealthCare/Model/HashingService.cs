using System;
using System.Text;


namespace HealthCare.Model
{
    /// <summary>
    /// Hashing service to verify hashed passwords
    /// </summary>
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

        //converts hashed passwords to appropriate hashed string
        //Developed using tutrial at https://youtu.be/AU-4oLUV5VU
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
