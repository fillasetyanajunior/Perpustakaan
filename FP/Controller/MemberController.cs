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
    public class MemberController
    {
        private MemberRepository _repository;
        public List<Member> ReadMember()
        {
            List<Member> member = new List<Member>();

            using (DbContext context = new DbContext())
            {
                _repository = new MemberRepository(context);
                member = _repository.ReadAll();
            }

            return member;
        }
        public Member ReadCount(string tahunan)
        {
            Member member = new Member();

            using (DbContext context = new DbContext())
            {
                _repository = new MemberRepository(context);
                member = _repository.ReadCount(tahunan);
            }

            return member;
        }
        public int Create(Member member)
        {
            var result = 0;
            if (string.IsNullOrEmpty(member.nama))
            {
                MessageBox.Show("Nama harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(member.alamat))
            {
                MessageBox.Show("Alamat diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(member.terdaftar_sejak.ToString()))
            {
                MessageBox.Show("Terdaftar Sejak harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(member.umur.ToString()))
            {
                MessageBox.Show("Umur harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(member.jenis_kelamin.ToString()))
            {
                MessageBox.Show("Jenis Kelamin harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(member.telpon.ToString()))
            {
                MessageBox.Show("Telpon harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new MemberRepository(context);
                result = _repository.Create(member);
            }

            if (result == 0)
                MessageBox.Show("Input Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Update(Member member)
        {
            var result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new MemberRepository(context);
                result = _repository.Update(member);
            }

            if (result == 0)
                MessageBox.Show("Update Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
        public int Delete(Member member)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new MemberRepository(context);
                result = _repository.Delete(member);
            }

            if (result == 0)
                MessageBox.Show("Delete Data Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int UpdateActiveUser(string id_member, int active)
        {
            var result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new MemberRepository(context);
                result = _repository.UpdateActive(id_member, active);
            }

            if (result == 0)
                MessageBox.Show("Update Member Gagal!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}
