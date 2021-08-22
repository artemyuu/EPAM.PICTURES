using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.ENTITIES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EPAM.PICTURES.DAL
{
    public class UserDAO : IUserDAO
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public bool Create(User newUser)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "CreateUser";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                AddCommandParamsToUser(command, newUser);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool DeleteById(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "DeleteUser";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", id);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetAllUsers";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return CreateUserFromReader(reader);
                }
            }
        }

        public User GetById(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetUserById";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", id);

                _connection.Open();

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return CreateUserFromReader(reader);
                }

                throw new InvalidOperationException("Cannot find user with id = " + id);
            }
        }

        public bool UpdateUserByUsername(string username, User newUser)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "UpdateUser";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@oldusername", username);
                AddCommandParamsToUser(command, newUser);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        private User CreateUserFromReader(SqlDataReader reader)
        {
            return new User(
                (int)reader["Id"],
                (string)reader["Name"],
                (string)reader["Surname"],
                (string)reader["Email"],
                (string)reader["Username"],
                (string)reader["Password"],
                (int)reader["Role"],
                (DateTime)reader["DateOfBirth"],
                (DateTime)reader["RegistrationDate"],
                (string)reader["Image"]);
        }

        private void AddCommandParamsToUser(SqlCommand command, User user)
        {
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@surname", user.Surname);
            command.Parameters.AddWithValue("@role", user.Role);
            command.Parameters.AddWithValue("@dateOfBirth", user.DateOfDirth);
            command.Parameters.AddWithValue("@registrationDate", user.RegistrationDate);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@image", user.Image);
        }

        public User Authentication(string email, string password)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "AuthenticationUser";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                _connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return CreateUserFromReader(reader);
                }

                throw new InvalidOperationException("Cannot find user with email = " + email + " and password = " + password);
            }
        }

        public User GetByUsername(string username)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetUserByUsername";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@username", username);

                _connection.Open();

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return CreateUserFromReader(reader);
                }

                throw new InvalidOperationException("Cannot find user with username = " + username);
            }
        }
    }
}
