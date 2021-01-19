using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FP.Controller;
using FP.Model.Entity;

namespace FP.View
{
    public partial class FrmChart : Form
    {
        private MemberController memberController;
        private PengembalianController pengembalianController;
        public FrmChart()
        {
            InitializeComponent();
            memberController = new MemberController();
            pengembalianController = new PengembalianController();
        }

       private void Tampildata()
        {
            if(cmbPilihan.SelectedItem.ToString() == "Member")
            {
                Member member = new Member();

                var tahunan = cmbTahun.Text;
                cmbTahun.Visible = true;

                member = memberController.ReadCount(tahunan);

                chartHistory.Series.Clear();

                foreach(var members in member.id.ToString())
                {

                    //Membuat series nama barang/reader[0]
                    Series series = chartHistory.Series.Add("Member");

                    //Menyambungkan series nama barang ke jumlah penjualan/reader[1]
                    series.Points.Add(Convert.ToInt32(members.ToString()));
                }
            }
            else
            {
                Pengembalian pengembalian = new Pengembalian();

                var tahunans = cmbTahun.Text;
                cmbTahun.Visible = true;

                pengembalian = pengembalianController.ReadCount(tahunans);

                chartHistory.Series.Clear();

                foreach(var pengembalians in pengembalian.id.ToString())
                {

                    //Membuat series nama barang/reader[0]
                    Series series = chartHistory.Series.Add("Transaksi");

                    //Menyambungkan series nama barang ke jumlah penjualan/reader[1]
                    series.Points.Add(Convert.ToInt32(pengembalians.ToString()));
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tampildata();
        }
    }
}
