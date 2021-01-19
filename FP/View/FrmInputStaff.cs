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
    public partial class FrmInputStaff : Form
    {
        public delegate void CreateUpdateEventHandler(Staff staff);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private bool isNewData = true;
        private Staff staffs;
        public FrmInputStaff()
        {
            InitializeComponent();
        }
        public FrmInputStaff(string title)
            : this()
        {
            lblTitle.Text = title.ToString();
        }
        public FrmInputStaff(string title, Staff obj)
            : this()
        {
            lblTitle.Text = title.ToString();
            isNewData = false;
            staffs = obj;
            txtNama.Text = staffs.nama;
            txtUsername.Text = staffs.username;
            txtPassword.Text = staffs.password;
            cmbJenis.SelectedItem = staffs.jenis_kelamin.ToString();
            txtUmur.Text = staffs.umur.ToString();
            cmbStatus.SelectedItem = staffs.status_akun;
        }

        private void txtIDStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isNewData) staffs = new Staff();

             staffs.nama = txtNama.Text;
             staffs.username = txtUsername.Text;
             staffs.password = txtPassword.Text;
             staffs.jenis_kelamin = char.Parse(cmbJenis.SelectedItem.ToString());
             staffs.umur = int.Parse(txtUmur.Text);
             staffs.status_akun = cmbStatus.SelectedItem.ToString();
             staffs.terdaftar_sejak = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));

            if (isNewData)
            {
                OnCreate(staffs);
                txtNama.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtUmur.Clear();
            }
            else
            {
                OnUpdate(staffs);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
