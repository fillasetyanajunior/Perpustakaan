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
    public class MemberRepository
    {
        private MySqlConnection conn;
        public MemberRepository(DbContext context)
        {
            conn = context.Conn;
        }
        public List<Member> ReadAll()
        {
            var list = new List<Member>();
            try
            {
                string sql = @"SELECT * FROM  member";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var member = new Member();

                            member.id = int.Parse(dtr["id"].ToString());
                            member.nama = dtr["nama"].ToString();
                            member.alamat = dtr["alamat"].ToString();
                            member.terdaftar_sejak = DateTime.Parse(dtr["terdaftar_sejak"].ToString());
                            member.umur = int.Parse(dtr["umur"].ToString());
                            member.jenis_kelamin = char.Parse(dtr["jenis_kelamin"].ToString());
                            member.telpon = dtr["telpon"].ToString();
                            member.actives = int.Parse(dtr["is_active"].ToString());

                            list.Add(member);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByDate error: {0}", ex.Message);
            }
            return list;
        }
        public Member ReadCount(string tahunan)
        {
            var member = new Member();
            try
            {
                string sql = @"SELECT COUNT(id) FROM  member WHERE terdaftar_sejak LIKE @terdaftar_sejak";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@terdaftar_sejak", "%" + tahunan + "%");
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {

                            member.id = int.Parse(dtr["COUNT(id)"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByDate error: {0}", ex.Message);
            }
            return member;
        }
        public int Create(Member member)
        {
            var result = 0;
            var sql = @"INSERT INTO member values (NULL,@nama, @alamat, @terdaftar_sejak, @umur, @jenis_kelamin, @telpon,@is_active)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nama", member.nama);
                cmd.Parameters.AddWithValue("@alamat", member.alamat);
                cmd.Parameters.AddWithValue("@terdaftar_sejak", member.terdaftar_sejak);
                cmd.Parameters.AddWithValue("@umur", member.umur);
                cmd.Parameters.AddWithValue("@jenis_kelamin", member.jenis_kelamin);
                cmd.Parameters.AddWithValue("@telpon", member.telpon);
                cmd.Parameters.AddWithValue("@is_active", member.actives);

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
        public int Update(Member member)
        {
            var result = 0;
            var sql = @"UPDATE member SET nama = @nama, alamat = @alamat, terdaftar_sejak = @terdaftar_sejak, umur = @umur, jenis_kelamin = @jenis_kelamin ,telpon = @telpon WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nama", member.nama);
                cmd.Parameters.AddWithValue("@alamat", member.alamat);
                cmd.Parameters.AddWithValue("@terdaftar_sejak", member.terdaftar_sejak);
                cmd.Parameters.AddWithValue("@umur", member.umur);
                cmd.Parameters.AddWithValue("@jenis_kelamin", member.jenis_kelamin);
                cmd.Parameters.AddWithValue("@telpon", member.telpon);
                cmd.Parameters.AddWithValue("@id", member.id);

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
        public int UpdateActive(string id_member,int active)
        {
            var result = 0;
            var sql = @"UPDATE member SET is_active = @active WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@active", active);
                cmd.Parameters.AddWithValue("@id", id_member);

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
        public int Delete(Member member)
        {
            var result = 0;
            var sql = @"DELETE FROM member WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", member.id);

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
