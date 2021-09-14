using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPat();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5NIFF8KI;Initial Catalog=ClinicDb;Integrated Security=True");
        private void DisplayPat()
        {
            Con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void Clear()
        {
            PatNameTb.Text = "";
            PatGenCb.SelectedIndex = 0;
            PatHIVCb.SelectedIndex = 0;
            PatAddTb.Text = "";
            PatPhoneTb.Text = "";
            PatAlTb.Text = "";
            Key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || PatAlTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || PatGenCb.SelectedIndex == -1 || PatHIVCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName,PatGen,PatDOB,PatAdd,PatPhone,PatHIV,PatAll)values(@PN,@PG,@PD,@PA,@PP,@PH,@PAl)", Con);
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHIVCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAl", PatAlTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || PatAlTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || PatGenCb.SelectedIndex == -1 || PatHIVCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update PatientTbl set PatName=@PN,PatGen=@PG,PatDOB=@PD,PatAdd=@PA,PatPhone=@PP,PatHIV=@PH,PatAll=@PAl where PatId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHIVCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAl", PatAlTb.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Patient");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl where PatId = @PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTb.Text = PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatGenCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();     
            PatDOB.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAddTb.Text = PatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatPhoneTb.Text = PatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatHIVCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[6].Value.ToString();
            PatAlTb.Text = PatientsDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (PatNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatientsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeLbl_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void DoctorLbl_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void LabTestLbl_Click(object sender, EventArgs e)
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
    }
}
