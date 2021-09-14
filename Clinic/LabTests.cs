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
    public partial class LabTests : Form
    {
        public LabTests()
        {
            InitializeComponent();
            DisplayTest();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5NIFF8KI;Initial Catalog=ClinicDb;Integrated Security=True");
        private void DisplayTest()
        {
            Con.Open();
            string Query = "Select * from TestTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LabTestsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void Clear()
        {
            LabTestTb.Text = "";
            LabCostTb.Text = "";
            Key = 0;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (LabTestTb.Text == "" || LabCostTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TestTbl(TestName,TestCost)values(@TN,@TC)", Con);
                    cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                    cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lab Test Added");
                    Con.Close();
                    DisplayTest();
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
            if (LabTestTb.Text == "" || LabCostTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TestTbl set TestName=@TN,TestCost=@TC where TestNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                    cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lab Test Added");
                    Con.Close();
                    DisplayTest();
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
                MessageBox.Show("Select The Lab Test");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from TestTbl where TestNum = @TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lab Test Deleted");
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LabTestsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabTestTb.Text = LabTestsDGV.SelectedRows[0].Cells[1].Value.ToString();
            LabCostTb.Text = LabTestsDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (LabTestTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LabTestsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
