using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.Globalization;
using Utilities;
using System.Data;
using System.Data.SqlClient;

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

        private static bool checkPassword(SHA512 sha512Hash, string password, string hashedPassword){
            if(hashPassword(sha512Hash, password) == hashedPassword){
                return true;
            }else{
                return false;
            }
        }

        public static bool validateUser(string email, string password){
            SHA512 hash = SHA512.Create();
            return checkPassword(hash, password, getHashedPassword(email));
        }

        private static string getHashedPassword(string email){
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "getPassword";
            objCommand.Parameters.AddWithValue("@email", email);
            string hashedPassword = objDB.GetDataSetUsingCmdObj(objCommand).Tables[0].Rows[0][0].ToString();
            return hashedPassword;
        }
    }
}