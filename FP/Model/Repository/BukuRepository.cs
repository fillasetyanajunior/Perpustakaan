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
    public class BukuRepository
    {
        private MySqlConnection conn;
        public BukuRepository(DbContext context)
        {
            conn = context.Conn;
        }
        public int Create(Buku buku)
        {
            var result = 0;
            var sql = @"INSERT INTO buku values (NULL, @id_staff ,@judul_buku, @pengarang, @penerbit,@is_active)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_staff", buku.id_staff);
                cmd.Parameters.AddWithValue("@judul_buku", buku.judul_buku);
                cmd.Parameters.AddWithValue("@pengarang", buku.pengarang);
                cmd.Parameters.AddWithValue("@penerbit", buku.penerbit);
                cmd.Parameters.AddWithValue("@is_active", buku.actives);

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
        public int Update(Buku buku)
        {
            var result = 0;
            var sql = @"UPDATE buku SET id_staff = @id_staff, judul_buku = @judul_buku , pengarang = @pengarang, penerbit = @penerbit WHERE id = @id" ;
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_staff", buku.id_staff);
                cmd.Parameters.AddWithValue("@judul_buku", buku.judul_buku);
                cmd.Parameters.AddWithValue("@pengarang", buku.pengarang);
                cmd.Parameters.AddWithValue("@penerbit", buku.penerbit);
                cmd.Parameters.AddWithValue("@id", buku.id);

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
        public int UpdateActive(string id_buku, int active)
        {
            var result = 0;
    
            var sql = @"UPDATE buku SET is_active = @active WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@active", active);
                cmd.Parameters.AddWithValue("@id", id_buku);

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
        public int Delete(Buku buku)
        {
            var result = 0;
            var sql = @"DELETE FROM buku WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", buku.id);

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

        public List<Buku> ReadAll()
        {
            var list = new List<Buku>();
            try
            {
                string sql = @"SELECT * FROM buku";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var buku = new Buku();

                            buku.id = int.Parse(dtr["id"].ToString());
                            buku.id_staff = dtr["id_staff"].ToString();
                            buku.judul_buku = dtr["judul_buku"].ToString();
                            buku.pengarang = dtr["pengarang"].ToString();
                            buku.penerbit = dtr["penerbit"].ToString();
                            buku.actives = int.Parse(dtr["is_active"].ToString());

                            list.Add(buku);
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
        public Buku ReadCount()
        {
            var Buku = new Buku();
            try
            {
                string sql = @"SELECT COUNT(id) FROM  buku";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {

                            Buku.id = int.Parse(dtr["COUNT(id)"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByDate error: {0}", ex.Message);
            }
            return Buku;
        }
    }
}
