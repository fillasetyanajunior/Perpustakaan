using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Model.Entity
{
    public class Pengembalian
    {
        public int id { get; set; }
        public string id_buku { get; set; }
        public string id_member { get; set; }
        public string id_staff { get; set; }
        public DateTime tgl_pengembalian { get; set; }
        public DateTime tgl_peminjaman { get; set; }
        public string denda { get; set; }
    }
}
