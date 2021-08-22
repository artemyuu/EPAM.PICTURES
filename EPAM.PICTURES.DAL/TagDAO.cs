using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EPAM.PICTURES.DAL
{
    public class TagDAO : ITagDAO
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public bool Create(Tag newTag)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "CreateTag";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@title", newTag.Title);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool DeleteById(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "DeleteTag";

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

        public IEnumerable<Tag> GetAll()
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetAllTags";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Tag(
                        (int)reader["Id"],
                        (string)reader["Title"]
                        );
                }
            }
        }

        public Tag GetById(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetTagById";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", id);

                _connection.Open();

                var reader = command.ExecuteReader();

                return new Tag(
                    (int)reader["Id"],
                    (string)reader["Title"]
                    );
            }
        }

        public bool UpdateById(Tag tag)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "UpdateTag";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", tag.Id);
                command.Parameters.AddWithValue("@title", tag.Title);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }
    }
}
