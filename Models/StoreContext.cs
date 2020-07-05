using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace GoBear.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }
        public StoreContext( string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public StoreContext() { }
        //dsach bảo hiểm
        public List<insurrance> GetAllInsu()
        {
            List<insurrance> list = new List<insurrance>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "select * from insurrance";
                SqlCommand cmd = new SqlCommand(sql,conn);
                try
                {
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new insurrance()
                            {
                                MaBH = reader["MaBH"].ToString(),
                                TenBH = reader["TenBH"].ToString(),
                                Price = float.Parse(reader["Price"].ToString()),
                                rate = float.Parse(reader["rate"].ToString()),
                                buyonline = reader["buyonline"].ToString(),
                                regula_age = reader["regula_age"].ToString(),
                                define_family = reader["define_family"].ToString(),
                                hightlight = reader["hightlight"].ToString(),
                                repatriation = float.Parse(reader["repatriation"].ToString()),
                                accident_myself = float.Parse(reader["accident_myself"].ToString()),
                                foreign_medical = float.Parse(reader["foreign_medical"].ToString()),
                                patients_relative = float.Parse(reader["patients_relative"].ToString()),
                                subsidize = reader["subsidize"].ToString()

                            });
                        }
                        reader.Close();
                    }
                    conn.Close();
                } catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return list;
        }
    }
}
