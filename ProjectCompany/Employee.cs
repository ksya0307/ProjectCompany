using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjectCompany
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int employee;
        public Employee(int employee_id)
        {
            employee = employee_id;
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            //select projects.ID, projects.name from projects inner join employees_projects on projects.ID=employees_projects.project where employees_projects.employee=7


            con.Open();

            adapter = new SqlDataAdapter("select projects.ID, projects.name from projects inner join employees_projects on projects.ID=employees_projects.project where employees_projects.employee=" + employee, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboProjects.DataSource = dt;
            comboProjects.DisplayMember = "name";
            comboProjects.ValueMember = "ID";
            adapter.Dispose();
            con.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();

 
        }

        private void comboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProjects.SelectedItem != null)
            {
                DataRowView drv = comboProjects.SelectedItem as DataRowView;

                int projectID = Convert.ToInt32(drv.Row["ID"]);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd = new SqlCommand("getTaskByProjectAndEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@employee", SqlDbType.Int);
                    cmd.Parameters["@employee"].Value = employee;

                    cmd.Parameters.Add("@project", SqlDbType.Int);
                    cmd.Parameters["@project"].Value = projectID;

                    cmd.ExecuteNonQuery();
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGrid.DataSource = dt;
                    dataGrid.AutoResizeColumns();
                    adapter.Dispose();
                    con.Close();
                }
            }
        }
    }
}
