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

namespace FP.View
{
    public partial class FrmInputPengembalian : Form
    {
        public delegate void CreateEventHandler(Pengembalian pengembalian);
        public event CreateEventHandler OnCreate;
        private Pengembalian pengembalians;
        private int hasil;
        private DateTime pengembalian;

        public FrmInputPengembalian()
        {
            InitializeComponent();
        }
        public FrmInputPengembalian(string title,string idbuku, string idstaff, string idmember,bool benar,DateTime tgl_pinjaman)
            : this()
        {
            lblTitle.Text = title.ToString();
            if (benar == true)
            {
                txtIDMember.Text = idmember;
                txtIDBuku.Text = idbuku;
                txtIDStaff.Text = idstaff;

                txtIDMember.Enabled = false;
                txtIDBuku.Enabled = false;
                txtIDStaff.Enabled = false;

            }
            else
            {
                txtIDMember.Enabled = true;
                txtIDBuku.Enabled = true;
                txtIDStaff.Enabled = true;
            }

            pengembalian = tgl_pinjaman;

            var start = tgl_pinjaman;
            var end = DateTime.Now;
            if (end > start)
            {
                var denda = end.Subtract(start).TotalDays;
                for (var i = 1; i <= denda; i++)
                {
                    hasil = hasil + 10000;
                }
            }
            else
            {
                hasil = 0;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            pengembalians = new Pengembalian();

            pengembalians.id_member = txtIDMember.Text;
            pengembalians.id_buku = txtIDBuku.Text;
            pengembalians.id_staff = txtIDStaff.Text;
            pengembalians.tgl_pengembalian = dtpPengambalian.Value;
            pengembalians.tgl_peminjaman = pengembalian;
            pengembalians.denda = hasil.ToString();

            OnCreate(pengembalians);
            txtIDMember.Clear();
            txtIDBuku.Clear();
            txtIDStaff.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpPengambalian_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
