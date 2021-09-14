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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            DisplayDoc();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5NIFF8KI;Initial Catalog=ClinicDb;Integrated Security=True");
        private void DisplayDoc()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DNameTb.Text = "";
            DocPhoneTb.Text = "";
            DocAddTb.Text = "";
            DocExpTb.Text = "";
            DocPasswordTb.Text = "";
            DocGenCb.SelectedIndex = 0;
            DocSpecCb.SelectedIndex = 0;
            Key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocPasswordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocSpecCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName,DocDOB,DOCGEN,DOCSPEC,DOCEXP,DOCPHONE,DocAdd,DocPass)values(@DN,@DD,@DG,@DS,@DE,@DP,@DA,@DPA)", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Added");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void DoctorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DoctorsDGV.SelectedRows[0].Cells[1].Value.ToString();
            DocDOB.Text = DoctorsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DocGenCb.SelectedItem = DoctorsDGV.SelectedRows[0].Cells[3].Value.ToString();
            DocSpecCb.SelectedItem = DoctorsDGV.SelectedRows[0].Cells[4].Value.ToString();
            DocExpTb.Text = DoctorsDGV.SelectedRows[0].Cells[5].Value.ToString();
            DocPhoneTb.Text = DoctorsDGV.SelectedRows[0].Cells[6].Value.ToString();
            DocAddTb.Text = DoctorsDGV.SelectedRows[0].Cells[7].Value.ToString();
            DocPasswordTb.Text = DoctorsDGV.SelectedRows[0].Cells[8].Value.ToString();
            if (DNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DoctorsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocPasswordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocSpecCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DoctorTbl set DocName=@DN,DocDOB=@DD,DOCGEN=@DG,DOCSPEC=@DS,DOCEXP=@DE,DOCPHONE=@DP,DocAdd=@DA,DocPass=@DPA where DocId=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated");
                    Con.Close();
                    DisplayDoc();
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
                MessageBox.Show("Select The Doctor");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DoctorTbl where DocId = @DKey", Con);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
