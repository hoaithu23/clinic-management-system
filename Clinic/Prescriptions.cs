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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
            DisplayPrescription();
            GetDocId();
            GetTestId();
            GetPatId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-5NIFF8KI;Initial Catalog=ClinicDb;Integrated Security=True");
        private void DisplayPrescription()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescriptionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocIdCb.SelectedIndex = 0;
            PatIdCb.SelectedIndex = 0;
            TestIdCb.SelectedIndex = 0;
            DocNameTb.Text = "";
            PatNameTb.Text = "";
            TestNameTb.Text = "";
            MedicinesTb.Text = "";
            CostTb.Text = "";
            //Key = 0;
        }
        private void GetDocName()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl where DocId=" + DocIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                DocNameTb.Text = dr["DocName"].ToString();
            }
            Con.Close();
        }
        private void GetPatName()
        {
            Con.Open();
            string Query = "Select * from PatientTbl where PatId=" + PatIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PatName"].ToString();
            }
            Con.Close();
        }
        private void GetTest()
        {
            Con.Open();
            string Query = "Select * from TestTbl where TestNum=" + TestIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TestNameTb.Text = dr["TestName"].ToString();
                CostTb.Text = dr["TestCost"].ToString();
            }
            Con.Close();
        }
        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocId from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId", typeof(int));
            dt.Load(rdr);
            DocIdCb.ValueMember = "DocId";
            DocIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            PatIdCb.ValueMember = "PatId";
            PatIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            TestIdCb.ValueMember = "TestNum";
            TestIdCb.DataSource = dt;
            Con.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void TestIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTest();
        }
        //int Key = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || DocNameTb.Text == "" || TestNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId,DocName,PatId,PatName,LabTestId,LabTestName,Medicines,Cost)values(@DI,@DN,@PI,@PN,@TI,@TN,@MED,@Co)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", PatIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@TI", TestIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", TestNameTb.Text);
                    cmd.Parameters.AddWithValue("@MED", MedicinesTb.Text);
                    cmd.Parameters.AddWithValue("@Co", CostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Added");
                    Con.Close();
                    DisplayPrescription();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrescSumTxt.Text = "";
            PrescSumTxt.Text = "                                            Minute Clinic\n\n"+ "                                          PRESCRIPTION                                                                      " + "\n***********************************************************************************************************" + "\n"+DateTime.Today.Date + "\n\n\n\n                Doctor: "+PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString()+"                               Patient: "+ PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString()+"                "+"             Medicines: "+PrescriptionDGV.SelectedRows[0].Cells[7].Value.ToString()+"\n\n\n\n                                                                             Minute";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(PrescSumTxt.Text + "\n", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\t\t\t\t\t" + "Thanks", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new Point(200, 300));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
