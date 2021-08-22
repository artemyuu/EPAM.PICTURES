using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.ENTITIES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EPAM.PICTURES.DAL
{
    public class PublicationDAO : IPublicationDAO
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public bool AddLike(int publicationId, int userId)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "AddLikePublication";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@publicationId", publicationId);
                command.Parameters.AddWithValue("@userId", userId);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool CheckLike(int publicationId, int userId)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "CheckLikePublication";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@publicationId", publicationId);
                command.Parameters.AddWithValue("@userId", userId);

                _connection.Open();

                var result = command.ExecuteScalar();

                return (int)result > 0;
            }
        }

        public bool Create(Publication newPublication)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "CreatePublication";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@author", newPublication.Author.Id);
                command.Parameters.AddWithValue("@title", newPublication.Title);
                command.Parameters.AddWithValue("@description", newPublication.Description);
                command.Parameters.AddWithValue("@image", newPublication.Image);
                command.Parameters.AddWithValue("@dateOfCreation", newPublication.DateOfCreation);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool DeleteById(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "DeletePublication";

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

        public bool DeleteLike(int publicationId, int userId)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "DeleteLikePublication";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@publicationId", publicationId);
                command.Parameters.AddWithValue("@userId", userId);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public IEnumerable<Publication> GetAll()
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetAllPublications";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Publication(
                        (int)reader["Id"],
                        (int)reader["UserId"],
                        (string)reader["Title"],
                        (string)reader["Description"],
                        (string)reader["Image"],
                        (DateTime)reader["DateOfCreation"]);
                }
            }
        }

        public Publication GetById(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetPublicationById";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", id);

                _connection.Open();

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Publication(
                        (int)reader["Id"],
                        (int)reader["UserId"],
                        (string)reader["Title"],
                        (string)reader["Description"],
                        (string)reader["Image"],
                        (DateTime)reader["DateOfCreation"]
                        );
                }

                throw new InvalidOperationException("Cannot find publication with id = " + id);
            }
        }

        public IEnumerable<Publication> GetByPage(int page)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetPublicationByPage";

                int LIMIT = 6;
                int OFFSET = LIMIT * (page - 1);

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@limit", LIMIT);
                command.Parameters.AddWithValue("@offset", OFFSET);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Publication(
                        (int)reader["Id"],
                        (int)reader["UserId"],
                        (string)reader["Title"],
                        (string)reader["Description"],
                        (string)reader["Image"],
                        (DateTime)reader["DateOfCreation"]);
                }
            }
        }

        public int GetLikeCountByPublicationId(int publicationId)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetCountLikesByPublicationId";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@publicationId", publicationId);

                _connection.Open();

                var result = command.ExecuteScalar();

                return (int)result;
            }
        }

        public IEnumerable<Publication> GetPublicationsByTitle(string title)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetPublicationsByTitle";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@title", title);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Publication(
                        (int)reader["Id"],
                        (int)reader["UserId"],
                        (string)reader["Title"],
                        (string)reader["Description"],
                        (string)reader["Image"],
                        (DateTime)reader["DateOfCreation"]);
                }
            }
        }

        public IEnumerable<Publication> GetPublicationsByUserId(int userId)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetAllPublicationsByUserId";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userId", userId);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Publication(
                        (int)reader["Id"],
                        (int)reader["UserId"],
                        (string)reader["Title"],
                        (string)reader["Description"],
                        (string)reader["Image"],
                        (DateTime)reader["DateOfCreation"]);
                }
            }
        }

        public bool UpdateById(Publication publication)
        {
            throw new System.NotImplementedException();
        }
    }
}
