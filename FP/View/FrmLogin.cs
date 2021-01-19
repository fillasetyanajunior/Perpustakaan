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
    public partial class FrmLogin : Form
    {
        private StaffController staffController;
        public FrmLogin()
        {
            InitializeComponent();
            staffController = new StaffController();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var result = 0;
            var staffvalidasi = new Staff();
            var login = new Staff();

            staffvalidasi.username = txtUsername.Text;
            staffvalidasi.password = txtPassword.Text;

            result = staffController.ValidasiLogin(staffvalidasi);

            if (result > 0)
            {
                login = staffController.Auth(staffvalidasi);

                if (!string.IsNullOrEmpty(login.nama))
                {
                    if (login.status_akun == "Active")
                    {
                        var frmUtama = new FrmUtama();
                        frmUtama.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Akun Anda Sudah Tidak Aktif!!");
                    }
                }
                else
                    MessageBox.Show("Login Gagal!" + "\n" + "Username/Password yang anda masukan salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
