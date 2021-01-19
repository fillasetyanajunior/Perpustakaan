using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP.Model.Context;
using FP.Model.Entity;
using MySql.Data.MySqlClient;

namespace FP.Model.Repository
{
    public class PeminjamanRepository
    {
        private MySqlConnection conn;
        public PeminjamanRepository(DbContext context)
        {
            conn = context.Conn;
        }
        public int Create(Peminjaman peminjaman)
        {
            var result = 0;
            var sql = @"INSERT INTO peminjaman values (NULL, @id_buku, @id_member, @id_staff, @tgl_peminjaman, @tgl_tempo)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_buku", peminjaman.id_buku);
                cmd.Parameters.AddWithValue("@id_member", peminjaman.id_member);
                cmd.Parameters.AddWithValue("@id_staff", peminjaman.id_staff);
                cmd.Parameters.AddWithValue("@tgl_peminjaman", peminjaman.tgl_peminjaman);
                cmd.Parameters.AddWithValue("@tgl_tempo", peminjaman.tgl_tempo);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)        
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Peminjaman> ReadAll()
        {
            var list = new List<Peminjaman>();
            try
            {
                string sql = @"SELECT * FROM peminjaman";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var peminjaman = new Peminjaman();

                            peminjaman.id = int.Parse(dtr["id"].ToString());
                            peminjaman.id_buku = dtr["id_buku"].ToString();
                            peminjaman.id_member = dtr["id_member"].ToString();
                            peminjaman.id_staff = dtr["id_staff"].ToString();
                            peminjaman.tgl_peminjaman = DateTime.Parse(dtr["tgl_peminjaman"].ToString());
                            peminjaman.tgl_tempo = DateTime.Parse(dtr["tgl_tempo"].ToString());

                            list.Add(peminjaman);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByID error: {0}", ex.Message);
            }
            return list;
        }
        public List<Peminjaman> Search(string search)
        {
            var list = new List<Peminjaman>();
            try
            {
                string sql = @"SELECT * FROM peminjaman WHERE id_buku LIKE @search OR id_member LIKE @search ";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var peminjaman = new Peminjaman();

                            peminjaman.id = int.Parse(dtr["id"].ToString());
                            peminjaman.id_buku = dtr["id_buku"].ToString();
                            peminjaman.id_member = dtr["id_member"].ToString();
                            peminjaman.id_staff = dtr["id_staff"].ToString();
                            peminjaman.tgl_peminjaman = DateTime.Parse(dtr["tgl_peminjaman"].ToString());
                            peminjaman.tgl_tempo = DateTime.Parse(dtr["tgl_tempo"].ToString());

                            list.Add(peminjaman);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByID error: {0}", ex.Message);
            }
            return list;
        }
        
        public int Delete(string id_member)
        {
            var result = 0;
            var sql = @"DELETE FROM peminjaman WHERE id_member = @id_member";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_member", id_member);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
    }
}
