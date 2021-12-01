using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models;

namespace PaymentAPI.Models
{
    public class PaymentContext
    {
        public string ConnectionStrings { get; set; }

        public PaymentContext(string connectionString)
        {
            this.ConnectionStrings = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionStrings);
        }

        public List<PaymentItem> GetAllPayment()
        {
            List<PaymentItem> list = new List<PaymentItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paymentdetail", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PaymentItem()
                        {
                            id = reader.GetInt32("id"),
                            cardName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetString("expirationDate"),
                            securityCode = reader.GetString("securityCode")
                        });
                    }
                }
            }
            return list;
        }

        public List<PaymentItem> GetPayment(string id)
        {
            List<PaymentItem> list = new List<PaymentItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paymentdetail WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PaymentItem()
                        {
                            id = reader.GetInt32("id"),
                            cardName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetString("expirationDate"),
                            securityCode = reader.GetString("securityCode")

                        });
                    }
                }
            }
            return list;
        }

        public string CreatePayment(PaymentItem item)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO paymentdetail(cardOwnerName, cardNumber, expirationDate, securityCode) VALUES(@cardName,@cardNumber, @expirationDate, @securityCode)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@cardName", item.cardName);
                        cmd.Parameters.AddWithValue("@cardNumber", item.cardNumber);
                        cmd.Parameters.AddWithValue("@expirationDate", item.expirationDate);
                        cmd.Parameters.AddWithValue("@securityCode", item.securityCode);

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

        public string UpdatePayment(PaymentItem item)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "UPDATE paymentdetail SET cardOwnerName = @cardName, cardNumber = @cardNumber, expirationDate = @expirationDate, securityCode = @securityCode WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", item.id);
                        cmd.Parameters.AddWithValue("@cardName", item.cardName);
                        cmd.Parameters.AddWithValue("@cardNumber", item.cardNumber);
                        cmd.Parameters.AddWithValue("@expirationDate", item.expirationDate);
                        cmd.Parameters.AddWithValue("@securityCode", item.securityCode);
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

        public string DeletePayment(string id)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM paymentdetail WHERE id = @id";
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


