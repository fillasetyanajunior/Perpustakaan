using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Model.Entity
{
    public class Peminjaman
    {
        public int id { get; set; }
        public string id_buku { get; set; }
        public string id_member { get; set; }
        public string id_staff { get; set; }
        public DateTime tgl_peminjaman { get; set; }
        public DateTime tgl_tempo { get; set; }
    }
}
