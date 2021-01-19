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
    public partial class FrmInputMember : Form
    {
        public delegate void CreateUpdateEventHandler(Member member);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private bool isNewData = true;
        private Member members;
        public FrmInputMember()
        {
            InitializeComponent();
        }
        public FrmInputMember(string title)
            : this()
        {
            lblTitle.Text = title.ToString();
        }
        public FrmInputMember(string title, Member obj)
            : this()
        {
            lblTitle.Text = title.ToString();
            isNewData = false;
            members = obj;
            txtNama.Text = members.nama;
            txtAlamat.Text = members.alamat;
            txtNo.Text = members.telpon;
            cmbJenis.SelectedItem = members.jenis_kelamin.ToString();
            txtUmur.Text = members.umur.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isNewData) members = new Member();

            members.nama = txtNama.Text;
            members.alamat = txtAlamat.Text;
            members.telpon = txtNo.Text;
            members.jenis_kelamin = char.Parse(cmbJenis.SelectedItem.ToString());
            members.umur = int.Parse(txtUmur.Text);
            members.terdaftar_sejak = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
            members.actives = 1;

            if (isNewData)
            {
                OnCreate(members);
                txtNama.Clear();
                txtAlamat.Clear();
                txtNo.Clear();
                txtUmur.Clear();
            }
            else
            {
                OnUpdate(members);
                this.Close();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
