using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP.Controller;
using FP.Model.Entity;

namespace FP.View
{
    public partial class Peminjamans : UserControl
    {
        private PeminjamanController peminjamanController;
        private MemberController memberController;
        private BukuController bukuController;
        public List<Peminjaman> dftpeminjamans = new List<Peminjaman>();

        private int active = 0;
        public Peminjamans()
        {
            InitializeComponent();
            peminjamanController = new PeminjamanController();
            memberController = new MemberController();
            bukuController = new BukuController();
            InisialisasiListView();
            Tampildata();
        }
        private void InisialisasiListView()
        {
            lvwPinjaman.View = System.Windows.Forms.View.Details;
            lvwPinjaman.FullRowSelect = true;
            lvwPinjaman.GridLines = true;
            lvwPinjaman.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwPinjaman.Columns.Add("ID Buku", 240, HorizontalAlignment.Center);
            lvwPinjaman.Columns.Add("ID Member", 200, HorizontalAlignment.Center);
            lvwPinjaman.Columns.Add("ID Staff", 150, HorizontalAlignment.Center);
            lvwPinjaman.Columns.Add("Tanggal Peminjaman", 150, HorizontalAlignment.Center);
            lvwPinjaman.Columns.Add("Tanggal Jatuh Tempo", 150, HorizontalAlignment.Center);
        }
        private void Tampildata()
        {
            dftpeminjamans = peminjamanController.ReadAll();
            lvwPinjaman.Items.Clear();
            foreach (var peminjamans in dftpeminjamans)
            {
                var noUrut = lvwPinjaman.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(peminjamans.id_buku);
                item.SubItems.Add(peminjamans.id_member);
                item.SubItems.Add(peminjamans.id_staff);
                item.SubItems.Add(peminjamans.tgl_peminjaman.ToString("yyyy/MM/dd"));
                item.SubItems.Add(peminjamans.tgl_tempo.ToString("yyyy/MM/dd"));
                lvwPinjaman.Items.Add(item);
            }
        }
        private void TampilSearch()
        {
            dftpeminjamans = peminjamanController.ReadSearch(txtSearch.Text);
            lvwPinjaman.Items.Clear();
            foreach (var peminjamans in dftpeminjamans)
            {
                var noUrut = lvwPinjaman.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(peminjamans.id_buku);
                item.SubItems.Add(peminjamans.id_member);
                item.SubItems.Add(peminjamans.id_staff);
                item.SubItems.Add(peminjamans.tgl_peminjaman.ToString("yyyy/MM/dd"));
                item.SubItems.Add(peminjamans.tgl_tempo.ToString("yyyy/MM/dd"));
                lvwPinjaman.Items.Add(item);
            }
        }

        private void OnCreate(Peminjaman peminjamans)
        {
            dftpeminjamans.Add(peminjamans);
            var noUrut = lvwPinjaman.Items.Count + 1;
            var item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(peminjamans.id_buku);
            item.SubItems.Add(peminjamans.id_member);
            item.SubItems.Add(peminjamans.id_staff);
            item.SubItems.Add(peminjamans.tgl_peminjaman.ToString("yyyy/MM/dd"));
            item.SubItems.Add(peminjamans.tgl_tempo.ToString("yyyy/MM/dd"));
            lvwPinjaman.Items.Add(item);

            memberController.UpdateActiveUser(peminjamans.id_member, this.active);
            bukuController.UpdateActive(peminjamans.id_buku, this.active);
            peminjamanController.Create(peminjamans);
        }

        private void btnPinjaman_Click(object sender, EventArgs e)
        {
            var frmInputPinjaman = new FrmInputPinjaman("Input Data");
            frmInputPinjaman.OnCreate += OnCreate;
            frmInputPinjaman.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TampilSearch();
        }
    }
}
