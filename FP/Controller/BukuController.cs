using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP.Model.Context;
using FP.Model.Entity;
using FP.Model.Repository;
using System.Windows.Forms;

namespace FP.Controller
{
    public  class BukuController
    {
        private BukuRepository _repository;
        public List<Buku> ReadBuku()
        {
            List<Buku> buku = new List<Buku>();

            using (DbContext context = new DbContext())
            {
                _repository = new BukuRepository(context);
                buku = _repository.ReadAll();
            }

            return buku;
        }
        public Buku ReadCount()
        {
            Buku buku = new Buku();

            using (DbContext context = new DbContext())
            {
                _repository = new BukuRepository(context);
                buku = _repository.ReadCount();
            }

            return buku;
        }

        public int Create(Buku buku)
        {
            var result = 0;
            if (string.IsNullOrEmpty(buku.id_staff.ToString()))
            {
                MessageBox.Show("ID Staff harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(buku.judul_buku))
            {
                MessageBox.Show("Judul Buku harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(buku.pengarang))
            {
                MessageBox.Show("Pengarang harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(buku.penerbit))
            {
                MessageBox.Show("Penerbit harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new BukuRepository(context);
                result = _repository.Create(buku);
            }

            if (result == 0)
                MessageBox.Show("Input Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Update(Buku buku)
        {
            var result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new BukuRepository(context);
                result = _repository.Update(buku);
            }

            if (result == 0)
                MessageBox.Show("Update Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Delete(Buku buku)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new BukuRepository(context);
                result = _repository.Delete(buku);
            }

            if (result == 0)
                MessageBox.Show("Delete Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int UpdateActive(string id_buku, int active)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new BukuRepository(context);
                result = _repository.UpdateActive(id_buku, active);
            }

            if (result == 0)
                MessageBox.Show("Update Buku Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}
