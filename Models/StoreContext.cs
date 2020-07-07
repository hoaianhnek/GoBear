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
                                repatriation = reader["repatriation"].ToString(),
                                accident_myself = reader["accident_myself"].ToString(),
                                foreign_medical = reader["foreign_medical"].ToString(),
                                patients_relative = reader["patients_relative"].ToString(),
                                subsidize = reader["subsidize"].ToString(),
                                id_Bank = reader["id_Bank"].ToString(),
                                medical_transport = reader["medical_transport"].ToString(),
                                support_service = reader["support_service"].ToString(),
                                repatriated_corpse = reader["repatriated_corpse"].ToString(),
                                responsibility_third = reader["responsibility_third"].ToString(),
                                lost_travel =reader["lost_travel"].ToString(),
                                receiving_slowly = reader["receiving_slowly"].ToString(),
                                damages = reader["damages"].ToString(),
                                trip_delay = reader["trip_delay"].ToString(),
                                cancel_trip = reader["cancel_trip"].ToString(),
                                giveup_trip = reader["giveup_trip"].ToString()
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
        // danh sách ngân hàng
        public List<Bank> GetAllBank()
        {
            List<Bank> list = new List<Bank>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "select * from Bank";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Bank()
                            {
                                id_Bank = reader["id_Bank"].ToString(),
                                name_Bank = reader["name_Bank"].ToString(),
                                image_Bank = reader["image_Bank"].ToString()
                            });
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return list;
        }
    
    }
}
