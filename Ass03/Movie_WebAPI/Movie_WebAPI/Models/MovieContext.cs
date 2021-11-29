using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_WebAPI.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }
        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> GetAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM moviedb", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("Name"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString ("Duration"),
                            date = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM moviedb WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("Name"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            date = reader.GetString("ReleaseDate")
                        });
                    }

                }
            }

            return list;
        }

        public string CreateMovie(MovieItem item)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO moviedb(Name, Genre, Duration, ReleaseDate) VALUES (@name,@genre,@duration,@date)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@name", item.name);
                        cmd.Parameters.AddWithValue("@genre", item.genre);
                        cmd.Parameters.AddWithValue("@duration", item.duration);
                        cmd.Parameters.AddWithValue("@date", item.date);
                        Console.WriteLine(item);
                        Console.WriteLine(sql);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return "Input Data Berhasil";

                    }
                    catch (Exception e)
                    {
                        Console.Write(e.ToString());
                        return "Input Data Gagal";
                    }

                }
            }
        }

        public string UpdateMovie(MovieItem item)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "UPDATE moviedb SET Name = @name, Genre = @Genre, Duration = @duration, ReleaseDate = @date WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", item.id);
                        cmd.Parameters.AddWithValue("@name", item.name);
                        cmd.Parameters.AddWithValue("@genre", item.genre);
                        cmd.Parameters.AddWithValue("@duration", item.duration);
                        cmd.Parameters.AddWithValue("@date", item.date);
                        Console.WriteLine(item);
                        Console.WriteLine(sql);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return "Update Data Berhasil";
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.ToString());
                        return "Update Data Gagal";
                    }
                }
            }
        }

        public string DeleteMovie(string id)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM moviedb WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        Console.WriteLine(id);
                        Console.WriteLine(sql);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return "Delete Data Berhasil";
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.ToString());
                        return "Delete Data Gagal";
                    }
                }
            }
        }
    }
}
