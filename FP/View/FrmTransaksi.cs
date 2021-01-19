using FP.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP.View
{
    public partial class FrmTransaksi : Form
    {
        public FrmTransaksi()
        {
            InitializeComponent();
            peminjamans.Show();
            pengembalians.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPinjaman_Click(object sender, EventArgs e)
        {
            peminjamans.Show();
            pengembalians.Hide();
        }

        private void btnPengambalian_Click(object sender, EventArgs e)
        {
            if (peminjamans.lvwPinjaman.SelectedItems.Count > 0)
            {
                Peminjaman tks = peminjamans.dftpeminjamans[peminjamans.lvwPinjaman.SelectedIndices[0]];
                pengembalians.id_buku = tks.id_buku;
                pengembalians.id_member = tks.id_member;
                pengembalians.id_staff = tks.id_staff;
                pengembalians.tgl_peminjaman = tks.tgl_peminjaman;
                pengembalians.bener = true;

                peminjamans.Hide();
                pengembalians.Show();
            }
            else
            {
                pengembalians.bener = false;
                peminjamans.Hide();
                pengembalians.Show();
            }

            
        }
    }
}
