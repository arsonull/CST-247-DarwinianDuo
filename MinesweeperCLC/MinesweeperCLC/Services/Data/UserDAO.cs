using MinesweeperCLC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperCLC.Services.Data
{
    public class UserDAO
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Minesweeper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public UserData login(UserData user)
        {
            string stmt = "SELECT * FROM dbo.users WHERE Username = @Name AND Password = @Pass";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(stmt, conn);
                try
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@Name", user.Username);
                    command.Parameters.AddWithValue("@Pass", user.Password);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.FieldCount > 0)
                        return user;
                    else
                        return null;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public UserData register(UserData user)
        {
            string stmt = "INSERT dbo.users (Username, Password, FirstName, LastName, Sex, Age, State, Email, Score) VALUES (@Name, @Pass, @fName, @lName, @Sex, @Age, @State, @Email, 0)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(stmt, conn);
                try
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@Name", user.Username);
                    command.Parameters.AddWithValue("@Pass", user.Password);
                    command.Parameters.AddWithValue("@fName", user.FirstName);
                    command.Parameters.AddWithValue("@lName", user.LastName);
                    command.Parameters.AddWithValue("@Sex", user.Sex);
                    command.Parameters.AddWithValue("@Age", user.Age);
                    command.Parameters.AddWithValue("@State", user.State);
                    command.Parameters.AddWithValue("@Email", user.Email);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                        return user;
                    else
                        return null;
                    if (command.ExecuteNonQuery() > 0)
                        return user;
                    else
                        return null;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public List<UserData> getAllUsers()
        {
            string stmt = "SELECT * FROM dbo.users";
            List<UserData> userList = new List<UserData>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(stmt, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        userList.Add(new UserData((string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5], (int)reader[6], (string)reader[7], (string)reader[8],
                            (int)reader[9]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                return userList;
            }
        }
    }
}
