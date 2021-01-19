using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Model.Entity
{
    public class Buku
    {
        public int id { get; set; }
        public string id_staff { get; set; }
        public string judul_buku { get; set; }
        public string pengarang { get; set; }
        public string penerbit { get; set; }
        public int actives { get; set; }
    }
}
