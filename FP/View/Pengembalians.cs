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
    public partial class Pengembalians : UserControl
    {
        private PengembalianController pengembalianController;
        private PeminjamanController peminjamanController;
        private MemberController memberController;
        private BukuController bukuController;
        private List<Pengembalian> dftpengembalian = new List<Pengembalian>();
        public string id_buku;
        public string id_staff;
        public string id_member;
        public DateTime tgl_peminjaman;

        private int active = 1;

        public bool bener;
        public Pengembalians()
        {
            InitializeComponent();
            peminjamanController = new PeminjamanController();
            pengembalianController = new PengembalianController();
            memberController = new MemberController();
            bukuController = new BukuController();
            InisialisasiListView();
            Tampildata();
        }
        private void InisialisasiListView()
        {
            lvwPengembalian.View = System.Windows.Forms.View.Details;
            lvwPengembalian.FullRowSelect = true;
            lvwPengembalian.GridLines = true;
            lvwPengembalian.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwPengembalian.Columns.Add("ID Buku", 240, HorizontalAlignment.Center);
            lvwPengembalian.Columns.Add("ID Member", 200, HorizontalAlignment.Center);
            lvwPengembalian.Columns.Add("ID Staff", 150, HorizontalAlignment.Center);
            lvwPengembalian.Columns.Add("Tanggal Peminjaman", 150, HorizontalAlignment.Center);
            lvwPengembalian.Columns.Add("Tanggal Pengembalian", 150, HorizontalAlignment.Center);
            lvwPengembalian.Columns.Add("Denda", 150, HorizontalAlignment.Center);
        }
        private void Tampildata()
        {
            dftpengembalian = pengembalianController.ReadAll();
            lvwPengembalian.Items.Clear();
            foreach (var pengembalian in dftpengembalian)
            {
                var noUrut = lvwPengembalian.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pengembalian.id_buku);
                item.SubItems.Add(pengembalian.id_member);
                item.SubItems.Add(pengembalian.id_staff);
                item.SubItems.Add(pengembalian.tgl_peminjaman.ToString("yyyy/MM/dd"));
                item.SubItems.Add(pengembalian.tgl_pengembalian.ToString("yyyy/MM/dd"));
                item.SubItems.Add(pengembalian.denda);
                lvwPengembalian.Items.Add(item);
            }
        }

        private void TampilSearch()
        {
            dftpengembalian = pengembalianController.ReadSearch(txtSearch.Text);
            lvwPengembalian.Items.Clear();
            foreach (var pengembalian in dftpengembalian)
            {
                var noUrut = lvwPengembalian.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pengembalian.id_buku);
                item.SubItems.Add(pengembalian.id_member);
                item.SubItems.Add(pengembalian.id_staff);
                item.SubItems.Add(pengembalian.tgl_peminjaman.ToString("yyyy/MM/dd"));
                item.SubItems.Add(pengembalian.tgl_pengembalian.ToString("yyyy/MM/dd"));
                item.SubItems.Add(pengembalian.denda);
                lvwPengembalian.Items.Add(item);
            }
        }

        private void OnCreate(Pengembalian pengembalian)
        {
            dftpengembalian.Add(pengembalian);
            var noUrut = lvwPengembalian.Items.Count + 1;
            var item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pengembalian.id_buku);
            item.SubItems.Add(pengembalian.id_member);
            item.SubItems.Add(pengembalian.id_staff);
            item.SubItems.Add(pengembalian.tgl_peminjaman.ToString("yyyy/MM/dd"));
            item.SubItems.Add(pengembalian.tgl_pengembalian.ToString("yyyy/MM/dd"));
            item.SubItems.Add(pengembalian.denda);
            lvwPengembalian.Items.Add(item);

            peminjamanController.Delete(pengembalian.id_member);
            memberController.UpdateActiveUser(pengembalian.id_member, this.active);
            bukuController.UpdateActive(pengembalian.id_buku, this.active);
            pengembalianController.Create(pengembalian);
        }

        private void btnPengambalian_Click(object sender, EventArgs e)
        {
            if (bener == true)
            {
                var frmInputPengembalian = new FrmInputPengembalian("Input Data", this.id_buku, this.id_staff, this.id_member,this.bener,this.tgl_peminjaman);
                frmInputPengembalian.OnCreate += OnCreate;
                frmInputPengembalian.ShowDialog();
            }
            else
            {
                var frmInputPengembalian = new FrmInputPengembalian("Input Data", this.id_buku, this.id_staff, this.id_member, this.bener, this.tgl_peminjaman);
                frmInputPengembalian.OnCreate += OnCreate;
                frmInputPengembalian.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TampilSearch();
        }
    }
}
