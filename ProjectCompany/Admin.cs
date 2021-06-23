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
using System.Data.SqlTypes;
using System.Drawing.Drawing2D;

namespace ProjectCompany
{
    public partial class Admin : Form
    {
        string tableName;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        SqlCommand cmd;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.employees_tasks". При необходимости она может быть перемещена или удалена.
            this.employees_tasksTableAdapter.Fill(this.projectCompanyDataSet.employees_tasks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.tasks". При необходимости она может быть перемещена или удалена.
            this.tasksTableAdapter.Fill(this.projectCompanyDataSet.tasks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.projectCompanyDataSet.statuses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.projects". При необходимости она может быть перемещена или удалена.
            this.projectsTableAdapter.Fill(this.projectCompanyDataSet.projects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.jobs". При необходимости она может быть перемещена или удалена.
            this.jobsTableAdapter.Fill(this.projectCompanyDataSet.jobs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.employees_projects". При необходимости она может быть перемещена или удалена.
            this.employees_projectsTableAdapter.Fill(this.projectCompanyDataSet.employees_projects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.projectCompanyDataSet.employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.projectCompanyDataSet.departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectCompanyDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.projectCompanyDataSet.clients);

            this.dataGrid.CellValidating += new DataGridViewCellValidatingEventHandler(dataGrid_CellValidating);

            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "d/MM/yyyy";

        }

        private void adminTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            switch (adminTree.SelectedNode.Text)
            {
                case "Клиенты":
                    ///////////
                    tableName = "clients";
                    this.Text = "Административная панель ТАБЛИЦА - Клиенты"; 
                    this.clientsTableAdapter.Fill(this.projectCompanyDataSet.clients);
                    dataGrid.DataSource = clientsBindingSource;
                    dataGrid.Columns["ID"].HeaderText = "ID";
                    dataGrid.Columns["company"].HeaderText = "Компания";
                    dataGrid.Columns["address"].HeaderText = "Адрес";
                    dataGrid.Columns["contact with"].HeaderText = "Связаться с";
                    dataGrid.Columns["phone"].HeaderText = "Телефон";
                    dataGrid.AutoResizeColumns();
                    search.Visible = true;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                case "Сотрудники":
                    tableName = "employees";
                    this.Text = "Административная панель ТАБЛИЦА - Сотрудники";
                    this.employeesTableAdapter.Fill(this.projectCompanyDataSet.employees);
                    dataGrid.DataSource = employeesBindingSource;
                    dataGrid.Columns["ID"].HeaderText = "ID";
                    dataGrid.Columns["last_name"].HeaderText = "Фамилия";
                    dataGrid.Columns["name"].HeaderText = "Имя";
                    dataGrid.Columns["dad_name"].HeaderText = "Отчество";
                    dataGrid.Columns["phone"].HeaderText = "Телефон";
                    dataGrid.Columns["job"].HeaderText = "Должность";
                    dataGrid.Columns["login"].HeaderText = "Логин";
                    dataGrid.Columns["password"].HeaderText = "Пароль";
                    dataGrid.AutoResizeColumns();
                    search.Visible = false;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                case "Отделы":
                    tableName = "departments";
                    this.Text = "Административная панель ТАБЛИЦА - Отделы";
                    this.departmentsTableAdapter.Fill(this.projectCompanyDataSet.departments);
                    dataGrid.DataSource = departmentsBindingSource;
                    dataGrid.Columns["ID"].HeaderText = "ID";
                    dataGrid.Columns["name"].HeaderText = "Наименование";
                    dataGrid.Columns["room"].HeaderText = "Кабинет";
                    dataGrid.AutoResizeColumns();
                    search.Visible = false;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                    //////////////
                case "Проекты":
                    tableName = "projects";
                    this.Text = "Административная панель ТАБЛИЦА - Проекты";
                    this.projectsTableAdapter.Fill(this.projectCompanyDataSet.projects);
                    dataGrid.DataSource = projectsBindingSource;
                    dataGrid.Columns["ID"].HeaderText = "ID";
                    dataGrid.Columns["name"].HeaderText = "Название";
                    dataGrid.Columns["description"].HeaderText = "Описание";
                    dataGrid.Columns["start_date"].HeaderText = "Дата начала проекта";
                    dataGrid.Columns["end_date"].HeaderText = "Окончание проекта";
                    dataGrid.Columns["real_end_date"].HeaderText = "Реальная дата окончания";
                    dataGrid.Columns["client"].HeaderText = "Клиент";
                    dataGrid.Columns["status"].HeaderText = "Статус";
                    dataGrid.Columns["cost"].HeaderText = "Стоимость";
                    dataGrid.AutoResizeColumns();
                    search.Visible = true;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                case "Должности":
                    tableName = "jobs";
                    this.Text = "Административная панель ТАБЛИЦА - Должности";
                    this.jobsTableAdapter.Fill(this.projectCompanyDataSet.jobs);
                    dataGrid.DataSource = jobsBindingSource;
                    dataGrid.Columns["ID"].HeaderText = "ID";
                    dataGrid.Columns["name"].HeaderText = "Наименование";
                    dataGrid.Columns["department"].HeaderText = "Отдел";
                    dataGrid.Columns["salary"].HeaderText = "З/П";
                    dataGrid.AutoResizeColumns();
                    search.Visible = false;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                case "Статусы":
                    tableName = "statuses";
                    this.Text = "Административная панель ТАБЛИЦА - Статусы";
                    this.statusesTableAdapter.Fill(this.projectCompanyDataSet.statuses);
                    dataGrid.DataSource = statusesBindingSource;
                    dataGrid.Columns["ID"].HeaderText = "ID";
                    dataGrid.Columns["name"].HeaderText = "Наименование";
                    dataGrid.AutoResizeColumns();
                    search.Visible = false;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                    ////////////////
                case "Задачи":
                    tableName = "tasks";
                    this.Text = "Административная панель ТАБЛИЦА - Задачи";
                    this.tasksTableAdapter.Fill(this.projectCompanyDataSet.tasks);
                    dataGrid.DataSource = tasksBindingSource;
                    dataGrid.Columns["ID"].HeaderText = "ID";
                    dataGrid.Columns["name"].HeaderText = "Наименование";
                    dataGrid.Columns["start_date"].HeaderText = "Дата начала проекта";
                    dataGrid.Columns["end_date"].HeaderText = "Окончание проекта";
                    dataGrid.Columns["real_end_date"].HeaderText = "Реальная дата окончания";
                    dataGrid.Columns["project"].HeaderText = "Проект";
                    dataGrid.Columns["status"].HeaderText = "Статус";
                    dataGrid.AutoResizeColumns();
                    search.Visible = true;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                case "Выполнение проектов":
                    tableName = "employees_projects";
                    this.Text = "Административная панель ТАБЛИЦА - Выполнение проектов";
                    this.employees_projectsTableAdapter.Fill(this.projectCompanyDataSet.employees_projects);
                    dataGrid.DataSource = employees_projectsBindingSource;
                    dataGrid.Columns["employee"].HeaderText = "Сотрудник";
                    dataGrid.Columns["project"].HeaderText = "Проект";
                    dataGrid.AutoResizeColumns();
                    search.Visible = false;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;
                case "Выполнение задач":
                    tableName = "employees_tasks";
                    this.Text = "Административная панель ТАБЛИЦА - Выполнение задач";
                    this.employees_tasksTableAdapter.Fill(this.projectCompanyDataSet.employees_tasks);
                    dataGrid.DataSource = employees_tasksBindingSource;
                    dataGrid.Columns["task"].HeaderText = "Задача";
                    dataGrid.Columns["employee"].HeaderText = "Сотрудник";
                    dataGrid.AutoResizeColumns();
                    search.Visible = false;
                    save.Visible = true;
                    add.Visible = true;
                    delete.Visible = true;
                    break;

            }

        }
        private void completeProjects_Click(object sender, EventArgs e)
        {
            this.employeesProjectDateTableAdapter.Fill(this.projectCompanyDataSet.EmployeesProjectDate, date.Value.Date);
            dataGrid.DataSource = employeesProjectDateBindingSource;
            dataGrid.AutoResizeColumns();
        }

        private void jobs_Click(object sender, EventArgs e)
        {
            this.employeesJobsTableAdapter.Fill(this.projectCompanyDataSet.EmployeesJobs, name.Text);
            dataGrid.DataSource = employeesJobsBindingSource;
            dataGrid.AutoResizeColumns();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            switch (adminTree.SelectedNode.Text)
            {
                case "Клиенты": clientsBindingSource.Filter = "company  like '%" + search_box.Text + "%'";
                    break;
                case "Задачи":
                    tasksBindingSource.Filter = "name  like '%" + search_box.Text + "%'";
                    break;
                case "Проекты": projectsBindingSource.Filter = "name  like '%" + search_box.Text + "%'";
                    break;

            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            switch (tableName)
            {
                case "clients":
                    try
                    {
                        clientsBindingSource.EndEdit();
                        clientsTableAdapter.Update(this.projectCompanyDataSet.clients);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "departments":
                    try
                    {
                        departmentsBindingSource.EndEdit();
                        departmentsTableAdapter.Update(this.projectCompanyDataSet.departments);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "employees":
                    try
                    {
                        employeesBindingSource.EndEdit();
                        employeesTableAdapter.Update(this.projectCompanyDataSet.employees);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "employees_projects":
                    try
                    {
                        employees_projectsBindingSource.EndEdit();
                        employees_projectsTableAdapter.Update(this.projectCompanyDataSet.employees_projects);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "employees_tasks":
                    try
                    {
                        employees_tasksBindingSource.EndEdit();
                        employees_tasksTableAdapter.Update(this.projectCompanyDataSet.employees_tasks);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "jobs":
                    try
                    {
                        jobsBindingSource.EndEdit();
                        jobsTableAdapter.Update(this.projectCompanyDataSet.jobs);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "statuses":
                    try
                    {
                        statusesBindingSource.EndEdit();
                        statusesTableAdapter.Update(this.projectCompanyDataSet.statuses);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "tasks":
                    try
                    {
                        tasksBindingSource.EndEdit();
                        tasksTableAdapter.Update(this.projectCompanyDataSet.tasks);
                        MessageBox.Show("Данные сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            switch (tableName)
            {
                case "clients":
                    clientsTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = clientsBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "departments":
                    departmentsTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = departmentsBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "employees":
                    employeesTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = employeesBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "employees_projects":
                    employees_projectsTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = employees_projectsBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "employees_tasks":
                    employees_tasksTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = employees_tasksBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "jobs":
                    jobsTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = jobsBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "projects":
                    projectsTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = projectsBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "statuses":
                    statusesTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = statusesBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "tasks":
                    tasksTableAdapter.Update(projectCompanyDataSet);
                    dataGrid.DataSource = tasksBindingSource;
                    MessageBox.Show("Новые данные добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        private void deletedate(string table_name)
        {
            string id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            Convert.ToInt32(id);
            con.Open();
            cmd = new SqlCommand($"delete from {table_name} where ID={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                switch (tableName)
                {
                    case "clients":
                        deletedate("clients");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "departments":
                        deletedate("departments");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "employees":
                        deletedate("employees");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "employees_projects":
                        deletedate("employees_projects");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "employees_tasks":
                        deletedate("employees_tasks");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "jobs":
                        deletedate("jobs");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "projects":
                        deletedate("projects");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "statuses":
                        deletedate("statuses");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "tasks":
                        deletedate("tasks");
                        Admin_Load(sender, EventArgs.Empty);
                        MessageBox.Show("Удаление прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
        }

        private void dataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                DataGridViewCell cell = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                cell.ErrorText =
                    "Company Name must not be empty";

                if (cell.Tag == null)
                {
                    cell.Tag = cell.Style.Padding;
                    cell.Style.Padding = new Padding(0, 0, 18, 0);
                }
                e.Cancel = true;

            }
            else
            {
                dataGrid.Rows[e.RowIndex].ErrorText = string.Empty;
            }
        }
    }
}
