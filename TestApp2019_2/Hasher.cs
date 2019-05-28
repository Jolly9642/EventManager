using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TestApp2019_2
{
    public static class Hasher
    {
        //size of salt and constant because this doesn't need to change. 
        private const int SaltSize = 16;

        //size of hash and constant because this doesn't need to change. 
        private const int HashSize = 20;


        public static string Hash(string password)
        {
            // salt
            int iterations = 10000;
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);

            // combine salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            //format hash
            return  iterations.ToString() +"$"+ base64Hash.ToString();
        }

        public static bool Verify(string password, string hashedPassword)
        {
            

            // extract password and base64 string
            var splittedHashString = hashedPassword.Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            // get hash bytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            // get salt
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // make hash with the salt. 
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // result
            for (var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
