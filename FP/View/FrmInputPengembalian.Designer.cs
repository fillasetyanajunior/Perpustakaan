
namespace FP.View
{
    partial class FrmInputPengembalian
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
            this.dtpPengambalian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtIDMember = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDBuku = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPengambalian
            // 
            this.dtpPengambalian.Animated = true;
            this.dtpPengambalian.AutoRoundedCorners = true;
            this.dtpPengambalian.BorderRadius = 17;
            this.dtpPengambalian.CheckedState.Parent = this.dtpPengambalian;
            this.dtpPengambalian.CustomFormat = "yyyy/MM/dd hh:mm";
            this.dtpPengambalian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpPengambalian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPengambalian.HoverState.Parent = this.dtpPengambalian;
            this.dtpPengambalian.Location = new System.Drawing.Point(464, 119);
            this.dtpPengambalian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPengambalian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPengambalian.Name = "dtpPengambalian";
            this.dtpPengambalian.ShadowDecoration.Parent = this.dtpPengambalian;
            this.dtpPengambalian.Size = new System.Drawing.Size(200, 36);
            this.dtpPengambalian.TabIndex = 12;
            this.dtpPengambalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpPengambalian.Value = new System.DateTime(2021, 1, 16, 22, 58, 8, 738);
            this.dtpPengambalian.ValueChanged += new System.EventHandler(this.dtpPengambalian_ValueChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dtpPengambalian);
            this.guna2Panel1.Controls.Add(this.txtIDMember);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Controls.Add(this.btnSubmit);
            this.guna2Panel1.Controls.Add(this.txtIDStaff);
            this.guna2Panel1.Controls.Add(this.txtIDBuku);
            this.guna2Panel1.Location = new System.Drawing.Point(47, 74);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(689, 350);
            this.guna2Panel1.TabIndex = 19;
            // 
            // txtIDMember
            // 
            this.txtIDMember.Animated = true;
            this.txtIDMember.AutoRoundedCorners = true;
            this.txtIDMember.BorderRadius = 17;
            this.txtIDMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDMember.DefaultText = "";
            this.txtIDMember.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDMember.DisabledState.Parent = this.txtIDMember;
            this.txtIDMember.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDMember.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMember.FocusedState.Parent = this.txtIDMember;
            this.txtIDMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDMember.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMember.HoverState.Parent = this.txtIDMember;
            this.txtIDMember.Location = new System.Drawing.Point(22, 119);
            this.txtIDMember.Name = "txtIDMember";
            this.txtIDMember.PasswordChar = '\0';
            this.txtIDMember.PlaceholderText = "ID Member";
            this.txtIDMember.SelectedText = "";
            this.txtIDMember.ShadowDecoration.Parent = this.txtIDMember;
            this.txtIDMember.Size = new System.Drawing.Size(200, 36);
            this.txtIDMember.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(293, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Input";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderRadius = 21;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(464, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(200, 45);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Animated = true;
            this.txtIDStaff.AutoRoundedCorners = true;
            this.txtIDStaff.BorderRadius = 17;
            this.txtIDStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDStaff.DefaultText = "";
            this.txtIDStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDStaff.DisabledState.Parent = this.txtIDStaff;
            this.txtIDStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDStaff.FocusedState.Parent = this.txtIDStaff;
            this.txtIDStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDStaff.HoverState.Parent = this.txtIDStaff;
            this.txtIDStaff.Location = new System.Drawing.Point(240, 119);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.PasswordChar = '\0';
            this.txtIDStaff.PlaceholderText = "ID Staff";
            this.txtIDStaff.SelectedText = "";
            this.txtIDStaff.ShadowDecoration.Parent = this.txtIDStaff;
            this.txtIDStaff.Size = new System.Drawing.Size(200, 36);
            this.txtIDStaff.TabIndex = 7;
            // 
            // txtIDBuku
            // 
            this.txtIDBuku.Animated = true;
            this.txtIDBuku.AutoRoundedCorners = true;
            this.txtIDBuku.BorderRadius = 17;
            this.txtIDBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDBuku.DefaultText = "";
            this.txtIDBuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDBuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDBuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBuku.DisabledState.Parent = this.txtIDBuku;
            this.txtIDBuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBuku.FocusedState.Parent = this.txtIDBuku;
            this.txtIDBuku.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDBuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBuku.HoverState.Parent = this.txtIDBuku;
            this.txtIDBuku.Location = new System.Drawing.Point(22, 183);
            this.txtIDBuku.Name = "txtIDBuku";
            this.txtIDBuku.PasswordChar = '\0';
            this.txtIDBuku.PlaceholderText = "ID Buku";
            this.txtIDBuku.SelectedText = "";
            this.txtIDBuku.ShadowDecoration.Parent = this.txtIDBuku;
            this.txtIDBuku.Size = new System.Drawing.Size(200, 36);
            this.txtIDBuku.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(752, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(46, 32);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmInputPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInputPengembalian";
            this.Text = "FrmInputPengambalian";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPengambalian;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtIDMember;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtIDStaff;
        private Guna.UI2.WinForms.Guna2TextBox txtIDBuku;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}