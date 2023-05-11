using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollment.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-17HVRFU\\SQLEXPRESS; Initial Catalog = library; INtegrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where senroll LIKE  '" + txtSearchEnrollment.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-17HVRFU\\SQLEXPRESS; Initial Catalog = library; Integrated Security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-17HVRFU\\SQLEXPRESS; Initial Catalog = library; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        Int64 bid;
        Int64 rowID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-17HVRFU\\SQLEXPRESS; Initial Catalog = library; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where stuid = " + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);
            bid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtSenrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            txtSDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSCyear.Text = ds.Tables[0].Rows[0][4].ToString();
            txtScontact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtSEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            String name = txtSName.Text;
            String enrollment = txtSenrollment.Text;
            String dep = txtSDepartment.Text;
            String mail = txtSEmail.Text;
            Int64 contact = Int64.Parse(txtScontact.Text);
            Int16 an = Int16.Parse(txtSCyear.Text);
            if (MessageBox.Show("Data will be Updated. Confirm?", "Succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-17HVRFU\\SQLEXPRESS; database = library ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewStudent set sname= '" + name + "',senroll ='" + enrollment + "',sdep='" + dep + "',semail='" + mail + "',san=" + an + " ,scontact=" + contact + " where stuid =" + bid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                ViewStudent_Load(this, null);

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudent_Load(this, null);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirm?", "Succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-17HVRFU\\SQLEXPRESS; database = library ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewStudent where stuid =" + bid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                ViewStudent_Load(this, null);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be lost", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
