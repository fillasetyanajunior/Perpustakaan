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
    public partial class FrmStaff : Form
    {
        private StaffController staffController;
        private List<Staff> dftstaff = new List<Staff>();
        public FrmStaff()
        {
            InitializeComponent();
            staffController = new StaffController();
            InisialisasiListView();
            Tampildata();
        }

        private void InisialisasiListView()
        {
            lvwStaff.View = System.Windows.Forms.View.Details;
            lvwStaff.FullRowSelect = true;
            lvwStaff.GridLines = true;
            lvwStaff.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwStaff.Columns.Add("Status Akun", 200, HorizontalAlignment.Center);
            lvwStaff.Columns.Add("Nama", 150, HorizontalAlignment.Center);
            lvwStaff.Columns.Add("Username", 150, HorizontalAlignment.Center);
            lvwStaff.Columns.Add("Jenis Kelamin", 150, HorizontalAlignment.Center);
            lvwStaff.Columns.Add("Umur", 150, HorizontalAlignment.Center);
            lvwStaff.Columns.Add("Tanggal Pendaftar", 150, HorizontalAlignment.Center);
        }
        private void Tampildata()
        {
            dftstaff = staffController.ReadAllStaff();
            lvwStaff.Items.Clear();
            foreach (var staffs in dftstaff)
            {
                var noUrut = lvwStaff.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(staffs.status_akun);
                item.SubItems.Add(staffs.nama);
                item.SubItems.Add(staffs.username);
                item.SubItems.Add(staffs.jenis_kelamin.ToString());
                item.SubItems.Add(staffs.umur.ToString());
                item.SubItems.Add(staffs.terdaftar_sejak.ToString("yyyy/MM/dd"));
                lvwStaff.Items.Add(item);
            }
        }

        private void OnCreate(Staff staffs)
        {
            dftstaff.Add(staffs);
            int noUrut = lvwStaff.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(staffs.status_akun);
            item.SubItems.Add(staffs.nama);
            item.SubItems.Add(staffs.username);
            item.SubItems.Add(staffs.jenis_kelamin.ToString());
            item.SubItems.Add(staffs.umur.ToString());
            item.SubItems.Add(staffs.terdaftar_sejak.ToString("yyyy/MM/dd"));
            lvwStaff.Items.Add(item);

            staffController.Create(staffs);
        }
        private void OnUpdate(Staff staffs)
        {
            int row = lvwStaff.SelectedIndices[0];
            ListViewItem itemRow = lvwStaff.Items[row];
            itemRow.SubItems[1].Text = staffs.status_akun;
            itemRow.SubItems[2].Text = staffs.nama;
            itemRow.SubItems[3].Text = staffs.username;
            itemRow.SubItems[4].Text = staffs.password;
            itemRow.SubItems[5].Text = staffs.jenis_kelamin.ToString();
            itemRow.SubItems[6].Text = staffs.umur.ToString();
            itemRow.SubItems[7].Text = staffs.terdaftar_sejak.ToString("yyyy/MM/dd");

            staffController.Update(staffs);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            var frmInputStaff = new FrmInputStaff("Input Data");
            frmInputStaff.OnCreate += OnCreate;
            frmInputStaff.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwStaff.SelectedItems.Count > 0)
            {
                Staff staff = dftstaff[lvwStaff.SelectedIndices[0]];
                var frmInputStaff = new FrmInputStaff("Update Data", staff);
                frmInputStaff.OnUpdate += OnUpdate;
                frmInputStaff.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwStaff.SelectedItems.Count > 0)
            {
                Staff staff = dftstaff[lvwStaff.SelectedIndices[0]];
                staffController.Delete(staff);
                Tampildata();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
