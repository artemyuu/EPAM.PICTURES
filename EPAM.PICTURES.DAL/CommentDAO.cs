using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.ENTITIES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EPAM.PICTURES.DAL
{
    public class CommentDAO : ICommentDAO
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public bool Create(Comment newComment)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "CreateComment";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@publication", newComment.PublicationId);
                command.Parameters.AddWithValue("@author", newComment.UserId);
                command.Parameters.AddWithValue("@dateOfCreation", newComment.DateOfCreation);
                command.Parameters.AddWithValue("@commentBody", newComment.CommentBody);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool DeleteByPublicationId(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "DeleteCommentByPublicationId";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@publicationId", id);

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public bool DeleteById(int id)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "DeleteComment";

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

        public IEnumerable<Comment> GetAllByPublicationId(int publicationId)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetAllCommentsByPublicationId";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@publicationId", publicationId);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Comment(
                        (int)reader["Id"],
                        (int)reader["PublicationId"],
                        (int)reader["UserId"],
                        (DateTime)reader["DateOfCreation"],
                        (string)reader["CommentBody"]
                        );
                }
            }
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateById(Comment comment)
        {
            throw new NotImplementedException();
        }

        public int GetCountCommenstByPublicationId(int publicationId)
        {
            using (var _connection = new SqlConnection(_connectionString))
            {
                var stProc = "GetCountCommentsByPublicationId";

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
    }
}
