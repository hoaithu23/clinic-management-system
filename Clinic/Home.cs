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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if(Login.Role == "Receptionist")
            {
                RecepLbl.Enabled = false;
                DoctorLbl.Enabled = false;
                LabLbl.Enabled = false;
            }
            CountPatients();
            CountDoctors();
            CountTest();
            CountHIV();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5NIFF8KI;Initial Catalog=ClinicDb;Integrated Security=True");
        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountHIV()
        {
            string Status = "Positive";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTbl where PatHIV='"+Status+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HIVLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DocNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTest()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from TestTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LabTestLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PatLbl_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void DoctorLbl_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void LabLbl_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void RecepLbl_Click(object sender, EventArgs e)
        {
            Receptionists Obj = new Receptionists();
            Obj.Show();
            this.Hide();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
