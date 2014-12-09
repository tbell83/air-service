using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace ECommerceLibrary
{
    public class Serialize
    {
        DBConnect objDB = new DBConnect();

        // This function uses binary serialization to serialize an Object to a MemoryStream
        public MemoryStream SerializeToMemoryStream(Object objToSerialize)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, objToSerialize);
            return memoryStream;
        }

        // This function uses binary deserialization to reconstruct an Object from a MemoryStream
        public Object DeserializeFromMemoryStream(MemoryStream memoryStream)
        {
            BinaryFormatter deserializer = new BinaryFormatter();
            Object deserializedObject;
            memoryStream.Position = 0;
            deserializedObject = deserializer.Deserialize(memoryStream);
            return deserializedObject;
        }

        // This function uses binary serialization to serialize an Object to a Byte Array
        public Byte[] SerializeToByteArray(Object objToSerialize)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            Byte[] byteArray;
            serializer.Serialize(memoryStream, objToSerialize);
            byteArray = memoryStream.ToArray();
            return byteArray;
        }

        // This function uses binary deserialization to reconstruct an Object from a Byte Array
        public Object DeserializeFromByteArray(Byte[] byteArray)
        {
            BinaryFormatter deserializer = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream(byteArray);
            Object deserializedObject;
            deserializedObject = deserializer.Deserialize(memoryStream);
            return deserializedObject;
        }

        public int GetCustomerIDFromEmail(string email)
        {
            DataSet ds = new DataSet();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = "GetCustomerIDFromEmail"; 
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@email", email);
            ds = objDB.GetDataSetUsingCmdObj(objCommand);

            int custID = Convert.ToInt32(ds.Tables[0].Rows[0]["customerID"]);
            return custID;
        }

        // This function writes the cart to the database.
        public int WriteTransactionToDB(Object cart, int customerID)
        {
            // First, you must create a Stored Procedure, "UpdateCart" that will provide the
            // functionality to store the byte array for an object in your database
            Byte[] byteArray;
            SqlCommand objCommand = new SqlCommand();
            int returnValue;

            byteArray = SerializeToByteArray(cart);
            //this updates cart that already exists
            objCommand.CommandText = "WriteTransaction"; 
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@cart", byteArray);
            objCommand.Parameters.AddWithValue("@customerID", customerID);
            returnValue = objDB.DoUpdateUsingCmdObj(objCommand);
            return returnValue;
        }

        // This function writes the cart to the database.
        public int WriteCartToDB(Object cart, string email)
        {
            // First, you must create a Stored Procedure, "UpdateCart" that will provide the
            // functionality to store the byte array for an object in your database
            Byte[] byteArray;
            SqlCommand objCommand = new SqlCommand();
            int returnValue;

            byteArray = SerializeToByteArray(cart);
            //this updates cart that already exists
            objCommand.CommandText = "WriteCart"; // *** CHANGE NAME TO YOUR STORED PROCEDURE'S NAME
            objCommand.CommandType = CommandType.StoredProcedure;
   
            objCommand.Parameters.AddWithValue("@cart", byteArray);
            objCommand.Parameters.AddWithValue("@email", email);
            returnValue = objDB.DoUpdateUsingCmdObj(objCommand);
            return returnValue;
        }

        //inserts a cart record into tp_carts, leaving vacationPackage for that record empty
        public int CreateNewCart(string email) //returns -1 on failure
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = "CreateCart"; //will create a cart record with no vacationPackage for a customer
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.AddWithValue("@email", email);
            int returnValue = objDB.DoUpdateUsingCmdObj(objCommand);
            return returnValue;
        }

        //returns true or false for whether or not a cart record exists for user
        public bool CheckCartExists(string email) 
        {
            SqlCommand objCommand = new SqlCommand();
            DataSet ds;

            objCommand.CommandText = "ReadCart";
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@email", email);
            ds = objDB.GetDataSetUsingCmdObj(objCommand);
            if (ds.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        // This function reads the cart from the database.
        public Object ReadCartFromDB(string email) 
        {
            // First, you must provide a Stored Procedure named "ReadCart" that will return a byte array 
            SqlCommand objCommand = new SqlCommand();
            DataSet ds;
            Byte[] byteArray;

            objCommand.CommandText = "ReadCart";  
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@email", email);
            ds = objDB.GetDataSetUsingCmdObj(objCommand);
            DataRow record = ds.Tables[0].Rows[0];

            if (record["vacationPackage"] != DBNull.Value)
            {
                byteArray = (Byte[])record["vacationPackage"];
                return DeserializeFromByteArray(byteArray);
            }
            else
            {
                return null;
            }
        }

        // This function uses binary deserialization to deserialize an object that was previously stored it in a text file
        public Object ReadCartFromFile(String userlogin)
        {
            FileStream fs = null;
            BinaryFormatter deserializer = new BinaryFormatter();
            Object cart = null;

            try
            {
                fs = new FileStream("C:\\some_path" + userlogin + ".dat", FileMode.OpenOrCreate);

                if (fs.Length > 0)
                    cart = deserializer.Deserialize(fs);

                fs.Close();
                fs = null;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs = null;
                }
            }

            return cart;
        }

        // This function uses binary serialization to serialize an object and store it in a text file.
        public Boolean WriteCartToFile(Object cart, String userlogin)
        {
            FileStream fs = null;
            BinaryFormatter serializer = new BinaryFormatter();

            try
            {
                fs = new FileStream("C:\\some_path" + userlogin + ".dat", FileMode.Create);
                serializer.Serialize(fs, cart);
                fs.Close();
                fs = null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs = null;
                }
            }
        }

    }
}