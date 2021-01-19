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
    public class StaffRepository
    {
        private MySqlConnection conn;
        public StaffRepository(DbContext dbContext)
        {
            conn = dbContext.Conn;
        }

        public int Create(Staff staff)
        {
            var result = 0;
            var sql = @"INSERT INTO staff values (NULL, @status_akun, @nama, @username, @password, @jenis_kelamin, @umur, @terdaftar_sejak)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@status_akun", staff.status_akun);
                cmd.Parameters.AddWithValue("@nama", staff.nama);
                cmd.Parameters.AddWithValue("@username", staff.username);
                cmd.Parameters.AddWithValue("@password", staff.password);
                cmd.Parameters.AddWithValue("@jenis_kelamin", staff.jenis_kelamin);
                cmd.Parameters.AddWithValue("@umur", staff.umur);
                cmd.Parameters.AddWithValue("@terdaftar_sejak", staff.terdaftar_sejak);

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

        public int Update(Staff staff)
        {
            var result = 0;
            var sql = @"UPDATE staff SET status_akun = @status_akun, nama = @nama, username = @username, password = @password, jenis_kelamin = @jenis_kelamin, umur = @umur, terdaftar_sejak = @terdaftar_sejak WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@status_akun", staff.status_akun);
                cmd.Parameters.AddWithValue("@nama", staff.nama);
                cmd.Parameters.AddWithValue("@username", staff.username);
                cmd.Parameters.AddWithValue("@password", staff.password);
                cmd.Parameters.AddWithValue("@jenis_kelamin", staff.jenis_kelamin);
                cmd.Parameters.AddWithValue("@umur", staff.umur);
                cmd.Parameters.AddWithValue("@terdaftar_sejak", staff.terdaftar_sejak);
                cmd.Parameters.AddWithValue("@id", staff.id);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public Staff Login(Staff staff)
        {
            var staffs = new Staff();
            try
            {
                string sql = @"SELECT * FROM staff WHERE username = @username AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", staff.username);
                    cmd.Parameters.AddWithValue("@password", staff.password);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            staff.id = int.Parse(dtr["id"].ToString());
                            staff.status_akun = dtr["status_akun"].ToString();
                            staff.nama = dtr["nama"].ToString();
                            staff.username = dtr["username"].ToString();
                            staff.password = dtr["password"].ToString();
                            staff.jenis_kelamin = char.Parse(dtr["jenis_kelamin"].ToString());
                            staff.umur = int.Parse(dtr["umur"].ToString());
                            staff.terdaftar_sejak = DateTime.Parse(dtr["terdaftar_sejak"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("IsValidAccess error: {0}", ex.Message);
            }
            return staff;
        }

        public List<Staff> ValidasiRegister(string username)
        {
            var listUser = new List<Staff>();
            try
            {
                string sql = @"SELECT * FROM staff WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var staff = new Staff();
                            staff.username = dtr["username"].ToString();
                            listUser.Add(staff);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("IsValidAccess error: {0}", ex.Message);
            }
            return listUser;
        }
        public List<Staff> ReadAllStaff()
        {
            var listofstaff = new List<Staff>();
            try
            {
                string sql = @"SELECT * FROM staff";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var staff = new Staff();

                            staff.id = int.Parse(dtr["id"].ToString());
                            staff.status_akun = dtr["status_akun"].ToString();
                            staff.nama = dtr["nama"].ToString();
                            staff.username = dtr["username"].ToString();
                            staff.password = dtr["password"].ToString();
                            staff.jenis_kelamin = char.Parse(dtr["jenis_kelamin"].ToString());
                            staff.umur = int.Parse(dtr["umur"].ToString());
                            staff.terdaftar_sejak = DateTime.Parse(dtr["terdaftar_sejak"].ToString());

                            listofstaff.Add(staff);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("IsValidAccess error: {0}", ex.Message);
            }
            return listofstaff;
        }
        public int Delete(Staff staff)
        {
            var result = 0;
            var sql = @"DELETE FROM staff WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", staff.id);

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
