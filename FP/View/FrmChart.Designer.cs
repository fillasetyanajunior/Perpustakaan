
namespace FP.View
{
    partial class FrmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbTahun = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbPilihan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chartHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.cmbTahun);
            this.guna2Panel2.Controls.Add(this.cmbPilihan);
            this.guna2Panel2.Controls.Add(this.chartHistory);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.guna2Panel2.Location = new System.Drawing.Point(148, 138);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(802, 366);
            this.guna2Panel2.TabIndex = 20;
            // 
            // cmbTahun
            // 
            this.cmbTahun.Animated = true;
            this.cmbTahun.AutoRoundedCorners = true;
            this.cmbTahun.BackColor = System.Drawing.Color.Transparent;
            this.cmbTahun.BorderRadius = 17;
            this.cmbTahun.CheckedState.Parent = this.cmbTahun;
            this.cmbTahun.CustomFormat = "yyyy";
            this.cmbTahun.FillColor = System.Drawing.Color.White;
            this.cmbTahun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbTahun.HoverState.Parent = this.cmbTahun;
            this.cmbTahun.Location = new System.Drawing.Point(233, 13);
            this.cmbTahun.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cmbTahun.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.ShadowDecoration.Parent = this.cmbTahun;
            this.cmbTahun.Size = new System.Drawing.Size(200, 36);
            this.cmbTahun.TabIndex = 2;
            this.cmbTahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbTahun.Value = new System.DateTime(2021, 1, 18, 15, 21, 56, 375);
            // 
            // cmbPilihan
            // 
            this.cmbPilihan.Animated = true;
            this.cmbPilihan.AutoRoundedCorners = true;
            this.cmbPilihan.BackColor = System.Drawing.Color.Transparent;
            this.cmbPilihan.BorderRadius = 17;
            this.cmbPilihan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPilihan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPilihan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPilihan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPilihan.FocusedState.Parent = this.cmbPilihan;
            this.cmbPilihan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPilihan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPilihan.HoverState.Parent = this.cmbPilihan;
            this.cmbPilihan.ItemHeight = 30;
            this.cmbPilihan.Items.AddRange(new object[] {
            "Pilih Laporan",
            "Member",
            "Transaksi"});
            this.cmbPilihan.ItemsAppearance.Parent = this.cmbPilihan;
            this.cmbPilihan.Location = new System.Drawing.Point(16, 13);
            this.cmbPilihan.Name = "cmbPilihan";
            this.cmbPilihan.ShadowDecoration.Parent = this.cmbPilihan;
            this.cmbPilihan.Size = new System.Drawing.Size(195, 36);
            this.cmbPilihan.StartIndex = 0;
            this.cmbPilihan.TabIndex = 1;
            this.cmbPilihan.SelectedIndexChanged += new System.EventHandler(this.cmbPilihan_SelectedIndexChanged);
            // 
            // chartHistory
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistory.Legends.Add(legend1);
            this.chartHistory.Location = new System.Drawing.Point(16, 55);
            this.chartHistory.Name = "chartHistory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHistory.Series.Add(series1);
            this.chartHistory.Size = new System.Drawing.Size(768, 296);
            this.chartHistory.TabIndex = 0;
            this.chartHistory.Text = "chart1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(148, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(145, 46);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Laporan";
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
            this.btnClose.Location = new System.Drawing.Point(952, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(46, 32);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FP.Properties.Resources.grafik;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChart";
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPilihan;
        private Guna.UI2.WinForms.Guna2DateTimePicker cmbTahun;
    }
}