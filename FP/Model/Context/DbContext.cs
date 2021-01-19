using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FP.Model.Context
{
    public class DbContext : IDisposable
    {
        private MySqlConnection _conn;

        public MySqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private MySqlConnection GetOpenConnection()
        {
            MySqlConnection conn = null;

            try
            {
                var Server = "127.0.0.1";
                var Database = "db_perpus";
                var Username = "root";
                var Password = "";
                var connectionString = string.Format("Server=" + Server + ";Database=" + Database + ";Uid=" + Username + ";Pwd=" + Password + ";");
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
