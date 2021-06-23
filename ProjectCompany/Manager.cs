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
    public partial class Manager : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        bool clicked = false;
        int projectID;
        string name = "", start_date = "", end_date = "", real_end_date = "", status = "", id = "";

        private void edit_Click(object sender, EventArgs e)
        {
            EditTask edit = new EditTask(id, name,start_date,end_date,real_end_date,projectID,status);
            edit.ShowDialog();
        }

        public Manager()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                deleteRow("tasks");
                MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.getTasksByProjectTableAdapter.Fill(this.projectCompanyDataSet.getTasksByProject, projectID);
                dataGrid.DataSource = getTasksByProjectBindingSource;
            }
                
        }


        private void deleteRow(string table_name)
        {
            string id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            Convert.ToInt32(id);
            con.Open();
            cmd = new SqlCommand($"delete from {table_name} where ID={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            AddProject project = new AddProject();
            project.ShowDialog();
            Manager_Load(sender, EventArgs.Empty);
        }

        private void upd_Click(object sender, EventArgs e)
        {
            this.getTasksByProjectTableAdapter.Fill(this.projectCompanyDataSet.getTasksByProject, projectID);
            dataGrid.DataSource = getTasksByProjectBindingSource;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.projectsView". При необходимости она может быть перемещена или удалена.
            this.projectsViewTableAdapter.Fill(this.projectCompanyDataSet.projectsView);

            con.Open();

            adapter = new SqlDataAdapter("select ID, name from projects", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboProjects.DataSource = dt;
            comboProjects.DisplayMember = "name";
            comboProjects.ValueMember = "ID";

            adapter.Dispose();
            con.Close();
            edit.Visible = false;
            upd.Visible = false;
            delete.Visible = false;

        }

        private void projects_Click(object sender, EventArgs e)
        {
            this.projectsViewTableAdapter.Fill(this.projectCompanyDataSet.projectsView);//показать представление - проекты и сотрудники которые им заняты
            dataGrid.DataSource = projectsViewBindingSource;
            dataGrid.AutoResizeColumns();
            clicked = false;
            edit.Visible = false;
            upd.Visible = false;
            delete.Visible = false;
        }

        private void comboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProjects.SelectedItem != null )
            {
                clicked = true;
                edit.Visible = true;
                upd.Visible = true;
                delete.Visible = true;
                // DataRowView drv = comboProjects.SelectedItem as DataRowView;
                // string projectName = drv.Row["ID"].ToString();
                DataRowView drv = comboProjects.SelectedItem as DataRowView;

                projectID = Convert.ToInt32(drv.Row["ID"]);
         
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    cmd = new SqlCommand("getTasksByProject", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@projectID", SqlDbType.Int);
                    cmd.Parameters["@projectID"].Value = projectID;


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

        private void addTask_Click(object sender, EventArgs e)
        {
            AddTask add = new AddTask();
            add.ShowDialog();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.DataSource == getTasksByProjectBindingSource)
            {
                if (dataGrid.SelectedCells.Count > 0)
                {
                    int selectedRowId = dataGrid.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGrid.Rows[selectedRowId];
                    name = Convert.ToString(selectedRow.Cells["Название"].Value).Trim(' ');
                    start_date = Convert.ToString(selectedRow.Cells["Дата начала выполнения задачи"].Value);
                    end_date = Convert.ToString(selectedRow.Cells["Дата окончания выполнения задачи"].Value);
                    real_end_date = Convert.ToString(selectedRow.Cells["Реальная дата окончания выполнения задачи"].Value);
                    status = Convert.ToString(selectedRow.Cells["Статус"].Value).Trim(' ');
                    id = Convert.ToString(selectedRow.Cells["ID"].Value).Trim(' ');

                    Console.WriteLine(start_date + " " + end_date + " " + real_end_date + " "+name);
                }
            }
        }
    }
}
