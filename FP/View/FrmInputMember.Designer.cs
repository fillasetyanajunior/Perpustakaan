
namespace FP.View
{
    partial class FrmInputMember
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
            this.txtAlamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbJenis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUmur = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtAlamat);
            this.guna2Panel1.Controls.Add(this.cmbJenis);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Controls.Add(this.btnSubmit);
            this.guna2Panel1.Controls.Add(this.txtNama);
            this.guna2Panel1.Controls.Add(this.txtUmur);
            this.guna2Panel1.Controls.Add(this.txtNo);
            this.guna2Panel1.Location = new System.Drawing.Point(47, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(689, 350);
            this.guna2Panel1.TabIndex = 15;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Animated = true;
            this.txtAlamat.AutoRoundedCorners = true;
            this.txtAlamat.BorderRadius = 17;
            this.txtAlamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlamat.DefaultText = "";
            this.txtAlamat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlamat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlamat.DisabledState.Parent = this.txtAlamat;
            this.txtAlamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlamat.FocusedState.Parent = this.txtAlamat;
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlamat.HoverState.Parent = this.txtAlamat;
            this.txtAlamat.Location = new System.Drawing.Point(240, 119);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.PasswordChar = '\0';
            this.txtAlamat.PlaceholderText = "Alamat";
            this.txtAlamat.SelectedText = "";
            this.txtAlamat.ShadowDecoration.Parent = this.txtAlamat;
            this.txtAlamat.Size = new System.Drawing.Size(200, 36);
            this.txtAlamat.TabIndex = 13;
            // 
            // cmbJenis
            // 
            this.cmbJenis.Animated = true;
            this.cmbJenis.AutoRoundedCorners = true;
            this.cmbJenis.BackColor = System.Drawing.Color.Transparent;
            this.cmbJenis.BorderRadius = 17;
            this.cmbJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJenis.FocusedState.Parent = this.cmbJenis;
            this.cmbJenis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbJenis.HoverState.Parent = this.cmbJenis;
            this.cmbJenis.ItemHeight = 30;
            this.cmbJenis.Items.AddRange(new object[] {
            "Jenis Kelamin",
            "L",
            "P"});
            this.cmbJenis.ItemsAppearance.Parent = this.cmbJenis;
            this.cmbJenis.Location = new System.Drawing.Point(240, 185);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.ShadowDecoration.Parent = this.cmbJenis;
            this.cmbJenis.Size = new System.Drawing.Size(200, 36);
            this.cmbJenis.StartIndex = 0;
            this.cmbJenis.TabIndex = 10;
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
            // txtNama
            // 
            this.txtNama.Animated = true;
            this.txtNama.AutoRoundedCorners = true;
            this.txtNama.BorderRadius = 17;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.Parent = this.txtNama;
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.FocusedState.Parent = this.txtNama;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.HoverState.Parent = this.txtNama;
            this.txtNama.Location = new System.Drawing.Point(22, 119);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "Nama";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(200, 36);
            this.txtNama.TabIndex = 7;
            // 
            // txtUmur
            // 
            this.txtUmur.Animated = true;
            this.txtUmur.AutoRoundedCorners = true;
            this.txtUmur.BorderRadius = 17;
            this.txtUmur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUmur.DefaultText = "";
            this.txtUmur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUmur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUmur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUmur.DisabledState.Parent = this.txtUmur;
            this.txtUmur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUmur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUmur.FocusedState.Parent = this.txtUmur;
            this.txtUmur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUmur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUmur.HoverState.Parent = this.txtUmur;
            this.txtUmur.Location = new System.Drawing.Point(464, 119);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.PasswordChar = '\0';
            this.txtUmur.PlaceholderText = "Umur";
            this.txtUmur.SelectedText = "";
            this.txtUmur.ShadowDecoration.Parent = this.txtUmur;
            this.txtUmur.Size = new System.Drawing.Size(200, 36);
            this.txtUmur.TabIndex = 4;
            // 
            // txtNo
            // 
            this.txtNo.Animated = true;
            this.txtNo.AutoRoundedCorners = true;
            this.txtNo.BorderRadius = 17;
            this.txtNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNo.DefaultText = "";
            this.txtNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNo.DisabledState.Parent = this.txtNo;
            this.txtNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNo.FocusedState.Parent = this.txtNo;
            this.txtNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNo.HoverState.Parent = this.txtNo;
            this.txtNo.Location = new System.Drawing.Point(22, 183);
            this.txtNo.Name = "txtNo";
            this.txtNo.PasswordChar = '\0';
            this.txtNo.PlaceholderText = "No.Telpon";
            this.txtNo.SelectedText = "";
            this.txtNo.ShadowDecoration.Parent = this.txtNo;
            this.txtNo.Size = new System.Drawing.Size(200, 36);
            this.txtNo.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(752, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(46, 32);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FrmInputMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInputMember";
            this.Text = "FrmInputMember";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtAlamat;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJenis;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtUmur;
        private Guna.UI2.WinForms.Guna2TextBox txtNo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}