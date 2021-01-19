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
    public partial class FrmMember : Form
    {
        private MemberController memberController;
        private List<Member> dftmember = new List<Member>();
        public FrmMember()
        {
            InitializeComponent();
            memberController = new MemberController();
            InisialisasiListView();
            Tampildata();
        }

        private void InisialisasiListView()
        {
            lvwMember.View = System.Windows.Forms.View.Details;
            lvwMember.FullRowSelect = true;
            lvwMember.GridLines = true;
            lvwMember.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwMember.Columns.Add("Nama", 240, HorizontalAlignment.Center);
            lvwMember.Columns.Add("Alamat", 200, HorizontalAlignment.Center);
            lvwMember.Columns.Add("Tanggal Pendaftaran", 150, HorizontalAlignment.Center);
            lvwMember.Columns.Add("Umur", 150, HorizontalAlignment.Center);
            lvwMember.Columns.Add("Jenis Kelamin", 150, HorizontalAlignment.Center);
            lvwMember.Columns.Add("No Hp", 150, HorizontalAlignment.Center);
        }
        private void Tampildata()
        {
            dftmember = memberController.ReadMember();
            lvwMember.Items.Clear();
            foreach (var members in dftmember)
            {
                var noUrut = lvwMember.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(members.nama);
                item.SubItems.Add(members.alamat);
                item.SubItems.Add(members.terdaftar_sejak.ToString("yyyy/MM/dd"));
                item.SubItems.Add(members.umur.ToString());
                item.SubItems.Add(members.jenis_kelamin.ToString());
                item.SubItems.Add(members.telpon);
                lvwMember.Items.Add(item);
            }
        }

        private void OnCreate(Member members)
        {
            dftmember.Add(members);
            int noUrut = lvwMember.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(members.nama);
            item.SubItems.Add(members.alamat);
            item.SubItems.Add(members.terdaftar_sejak.ToString());
            item.SubItems.Add(members.umur.ToString());
            item.SubItems.Add(members.jenis_kelamin.ToString());
            item.SubItems.Add(members.telpon);
            item.SubItems.Add(members.actives.ToString());
            lvwMember.Items.Add(item);

            memberController.Create(members);
        }
        private void OnUpdate(Member members)
        {
            int row = lvwMember.SelectedIndices[0];
            ListViewItem itemRow = lvwMember.Items[row];
            itemRow.SubItems[1].Text = members.nama;
            itemRow.SubItems[2].Text = members.alamat;
            itemRow.SubItems[3].Text = members.terdaftar_sejak.ToString("yyyy/MM/dd");
            itemRow.SubItems[4].Text = members.umur.ToString();
            itemRow.SubItems[5].Text = members.jenis_kelamin.ToString();
            itemRow.SubItems[6].Text = members.telpon;

            memberController.Update(members);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var frmInputMember = new FrmInputMember("Input Data");
            frmInputMember.OnCreate += OnCreate;
            frmInputMember.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwMember.SelectedItems.Count > 0)
            {
                Member member = dftmember[lvwMember.SelectedIndices[0]];
                var frmInputMember = new FrmInputMember("Update Data", member);
                frmInputMember.OnUpdate += OnUpdate;
                frmInputMember.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwMember.SelectedItems.Count > 0)
            {
                Member member = dftmember[lvwMember.SelectedIndices[0]];
                memberController.Delete(member);
                Tampildata();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
