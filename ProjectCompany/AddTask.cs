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
    public partial class AddTask : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public AddTask()
        {
            InitializeComponent();
            name.Validating += name_Validating;
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text))
            {
                errorProvider1.SetError(name, "Заполните обязательное поле Название");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
          if(projectCombo.SelectedItem !=null && statusCombo.SelectedItem != null)
            {
                if (String.IsNullOrEmpty(name.Text))
                {
                    errorProvider1.SetError(name, "Заполните обязательное поле Название");
                }
                else
                {
                    DataRowView drvProjects = projectCombo.SelectedItem as DataRowView;
                    int projectID = Convert.ToInt32(drvProjects.Row["ID"]);

                    DataRowView drvStatuses = statusCombo.SelectedItem as DataRowView;
                    int statusID = Convert.ToInt32(drvStatuses.Row["ID"]);

                    Console.WriteLine(projectID);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        cmd = new SqlCommand("insertTask", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                        cmd.Parameters["@name"].Value = name.Text;

                        cmd.Parameters.Add("@start_date", SqlDbType.Date);
                        cmd.Parameters["@start_date"].Value = start_date.Value.Date;

                        cmd.Parameters.Add("@end_date", SqlDbType.Date);
                        cmd.Parameters["@end_date"].Value = end_date.Value.Date;

                        cmd.Parameters.Add("@real_end_date", SqlDbType.Date);
                        cmd.Parameters["@real_end_date"].Value = real_end_date.Value.Date;

                        cmd.Parameters.Add("@project", SqlDbType.Int);
                        cmd.Parameters["@project"].Value = projectID;

                        cmd.Parameters.Add("@status", SqlDbType.Int);
                        cmd.Parameters["@status"].Value = statusID;


                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Задача добавлена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибочка!");
                        }
                        con.Close();
                    }
                }
                
          }
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            start_date.Format = DateTimePickerFormat.Custom;
            start_date.CustomFormat = "d/MM/yyyy";

            end_date.Format = DateTimePickerFormat.Custom;
            end_date.CustomFormat = "d/MM/yyyy";

            real_end_date.Format = DateTimePickerFormat.Custom;
            real_end_date.CustomFormat = "d/MM/yyyy";

            con.Open();
            adapter = new SqlDataAdapter("select ID, name from projects", con);
            DataTable projects = new DataTable();
            adapter.Fill(projects);
            projectCombo.DataSource = projects;
            projectCombo.DisplayMember = "name";
            projectCombo.ValueMember = "ID";
            adapter.Dispose();
            con.Close();
            


            con.Open();
            adapter = new SqlDataAdapter("select ID, name from statuses", con);
            DataTable statuses = new DataTable();
            adapter.Fill(statuses);
            statusCombo.DataSource = statuses;
            statusCombo.DisplayMember = "name";
            statusCombo.ValueMember = "ID";
            adapter.Dispose();
            con.Close();


        }

    }
}
