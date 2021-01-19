using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Model.Entity
{
    public class Staff
    {
        public int id { get; set; }
        public string status_akun { get; set; }
        public string nama { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public char jenis_kelamin { get; set; }
        public int umur { get; set; }
        public DateTime terdaftar_sejak { get; set; }
    }
}
