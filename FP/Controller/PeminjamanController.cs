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
    public class PeminjamanController
    {
        private PeminjamanRepository _repository;
        public int Create(Peminjaman pinjaman)
        {
            var result = 0;
            if (string.IsNullOrEmpty(pinjaman.id_member))
            {
                MessageBox.Show("ID Member harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pinjaman.id_staff))
            {
                MessageBox.Show("ID Staff harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pinjaman.id_buku))
            {
                MessageBox.Show("ID Buku  harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PeminjamanRepository(context);
                result = _repository.Create(pinjaman);
            }

            if (result == 0)
                MessageBox.Show("Input pinjaman Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public List<Peminjaman> ReadAll()
        {
            var listPeminjaman = new List<Peminjaman>();

            using (DbContext context = new DbContext())
            {
                _repository = new PeminjamanRepository(context);
                listPeminjaman = _repository.ReadAll();
            }

            return listPeminjaman;
        }
        public List<Peminjaman> ReadSearch(string search)
        {
            var listPeminjaman = new List<Peminjaman>();

            using (DbContext context = new DbContext())
            {
                _repository = new PeminjamanRepository(context);
                listPeminjaman = _repository.Search(search);


                return listPeminjaman;
            }
        }
        public int Delete(string id_member)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new PeminjamanRepository(context);
                result = _repository.Delete(id_member);
            }

            if (result == 0)
                MessageBox.Show("Delete Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}
