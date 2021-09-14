
namespace Clinic
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.HomeLbl = new System.Windows.Forms.Label();
            this.LogoutLbl = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.RecepLbl = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.LabTestLbl = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.DoctorLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PatGenCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PatHIVCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PatAlTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PatPhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.PatDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.PatAddTb = new System.Windows.Forms.TextBox();
            this.PatientsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.HomeLbl);
            this.panel1.Controls.Add(this.LogoutLbl);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.RecepLbl);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.LabTestLbl);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.DoctorLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 784);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(24, 184);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 55);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // HomeLbl
            // 
            this.HomeLbl.AutoSize = true;
            this.HomeLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLbl.ForeColor = System.Drawing.Color.Black;
            this.HomeLbl.Location = new System.Drawing.Point(85, 203);
            this.HomeLbl.Name = "HomeLbl";
            this.HomeLbl.Size = new System.Drawing.Size(65, 23);
            this.HomeLbl.TabIndex = 4;
            this.HomeLbl.Text = "Home";
            this.HomeLbl.Click += new System.EventHandler(this.HomeLbl_Click);
            // 
            // LogoutLbl
            // 
            this.LogoutLbl.AutoSize = true;
            this.LogoutLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLbl.ForeColor = System.Drawing.Color.Black;
            this.LogoutLbl.Location = new System.Drawing.Point(88, 708);
            this.LogoutLbl.Name = "LogoutLbl";
            this.LogoutLbl.Size = new System.Drawing.Size(72, 23);
            this.LogoutLbl.TabIndex = 13;
            this.LogoutLbl.Text = "Logout";
            this.LogoutLbl.Click += new System.EventHandler(this.LogoutLbl_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(24, 688);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(55, 55);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(24, 494);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(55, 55);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // RecepLbl
            // 
            this.RecepLbl.AutoSize = true;
            this.RecepLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecepLbl.ForeColor = System.Drawing.Color.Black;
            this.RecepLbl.Location = new System.Drawing.Point(85, 513);
            this.RecepLbl.Name = "RecepLbl";
            this.RecepLbl.Size = new System.Drawing.Size(131, 23);
            this.RecepLbl.TabIndex = 10;
            this.RecepLbl.Text = "Receptionists";
            this.RecepLbl.Click += new System.EventHandler(this.RecepLbl_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(24, 392);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(55, 55);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // LabTestLbl
            // 
            this.LabTestLbl.AutoSize = true;
            this.LabTestLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTestLbl.ForeColor = System.Drawing.Color.Black;
            this.LabTestLbl.Location = new System.Drawing.Point(85, 411);
            this.LabTestLbl.Name = "LabTestLbl";
            this.LabTestLbl.Size = new System.Drawing.Size(110, 23);
            this.LabTestLbl.TabIndex = 8;
            this.LabTestLbl.Text = "Laboratory";
            this.LabTestLbl.Click += new System.EventHandler(this.LabTestLbl_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(24, 290);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(55, 55);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // DoctorLbl
            // 
            this.DoctorLbl.AutoSize = true;
            this.DoctorLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorLbl.ForeColor = System.Drawing.Color.Black;
            this.DoctorLbl.Location = new System.Drawing.Point(85, 309);
            this.DoctorLbl.Name = "DoctorLbl";
            this.DoctorLbl.Size = new System.Drawing.Size(79, 23);
            this.DoctorLbl.TabIndex = 6;
            this.DoctorLbl.Text = "Doctors";
            this.DoctorLbl.Click += new System.EventHandler(this.DoctorLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1534, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(827, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Minute Clinic";
            // 
            // PatNameTb
            // 
            this.PatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatNameTb.DefaultText = "";
            this.PatNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatNameTb.DisabledState.Parent = this.PatNameTb;
            this.PatNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatNameTb.FocusedState.Parent = this.PatNameTb;
            this.PatNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatNameTb.HoverState.Parent = this.PatNameTb;
            this.PatNameTb.Location = new System.Drawing.Point(308, 184);
            this.PatNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.PasswordChar = '\0';
            this.PatNameTb.PlaceholderText = "";
            this.PatNameTb.SelectedText = "";
            this.PatNameTb.ShadowDecoration.Parent = this.PatNameTb;
            this.PatNameTb.Size = new System.Drawing.Size(259, 36);
            this.PatNameTb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(304, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patient Name";
            // 
            // PatGenCb
            // 
            this.PatGenCb.BackColor = System.Drawing.Color.Transparent;
            this.PatGenCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatGenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatGenCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatGenCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatGenCb.FocusedState.Parent = this.PatGenCb;
            this.PatGenCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatGenCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PatGenCb.HoverState.Parent = this.PatGenCb;
            this.PatGenCb.ItemHeight = 30;
            this.PatGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatGenCb.ItemsAppearance.Parent = this.PatGenCb;
            this.PatGenCb.Location = new System.Drawing.Point(626, 184);
            this.PatGenCb.Name = "PatGenCb";
            this.PatGenCb.ShadowDecoration.Parent = this.PatGenCb;
            this.PatGenCb.Size = new System.Drawing.Size(140, 36);
            this.PatGenCb.TabIndex = 11;
            // 
            // PatHIVCb
            // 
            this.PatHIVCb.BackColor = System.Drawing.Color.Transparent;
            this.PatHIVCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatHIVCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatHIVCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatHIVCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatHIVCb.FocusedState.Parent = this.PatHIVCb;
            this.PatHIVCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatHIVCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PatHIVCb.HoverState.Parent = this.PatHIVCb;
            this.PatHIVCb.ItemHeight = 30;
            this.PatHIVCb.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.PatHIVCb.ItemsAppearance.Parent = this.PatHIVCb;
            this.PatHIVCb.Location = new System.Drawing.Point(821, 184);
            this.PatHIVCb.Name = "PatHIVCb";
            this.PatHIVCb.ShadowDecoration.Parent = this.PatHIVCb;
            this.PatHIVCb.Size = new System.Drawing.Size(140, 36);
            this.PatHIVCb.TabIndex = 12;
            // 
            // PatAlTb
            // 
            this.PatAlTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatAlTb.DefaultText = "";
            this.PatAlTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatAlTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatAlTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatAlTb.DisabledState.Parent = this.PatAlTb;
            this.PatAlTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatAlTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatAlTb.FocusedState.Parent = this.PatAlTb;
            this.PatAlTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAlTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatAlTb.HoverState.Parent = this.PatAlTb;
            this.PatAlTb.Location = new System.Drawing.Point(1015, 184);
            this.PatAlTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatAlTb.Name = "PatAlTb";
            this.PatAlTb.PasswordChar = '\0';
            this.PatAlTb.PlaceholderText = "";
            this.PatAlTb.SelectedText = "";
            this.PatAlTb.ShadowDecoration.Parent = this.PatAlTb;
            this.PatAlTb.Size = new System.Drawing.Size(217, 36);
            this.PatAlTb.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(1011, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 19);
            this.label15.TabIndex = 16;
            this.label15.Text = "Allergies";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(622, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 19);
            this.label17.TabIndex = 20;
            this.label17.Text = "Gender";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(817, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 19);
            this.label18.TabIndex = 21;
            this.label18.Text = "HIV";
            // 
            // PatPhoneTb
            // 
            this.PatPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatPhoneTb.DefaultText = "";
            this.PatPhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatPhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatPhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatPhoneTb.DisabledState.Parent = this.PatPhoneTb;
            this.PatPhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatPhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatPhoneTb.FocusedState.Parent = this.PatPhoneTb;
            this.PatPhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatPhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatPhoneTb.HoverState.Parent = this.PatPhoneTb;
            this.PatPhoneTb.Location = new System.Drawing.Point(687, 263);
            this.PatPhoneTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatPhoneTb.Name = "PatPhoneTb";
            this.PatPhoneTb.PasswordChar = '\0';
            this.PatPhoneTb.PlaceholderText = "";
            this.PatPhoneTb.SelectedText = "";
            this.PatPhoneTb.ShadowDecoration.Parent = this.PatPhoneTb;
            this.PatPhoneTb.Size = new System.Drawing.Size(223, 36);
            this.PatPhoneTb.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(683, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phone";
            // 
            // AddBtn
            // 
            this.AddBtn.ActiveBorderThickness = 1;
            this.AddBtn.ActiveCornerRadius = 20;
            this.AddBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.AddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AddBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.ButtonText = "Add";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddBtn.IdleForecolor = System.Drawing.Color.White;
            this.AddBtn.IdleLineColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(574, 328);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(181, 44);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.ActiveBorderThickness = 1;
            this.DelBtn.ActiveCornerRadius = 20;
            this.DelBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.DelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DelBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.DelBtn.BackColor = System.Drawing.Color.White;
            this.DelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelBtn.BackgroundImage")));
            this.DelBtn.ButtonText = "Delete";
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DelBtn.IdleBorderThickness = 1;
            this.DelBtn.IdleCornerRadius = 20;
            this.DelBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.IdleForecolor = System.Drawing.Color.White;
            this.DelBtn.IdleLineColor = System.Drawing.Color.Black;
            this.DelBtn.Location = new System.Drawing.Point(1038, 328);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(181, 44);
            this.DelBtn.TabIndex = 26;
            this.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.EditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EditBtn.IdleForecolor = System.Drawing.Color.White;
            this.EditBtn.IdleLineColor = System.Drawing.Color.Black;
            this.EditBtn.Location = new System.Drawing.Point(807, 328);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(181, 44);
            this.EditBtn.TabIndex = 63;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1287, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Address";
            // 
            // PatDOB
            // 
            this.PatDOB.CheckedState.Parent = this.PatDOB;
            this.PatDOB.FillColor = System.Drawing.Color.Black;
            this.PatDOB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatDOB.ForeColor = System.Drawing.Color.White;
            this.PatDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PatDOB.HoverState.Parent = this.PatDOB;
            this.PatDOB.Location = new System.Drawing.Point(308, 263);
            this.PatDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PatDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PatDOB.Name = "PatDOB";
            this.PatDOB.ShadowDecoration.Parent = this.PatDOB;
            this.PatDOB.Size = new System.Drawing.Size(259, 36);
            this.PatDOB.TabIndex = 66;
            this.PatDOB.Value = new System.DateTime(2021, 9, 12, 14, 47, 54, 930);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(304, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Date of Birth";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(867, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Patient";
            // 
            // PatAddTb
            // 
            this.PatAddTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAddTb.Location = new System.Drawing.Point(1291, 186);
            this.PatAddTb.Multiline = true;
            this.PatAddTb.Name = "PatAddTb";
            this.PatAddTb.Size = new System.Drawing.Size(202, 113);
            this.PatAddTb.TabIndex = 71;
            // 
            // PatientsDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.PatientsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.PatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.PatientsDGV.ColumnHeadersHeight = 28;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.PatientsDGV.EnableHeadersVisualStyles = false;
            this.PatientsDGV.GridColor = System.Drawing.Color.WhiteSmoke;
            this.PatientsDGV.Location = new System.Drawing.Point(236, 392);
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.ReadOnly = true;
            this.PatientsDGV.RowHeadersVisible = false;
            this.PatientsDGV.RowTemplate.Height = 24;
            this.PatientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsDGV.Size = new System.Drawing.Size(1341, 392);
            this.PatientsDGV.TabIndex = 72;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientsDGV.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.PatientsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.PatientsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientsDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.PatientsDGV.ThemeStyle.ReadOnly = true;
            this.PatientsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.PatientsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PatientsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.PatientsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1580, 784);
            this.Controls.Add(this.PatientsDGV);
            this.Controls.Add(this.PatAddTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatDOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PatPhoneTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PatAlTb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PatHIVCb);
            this.Controls.Add(this.PatGenCb);
            this.Controls.Add(this.PatNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Patients";
            this.Text = "Patients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogoutLbl;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label RecepLbl;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label LabTestLbl;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label DoctorLbl;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label HomeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PatNameTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox PatGenCb;
        private Guna.UI2.WinForms.Guna2ComboBox PatHIVCb;
        private Guna.UI2.WinForms.Guna2TextBox PatAlTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox PatPhoneTb;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DelBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker PatDOB;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatAddTb;
        private Guna.UI2.WinForms.Guna2DataGridView PatientsDGV;
    }
}