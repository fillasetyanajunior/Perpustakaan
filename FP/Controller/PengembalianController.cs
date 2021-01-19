using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP.Model.Entity;
using FP.Model.Repository;
using FP.Model.Context;
using System.Windows.Forms;

namespace FP.Controller
{
    public class PengembalianController
    {
        private PengembalianRepository _repository;
        public int Create(Pengembalian Pengembalian)
        {
            var result = 0;
            if (string.IsNullOrEmpty(Pengembalian.id_member))
            {
                MessageBox.Show("ID Member harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Pengembalian.id_staff))
            {
                MessageBox.Show("ID Staff harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Pengembalian.id_buku))
            {
                MessageBox.Show("ID Buku harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PengembalianRepository(context);
                result = _repository.Create(Pengembalian);
            }

            if (result == 0)
                MessageBox.Show("Input Pengembalian Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public List<Pengembalian> ReadAll()
        {
            var listpengembalian = new List<Pengembalian>();

            using (DbContext context = new DbContext())
            {
                _repository = new PengembalianRepository(context);
                listpengembalian = _repository.ReadAll();
            }

            return listpengembalian;
        }
        public List<Pengembalian> ReadSearch(string search)
        {
            var listpengembalian = new List<Pengembalian>();

            using (DbContext context = new DbContext())
            {
                _repository = new PengembalianRepository(context);
                listpengembalian = _repository.Search(search);


                return listpengembalian;
            }
        }
        public Pengembalian ReadCount(string tahunan)
        {
            Pengembalian listpengembalian = new Pengembalian();

            using (DbContext context = new DbContext())
            {
                _repository = new PengembalianRepository(context);
                listpengembalian = _repository.ReadCount(tahunan);
            }

            return listpengembalian;
        }
    }
}
