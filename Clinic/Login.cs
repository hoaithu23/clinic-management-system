using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RoleCb.SelectedIndex = 0;
            UnameTb.Text = "";
            PassTb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5NIFF8KI;Initial Catalog=ClinicDb;Integrated Security=True");
        public static string Role;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select Your Position");
            }else if(RoleCb.SelectedIndex == 0)
            {
                if(UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }else if(UnameTb.Text == "Admin" && PassTb.Text == "Password")
                {
                    Role = "Admin";
                    Patients Obj = new Patients();
                    Obj.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Wrong Admin Name and Password");
                }
            }else if(RoleCb.SelectedIndex == 1)
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Doctor Name and Password");
                }
                else 
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl where DocName='" + UnameTb.Text + "' and DocPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doctor";
                        Prescriptions Obj = new Prescriptions();
                        Obj.Show();
                        this.Hide();
                    }else
                    {
                        MessageBox.Show("Doctor Not Found");
                    }
                    Con.Close();
                }
            }
            else
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Receptionist Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ReceptionistTbl where RecepName='" + UnameTb.Text + "' and RecepPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Receptionist";
                        Home Obj = new Home();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionist Not Found");
                    }
                    Con.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideBtn_Click_1(object sender, EventArgs e)
        {
            if (PassTb.PasswordChar == '*')
            {
                ShowBtn.BringToFront();
                PassTb.PasswordChar = '\0';
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (PassTb.PasswordChar == '\0')
            {
                HideBtn.BringToFront();
                PassTb.PasswordChar = '*';
            }
        }
    }
}
