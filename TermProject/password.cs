using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.Globalization;

namespace TermProject{
    public static class password{

        public static string hashPassword(SHA512 sha512Hash, string password){
            byte[] data = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder hashedPassword = new StringBuilder();
            for (int i = 0;i<data.Length;i++){
                hashedPassword.Append(data[i].ToString("x2"));
            }
            return hashedPassword.ToString();
        }

        public static bool checkPassword(SHA512 sha512Hash, string password, string hashedPassword){
            if(hashPassword(sha512Hash, password) == hashedPassword){
                return true;
            }else{
                return false;
            }
        }
    }
}