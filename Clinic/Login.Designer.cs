
namespace Clinic
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoleCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.HideBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 82);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinic Management System";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RoleCb
            // 
            this.RoleCb.BackColor = System.Drawing.Color.Transparent;
            this.RoleCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleCb.FocusedState.Parent = this.RoleCb;
            this.RoleCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.RoleCb.ForeColor = System.Drawing.Color.Black;
            this.RoleCb.HoverState.Parent = this.RoleCb;
            this.RoleCb.ItemHeight = 30;
            this.RoleCb.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.RoleCb.ItemsAppearance.Parent = this.RoleCb;
            this.RoleCb.Location = new System.Drawing.Point(83, 206);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.ShadowDecoration.Parent = this.RoleCb;
            this.RoleCb.Size = new System.Drawing.Size(217, 36);
            this.RoleCb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName";
            // 
            // UnameTb
            // 
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.DefaultText = "";
            this.UnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnameTb.DisabledState.Parent = this.UnameTb;
            this.UnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnameTb.FocusedState.Parent = this.UnameTb;
            this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameTb.ForeColor = System.Drawing.Color.Black;
            this.UnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnameTb.HoverState.Parent = this.UnameTb;
            this.UnameTb.Location = new System.Drawing.Point(83, 284);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.PasswordChar = '\0';
            this.UnameTb.PlaceholderText = "";
            this.UnameTb.SelectedText = "";
            this.UnameTb.ShadowDecoration.Parent = this.UnameTb;
            this.UnameTb.Size = new System.Drawing.Size(217, 36);
            this.UnameTb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // PassTb
            // 
            this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTb.DefaultText = "";
            this.PassTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassTb.DisabledState.Parent = this.PassTb;
            this.PassTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassTb.FocusedState.Parent = this.PassTb;
            this.PassTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTb.ForeColor = System.Drawing.Color.Black;
            this.PassTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassTb.HoverState.Parent = this.PassTb;
            this.PassTb.Location = new System.Drawing.Point(83, 357);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '\0';
            this.PassTb.PlaceholderText = "";
            this.PassTb.SelectedText = "";
            this.PassTb.ShadowDecoration.Parent = this.PassTb;
            this.PassTb.Size = new System.Drawing.Size(217, 36);
            this.PassTb.TabIndex = 6;
            // 
            // LoginBtn
            // 
            this.LoginBtn.ActiveBorderThickness = 1;
            this.LoginBtn.ActiveCornerRadius = 20;
            this.LoginBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.LoginBtn.ActiveForecolor = System.Drawing.Color.White;
            this.LoginBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleCornerRadius = 20;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginBtn.IdleForecolor = System.Drawing.Color.White;
            this.LoginBtn.IdleLineColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(97, 418);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(181, 44);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reset";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // HideBtn
            // 
            this.HideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideBtn.ForeColor = System.Drawing.Color.Black;
            this.HideBtn.Image = ((System.Drawing.Image)(resources.GetObject("HideBtn.Image")));
            this.HideBtn.Location = new System.Drawing.Point(261, 357);
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.Size = new System.Drawing.Size(39, 35);
            this.HideBtn.TabIndex = 9;
            this.HideBtn.UseVisualStyleBackColor = true;
            this.HideBtn.Click += new System.EventHandler(this.HideBtn_Click_1);
            // 
            // ShowBtn
            // 
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowBtn.Image")));
            this.ShowBtn.Location = new System.Drawing.Point(261, 357);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(39, 36);
            this.ShowBtn.TabIndex = 10;
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 519);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.HideBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoleCb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox PassTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox UnameTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox RoleCb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button HideBtn;
    }
}

