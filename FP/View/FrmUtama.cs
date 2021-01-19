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
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
           
        }

        private void btnBuku_Click_1(object sender, EventArgs e)
        {
            FrmBooks frmBooks = new FrmBooks();
            frmBooks.ShowDialog();
        }

        private void btnMember_Click_1(object sender, EventArgs e)
        {
            FrmMember frmMember = new FrmMember();
            frmMember.Show();
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            FrmStaff frmStaff = new FrmStaff();
            frmStaff.ShowDialog();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FrmTransaksi frmTransaksi = new FrmTransaksi();
            frmTransaksi.ShowDialog();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FrmChart frmChart = new FrmChart();
            frmChart.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var pesan = "Apakah anda yakin ingin mengakhiri sesi login anda dan logout aplikasi?";
            DialogResult = MessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                var frmUtama = (FrmUtama)Application.OpenForms["FrmUtama"];
                var fLogin = new FrmLogin();
                frmUtama.Close();
                fLogin.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToString();
        }

        private void FrmUtama_Load(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm");
            timer1.Enabled = true;
        }
    }
}
