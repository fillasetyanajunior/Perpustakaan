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
    public class StaffController
    {
        private List<Staff> Staffs = new List<Staff>();
        private StaffRepository _repository;
        public int Create(Staff staff)
        {
            var result = 0;
            if (string.IsNullOrEmpty(staff.status_akun.ToString()))
            {
                MessageBox.Show("ID Member harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(staff.nama))
            {
                MessageBox.Show("Jaminan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(staff.username))
            {
                MessageBox.Show("Status harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            } 
            if (string.IsNullOrEmpty(staff.password))
            {
                MessageBox.Show("Status harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(staff.jenis_kelamin.ToString()))
            {
                MessageBox.Show("Tanggal Peminjaman harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(staff.terdaftar_sejak.ToString()))
            {
                MessageBox.Show("Tanggal Pengembalian harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            Staffs = ReadStaff(staff.username);

            foreach (var valid in Staffs)
            {
                if (!string.IsNullOrEmpty(valid.username))
                {
                    MessageBox.Show("Username Sudah Ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
            }

            using (DbContext context = new DbContext())
            {
                _repository = new StaffRepository(context);
                result = _repository.Create(staff);
            }

            if (result == 0)
                MessageBox.Show("Pendaftaran Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public List<Staff> ReadStaff(string cari)
        {
            List<Staff> listStaff = new List<Staff>();

            using (DbContext context = new DbContext())
            {
                _repository = new StaffRepository(context);
                listStaff = _repository.ValidasiRegister(cari);
            }

            return listStaff;
        }

        public int ValidasiLogin(Staff staff)
        {
            int result = 0;

            if (string.IsNullOrEmpty(staff.username))
            {
                MessageBox.Show("Status harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(staff.password))
            {
                MessageBox.Show("Status harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            result = 1;

            return result;
        }

        public Staff Auth(Staff staffs)
        {
            var staff = new Staff();

            using (DbContext context = new DbContext())
            {
                _repository = new StaffRepository(context);
                staff = _repository.Login(staffs);
            }
            return staff;
        }
        public List<Staff> ReadAllStaff()
        {
            List<Staff> listUser = new List<Staff>();

            using (DbContext context = new DbContext())
            {
                _repository = new StaffRepository(context);
                listUser = _repository.ReadAllStaff();
            }

            return listUser;
        }
        public int Update(Staff staff)
        {
            var result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new StaffRepository(context);
                result = _repository.Update(staff);
            }

            if (result == 0)
                MessageBox.Show("Update Role Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Delete(Staff staff)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new StaffRepository(context);
                result = _repository.Delete(staff);
            }

            if (result == 0)
                MessageBox.Show("Delete Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}
