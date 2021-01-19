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
    public partial class FrmInputBooks : Form
    {
        public delegate void CreateUpdateEventHandler(Buku bukus);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private bool isNewData = true;
        private Buku bukus;

        private StaffController staffController;
        public FrmInputBooks()
        {
            InitializeComponent();
            staffController = new StaffController();
            staffController = new StaffController();
            TampilData();
        }
        public FrmInputBooks(string title)
            : this()
        {
            lblTitle.Text = title.ToString();
        }
        public FrmInputBooks(string title, Buku obj)
            : this()
        {
            lblTitle.Text = title.ToString();
            isNewData = false;
            bukus = obj;
            cmbIDStaff.SelectedItem = bukus.id_staff.ToString();
            txtJudul.Text = bukus.judul_buku.ToString();
            txtPengarang.Text = bukus.pengarang.ToString();
            txtPenerbit.Text = bukus.penerbit.ToString();
        }

        private void TampilData()
        {
            //Pilihan Maskapai
            var staff = new List<Staff>();
            staff = staffController.ReadAllStaff();
            cmbIDStaff.Items.Add("ID Staff");
            foreach (var staffs in staff)
            {
                cmbIDStaff.Items.Add(staffs.id);
            }
            cmbIDStaff.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isNewData) bukus = new Buku();

             bukus.id_staff = cmbIDStaff.SelectedItem.ToString();
             bukus.judul_buku = txtJudul.Text;
             bukus.pengarang= txtPengarang.Text;
             bukus.penerbit = txtPenerbit.Text;
             bukus.actives = 1;

            if (isNewData)
            {
                OnCreate(bukus);
                txtJudul.Clear();
                txtPengarang.Clear();
                txtPenerbit.Clear();
            }
            else
            {
                OnUpdate(bukus);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
