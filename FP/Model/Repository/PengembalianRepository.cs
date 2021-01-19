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
    public class PengembalianRepository
    {
        private MySqlConnection conn;
        public PengembalianRepository(DbContext context)
        {
            conn = context.Conn;
        }
        public int Create(Pengembalian pengembalian)
        {
            var result = 0;
            var sql = @"INSERT INTO pengembalian values (NULL, @id_buku, @id_member, @id_staff, @tgl_pengembalian, @denda)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_buku", pengembalian.id_buku);
                cmd.Parameters.AddWithValue("@id_member", pengembalian.id_member);
                cmd.Parameters.AddWithValue("@id_staff", pengembalian.id_staff);
                cmd.Parameters.AddWithValue("@tgl_pengembalian", pengembalian.tgl_pengembalian);
                cmd.Parameters.AddWithValue("@denda", pengembalian.denda);

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

        public List<Pengembalian> ReadAll()
        {
            var list = new List<Pengembalian>();
            try
            {
                string sql = @"SELECT * FROM pengembalian";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var pengembalian = new Pengembalian();

                            pengembalian.id = int.Parse(dtr["id"].ToString());
                            pengembalian.id_buku = dtr["id_buku"].ToString();
                            pengembalian.id_member = dtr["id_member"].ToString();
                            pengembalian.id_staff = dtr["id_staff"].ToString();
                            pengembalian.denda = dtr["denda"].ToString();
                            pengembalian.tgl_pengembalian = DateTime.Parse(dtr["tgl_pengembalian"].ToString());
                            pengembalian.tgl_peminjaman = DateTime.Parse(dtr["tglpeminjaman"].ToString());

                            list.Add(pengembalian);
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
        public List<Pengembalian> Search(string search)
        {
            var list = new List<Pengembalian>();
            try
            {
                string sql = @"SELECT * FROM pengembalian WHERE id_buku LIKE @search OR id_member LIKE @search ";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var pengembalian = new Pengembalian();

                            pengembalian.id = int.Parse(dtr["id"].ToString());
                            pengembalian.id_buku = dtr["id_buku"].ToString();
                            pengembalian.id_member = dtr["id_member"].ToString();
                            pengembalian.id_staff = dtr["id_staff"].ToString();
                            pengembalian.denda = dtr["denda"].ToString();
                            pengembalian.tgl_pengembalian = DateTime.Parse(dtr["tgl_pengembalian"].ToString());
                            pengembalian.tgl_peminjaman = DateTime.Parse(dtr["tglpeminjaman"].ToString());

                            list.Add(pengembalian);
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
        public Pengembalian ReadCount(string tahunan)
        {
            var pengembalian = new Pengembalian();
            try
            {
                string sql = @"SELECT COUNT(id) FROM pengembalian WHERE tgl_pengembalian LIKE @tgl_pengembalian";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tgl_pengembalian", "%" + tahunan + "%");
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            pengembalian.id = int.Parse(dtr["COUNT(id)"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByID error: {0}", ex.Message);
            }
            return pengembalian;
        }
    }
}
