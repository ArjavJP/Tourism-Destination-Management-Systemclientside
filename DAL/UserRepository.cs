using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    public class UserRepository
    {

        private readonly SqlConnection _connection;

        public UserRepository()
        {
            _connection = DbConnection.Instance;
        }

        public DataTable Login(string email, string password)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM UserMst WHERE Name=@Email AND Password=@Password", _connection))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                _connection.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                _connection.Close();
                return dt;
            }
        }

        public int UserInsert(UserMst user)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO UserMst (Password,Name,PhoneNo,Address,isAdmin) VALUES (@Password,@Name,@PhoneNo,@Address,@isAdmin)", _connection))
            {
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@PhoneNo", user.PhoneNo);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.isAdmin);
                _connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                _connection.Close();
                return rowsAffected;
            }
        }
    }
}
