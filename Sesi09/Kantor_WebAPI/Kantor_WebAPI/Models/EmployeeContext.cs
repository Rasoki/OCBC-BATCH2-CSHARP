using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")

                        });
                    }
                }
            }
            return list;
        }

        public string CreateEmployee(EmployeeItem item)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO employee(nama, jenis_kelamin, alamat) VALUES(@nama,@jenis_kelamin,@alamat)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@nama", item.nama);
                        cmd.Parameters.AddWithValue("@jenisKelamin", item.jenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", item.alamat);
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

        public string UpdateEmployee(EmployeeItem item)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "UPDATE EMPLOYEE SET nama = @nama, jenis_kelamin = @jenisKelamin,alamat = @alamat WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", item.id);
                        cmd.Parameters.AddWithValue("@nama", item.nama);
                        cmd.Parameters.AddWithValue("@jenisKelamin", item.jenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", item.alamat);
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

        public string DeleteEmployee(string id)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM EMPLOYEE WHERE id = @id";
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
    

