using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using WpfUrbexApp.Models;
using System.Data;

namespace WpfUrbexApp.Repositories
{
    public class PostRepository
    {
        private static string _dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "urbex.db");
        private static string _connectionString = $"Data Source={_dbFilePath};Version=3;";


        public PostRepository()
        {
            if (!File.Exists(_dbFilePath))
            {
                SQLiteConnection.CreateFile(_dbFilePath);
                InitializeDatabase();
            }
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"CREATE TABLE IF NOT EXISTS Posts (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Title TEXT NOT NULL,
                                    Description TEXT,
                                    Date TEXT,
                                    Location TEXT,
                                    Image BLOB)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool CreatePost(Post post)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Posts (Title, Description, Date, Location, Image) VALUES (@Title, @Description, @Date, @Location, @Image)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", post.Title);
                    command.Parameters.AddWithValue("@Description", post.Description);
                    command.Parameters.AddWithValue("@Date", post.Date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Location", post.Location);
                    command.Parameters.Add("@Image", DbType.Binary).Value = post.Image;
                    return command.ExecuteNonQuery() == 1;
                }
            }
        }

        public List<Post> GetAllPosts()
        {
            List<Post> posts = new List<Post>();
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Posts";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        posts.Add(new Post(
                            Convert.ToInt32(reader["Id"]),
                            reader["Title"].ToString(),
                            reader["Description"].ToString(),
                            DateTime.Parse(reader["Date"].ToString()),
                            reader["Location"].ToString(),
                            reader["Image"] != DBNull.Value ? (byte[])reader["Image"] : new byte[0]
                        ));
                    }
                }
            }
            return posts;
        }

        public bool UpdatePost(Post post)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Posts SET Title=@Title, Description=@Description, Date=@Date, Location=@Location, Image=@Image WHERE Id=@Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", post.Title);
                    command.Parameters.AddWithValue("@Description", post.Description);
                    command.Parameters.AddWithValue("@Date", post.Date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Location", post.Location);
                    command.Parameters.AddWithValue("@Image", post.Image);
                    command.Parameters.AddWithValue("@Id", post.Id);
                    return command.ExecuteNonQuery() == 1;
                }
            }
        }

        public bool DeletePost(int postId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                // WYKONUJEMY USUNIĘCIE
                string deleteQuery = "DELETE FROM Posts WHERE Id=@Id";
                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", postId);
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Usunięto {rowsAffected} rekord(-y) o ID: {postId}");
                    return rowsAffected > 0;
                }
            }
        }
    }
}
