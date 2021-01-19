
namespace FP.View
{
    partial class FrmTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnPinjaman = new Guna.UI2.WinForms.Guna2Button();
            this.btnPengambalian = new Guna.UI2.WinForms.Guna2Button();
            this.pengembalians = new FP.View.Pengembalians();
            this.peminjamans = new FP.View.Peminjamans();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(149, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(157, 46);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Transaksi";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(953, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(46, 32);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPinjaman
            // 
            this.btnPinjaman.Animated = true;
            this.btnPinjaman.AutoRoundedCorners = true;
            this.btnPinjaman.BackColor = System.Drawing.Color.Transparent;
            this.btnPinjaman.BorderRadius = 21;
            this.btnPinjaman.CheckedState.Parent = this.btnPinjaman;
            this.btnPinjaman.CustomImages.Parent = this.btnPinjaman;
            this.btnPinjaman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPinjaman.ForeColor = System.Drawing.Color.White;
            this.btnPinjaman.HoverState.Parent = this.btnPinjaman;
            this.btnPinjaman.Location = new System.Drawing.Point(607, 530);
            this.btnPinjaman.Name = "btnPinjaman";
            this.btnPinjaman.ShadowDecoration.Parent = this.btnPinjaman;
            this.btnPinjaman.Size = new System.Drawing.Size(163, 45);
            this.btnPinjaman.TabIndex = 24;
            this.btnPinjaman.Text = "Peminjaman";
            this.btnPinjaman.Click += new System.EventHandler(this.btnPinjaman_Click);
            // 
            // btnPengambalian
            // 
            this.btnPengambalian.Animated = true;
            this.btnPengambalian.AutoRoundedCorners = true;
            this.btnPengambalian.BackColor = System.Drawing.Color.Transparent;
            this.btnPengambalian.BorderRadius = 21;
            this.btnPengambalian.CheckedState.Parent = this.btnPengambalian;
            this.btnPengambalian.CustomImages.Parent = this.btnPengambalian;
            this.btnPengambalian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPengambalian.ForeColor = System.Drawing.Color.White;
            this.btnPengambalian.HoverState.Parent = this.btnPengambalian;
            this.btnPengambalian.Location = new System.Drawing.Point(788, 530);
            this.btnPengambalian.Name = "btnPengambalian";
            this.btnPengambalian.ShadowDecoration.Parent = this.btnPengambalian;
            this.btnPengambalian.Size = new System.Drawing.Size(163, 45);
            this.btnPengambalian.TabIndex = 21;
            this.btnPengambalian.Text = "Pengembalian";
            this.btnPengambalian.Click += new System.EventHandler(this.btnPengambalian_Click);
            // 
            // pengembalians
            // 
            this.pengembalians.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.pengembalians.Location = new System.Drawing.Point(151, 131);
            this.pengembalians.Name = "pengembalians";
            this.pengembalians.Size = new System.Drawing.Size(800, 370);
            this.pengembalians.TabIndex = 27;
            // 
            // peminjamans
            // 
            this.peminjamans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.peminjamans.Location = new System.Drawing.Point(151, 131);
            this.peminjamans.Name = "peminjamans";
            this.peminjamans.Size = new System.Drawing.Size(800, 370);
            this.peminjamans.TabIndex = 28;
            // 
            // FrmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FP.Properties.Resources.transaksi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.peminjamans);
            this.Controls.Add(this.pengembalians);
            this.Controls.Add(this.btnPengambalian);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPinjaman);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnPinjaman;
        private Guna.UI2.WinForms.Guna2Button btnPengambalian;
        private Pengembalians pengembalians;
        private Peminjamans peminjamans;
    }
}