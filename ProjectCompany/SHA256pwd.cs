using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    class SHA256pwd
    {
        public string SHA256HexHashString(string pwdIn)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
      
                byte[] sourceBytes = Encoding.UTF8.GetBytes(pwdIn);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }
    }
}
