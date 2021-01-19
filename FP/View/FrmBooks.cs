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
    public partial class FrmBooks : Form
    {
        private BukuController bukuController;
        private List<Buku> dftbuku = new List<Buku>();
        public FrmBooks()
        {
            InitializeComponent();
            bukuController = new BukuController();
            InisialisasiListView();
            Tampildata();
        }

        private void InisialisasiListView()
        {
            lvwBooks.View = System.Windows.Forms.View.Details;
            lvwBooks.FullRowSelect = true;
            lvwBooks.GridLines = true;
            lvwBooks.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwBooks.Columns.Add("ID Staff", 200, HorizontalAlignment.Center);
            lvwBooks.Columns.Add("Judul Buku", 150, HorizontalAlignment.Center);
            lvwBooks.Columns.Add("Pengarang", 150, HorizontalAlignment.Center);
            lvwBooks.Columns.Add("Penerbit", 150, HorizontalAlignment.Center);
            lvwBooks.Columns.Add("Status Buku", 150, HorizontalAlignment.Center);
        }
        private void Tampildata()
        {
            dftbuku = bukuController.ReadBuku();
            lvwBooks.Items.Clear();
            foreach (var books in dftbuku)
            {
                var noUrut = lvwBooks.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(books.id_staff);
                item.SubItems.Add(books.judul_buku);
                item.SubItems.Add(books.pengarang);
                item.SubItems.Add(books.penerbit);
                if (books.actives == 1)
                {
                    item.SubItems.Add("Tersedia");

                }
                else
                {
                    item.SubItems.Add("Dipinjam");
                }
                lvwBooks.Items.Add(item);
            }
        }
        private void OnCreate(Buku buku)
        {
            dftbuku.Add(buku);
            int noUrut = lvwBooks.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(buku.id_staff);
            item.SubItems.Add(buku.judul_buku);
            item.SubItems.Add(buku.pengarang);
            item.SubItems.Add(buku.penerbit);
            item.SubItems.Add(buku.actives.ToString());
            lvwBooks.Items.Add(item);

            bukuController.Create(buku);
            Tampildata();
        }
        private void OnUpdate(Buku buku)
        {
            int row = lvwBooks.SelectedIndices[0];
            ListViewItem itemRow = lvwBooks.Items[row];
            itemRow.SubItems[1].Text = buku.id_staff;
            itemRow.SubItems[2].Text = buku.judul_buku;
            itemRow.SubItems[3].Text = buku.pengarang;
            itemRow.SubItems[4].Text = buku.penerbit;

            bukuController.Update(buku);
            Tampildata();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var frmInputBooks = new FrmInputBooks("Input Data");
            frmInputBooks.OnCreate += OnCreate;
            frmInputBooks.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedItems.Count > 0)
            {
                Buku buku = dftbuku[lvwBooks.SelectedIndices[0]];
                var frmInputBooks = new FrmInputBooks("Update Data", buku);
                frmInputBooks.OnUpdate += OnUpdate;
                frmInputBooks.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedItems.Count > 0)
            {
                Buku buku = dftbuku[lvwBooks.SelectedIndices[0]];
                bukuController.Delete(buku);
                Tampildata();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
