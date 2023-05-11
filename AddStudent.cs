using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtContact.Clear();
            txtDepartment.Clear();
            txtEnrollment.Clear();
            txtMail.Clear();
            txtStudent.Clear();
            txtAn.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAn.Text != "" && txtContact.Text != "" && txtEnrollment.Text != "" && txtMail.Text != "" && txtStudent.Text != "" && txtDepartment.Text != "")
            {
                String name = txtStudent.Text;
                String enrollment = txtEnrollment.Text;
                String mail = txtMail.Text;
                Int16 an = Int16.Parse(txtAn.Text);
                Int64 contact = Int64.Parse(txtContact.Text);
                String dep = txtDepartment.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-17HVRFU\\SQLEXPRESS; database = library; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into NewStudent (sname, senroll, sdep, san, scontact, semail) values ('" + name + "', '" + enrollment + "', '" + dep + "', " + an + "," + contact + ", '" + mail + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill the Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
