using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Model.Entity
{
    public class Member
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public DateTime terdaftar_sejak { get; set; }
        public int umur { get; set; }
        public char jenis_kelamin { get; set; }
        public string telpon { get; set; }
        public int actives { get; set; }
    }
}
