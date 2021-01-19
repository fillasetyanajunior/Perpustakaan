using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP.Model.Entity;
using FP.Controller;


namespace FP.View
{
    public partial class FrmInputPinjaman : Form
    {
        public delegate void CreateEventHandler(Peminjaman peminjaman);
        public event CreateEventHandler OnCreate;
        private Peminjaman peminjaman;
        private DateTime tempo;

        private BukuController bukuController;
        private MemberController memberController;
        private StaffController staffController;
        public FrmInputPinjaman()
        {
            InitializeComponent();
            bukuController = new BukuController();
            memberController = new MemberController();
            staffController = new StaffController();
            TampilData();
        }
        public FrmInputPinjaman(string title)
            : this()
        {
            lblTitle.Text = title.ToString();
            tempo = DateTime.Now.AddDays(7);
        }
        public void TampilData()
        {
            //Pilihan Maskapai
            var Bukus = new List<Buku>();
            Bukus = bukuController.ReadBuku();
            cmbIDBuku.Items.Add("ID Buku");
            foreach (var buku in Bukus)
            {
                if (buku.actives == 1)
                {
                    cmbIDBuku.Items.Add(buku.id);

                }
                else
                {
                }
            }
            cmbIDBuku.SelectedIndex = 0;

            //Pilihan Kelas Penerbangan
            var members = new List<Member>();
            members = memberController.ReadMember();
            cmbIDMember.Items.Add("ID Member");
            foreach (var member in members)
            {
                if (member.actives == 1)
                {
                    cmbIDMember.Items.Add(member.id);

                }
                else
                {
                }
            }
            cmbIDMember.SelectedIndex = 0;

            //Pilihan Kota Asal
            var Staffs = new List<Staff>();
            Staffs = staffController.ReadAllStaff();
            cmbIDStaff.Items.Add("ID Staff");
            foreach (var staff in Staffs)
            {
                cmbIDStaff.Items.Add(staff.id);
            }
            cmbIDStaff.SelectedIndex = 0;

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            peminjaman = new Peminjaman();

            peminjaman.id_member = cmbIDMember.SelectedItem.ToString();
            peminjaman.id_buku = cmbIDBuku.SelectedItem.ToString();
            peminjaman.id_staff = cmbIDStaff.SelectedItem.ToString();
            peminjaman.tgl_peminjaman = dtpPeminjaman.Value;
            peminjaman.tgl_tempo = tempo;

            OnCreate(peminjaman);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
