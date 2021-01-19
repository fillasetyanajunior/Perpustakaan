
namespace FP.View
{
    partial class FrmInputBooks
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtJudul = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbIDStaff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtPenerbit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPengarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtJudul);
            this.guna2Panel1.Controls.Add(this.cmbIDStaff);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Controls.Add(this.btnSubmit);
            this.guna2Panel1.Controls.Add(this.txtPenerbit);
            this.guna2Panel1.Controls.Add(this.txtPengarang);
            this.guna2Panel1.Location = new System.Drawing.Point(50, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(689, 350);
            this.guna2Panel1.TabIndex = 1;
            // 
            // txtJudul
            // 
            this.txtJudul.Animated = true;
            this.txtJudul.AutoRoundedCorners = true;
            this.txtJudul.BorderRadius = 17;
            this.txtJudul.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJudul.DefaultText = "";
            this.txtJudul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJudul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJudul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJudul.DisabledState.Parent = this.txtJudul;
            this.txtJudul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJudul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJudul.FocusedState.Parent = this.txtJudul;
            this.txtJudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJudul.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJudul.HoverState.Parent = this.txtJudul;
            this.txtJudul.Location = new System.Drawing.Point(464, 119);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.PasswordChar = '\0';
            this.txtJudul.PlaceholderText = "Judul Buku";
            this.txtJudul.SelectedText = "";
            this.txtJudul.ShadowDecoration.Parent = this.txtJudul;
            this.txtJudul.Size = new System.Drawing.Size(200, 36);
            this.txtJudul.TabIndex = 13;
            this.txtJudul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbIDStaff
            // 
            this.cmbIDStaff.Animated = true;
            this.cmbIDStaff.AutoRoundedCorners = true;
            this.cmbIDStaff.BackColor = System.Drawing.Color.Transparent;
            this.cmbIDStaff.BorderRadius = 17;
            this.cmbIDStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIDStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDStaff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDStaff.FocusedState.Parent = this.cmbIDStaff;
            this.cmbIDStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIDStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIDStaff.HoverState.Parent = this.cmbIDStaff;
            this.cmbIDStaff.ItemHeight = 30;
            this.cmbIDStaff.ItemsAppearance.Parent = this.cmbIDStaff;
            this.cmbIDStaff.Location = new System.Drawing.Point(240, 119);
            this.cmbIDStaff.Name = "cmbIDStaff";
            this.cmbIDStaff.ShadowDecoration.Parent = this.cmbIDStaff;
            this.cmbIDStaff.Size = new System.Drawing.Size(200, 36);
            this.cmbIDStaff.TabIndex = 12;
            this.cmbIDStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtPenerbit
            // 
            this.txtPenerbit.Animated = true;
            this.txtPenerbit.AutoRoundedCorners = true;
            this.txtPenerbit.BorderRadius = 17;
            this.txtPenerbit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPenerbit.DefaultText = "";
            this.txtPenerbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPenerbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPenerbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenerbit.DisabledState.Parent = this.txtPenerbit;
            this.txtPenerbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenerbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenerbit.FocusedState.Parent = this.txtPenerbit;
            this.txtPenerbit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPenerbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenerbit.HoverState.Parent = this.txtPenerbit;
            this.txtPenerbit.Location = new System.Drawing.Point(34, 188);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.PasswordChar = '\0';
            this.txtPenerbit.PlaceholderText = "Penerbit";
            this.txtPenerbit.SelectedText = "";
            this.txtPenerbit.ShadowDecoration.Parent = this.txtPenerbit;
            this.txtPenerbit.Size = new System.Drawing.Size(200, 36);
            this.txtPenerbit.TabIndex = 4;
            this.txtPenerbit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPengarang
            // 
            this.txtPengarang.Animated = true;
            this.txtPengarang.AutoRoundedCorners = true;
            this.txtPengarang.BorderRadius = 17;
            this.txtPengarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPengarang.DefaultText = "";
            this.txtPengarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPengarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPengarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPengarang.DisabledState.Parent = this.txtPengarang;
            this.txtPengarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPengarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPengarang.FocusedState.Parent = this.txtPengarang;
            this.txtPengarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPengarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPengarang.HoverState.Parent = this.txtPengarang;
            this.txtPengarang.Location = new System.Drawing.Point(34, 119);
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.PasswordChar = '\0';
            this.txtPengarang.PlaceholderText = "Pengarang";
            this.txtPengarang.SelectedText = "";
            this.txtPengarang.ShadowDecoration.Parent = this.txtPengarang;
            this.txtPengarang.Size = new System.Drawing.Size(200, 36);
            this.txtPengarang.TabIndex = 1;
            this.txtPengarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(755, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(46, 32);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmInputBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInputBooks";
            this.Text = "FrmInputBooks";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtPenerbit;
        private Guna.UI2.WinForms.Guna2TextBox txtPengarang;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIDStaff;
        private Guna.UI2.WinForms.Guna2TextBox txtJudul;
    }
}