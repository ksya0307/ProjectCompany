
namespace ProjectCompany
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Клиенты");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Сотрудники");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Отделы");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Проекты");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Должности");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Статусы");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Задачи");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Выполнение проектов");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Выполнение задач");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Таблицы", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminTree = new System.Windows.Forms.TreeView();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.completeProjects = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jobs = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.GroupBox();
            this.search_box = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.projectCompanyDataSet = new ProjectCompany.ProjectCompanyDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new ProjectCompany.ProjectCompanyDataSetTableAdapters.TableAdapterManager();
            this.departmentsTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.departmentsTableAdapter();
            this.employees_projectsTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.employees_projectsTableAdapter();
            this.employeesTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.employeesTableAdapter();
            this.jobsTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.jobsTableAdapter();
            this.projectsTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.projectsTableAdapter();
            this.statusesTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.statusesTableAdapter();
            this.tasksTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.tasksTableAdapter();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees_projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesProjectDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesProjectDateTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.EmployeesProjectDateTableAdapter();
            this.employeesJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesJobsTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.EmployeesJobsTableAdapter();
            this.employees_tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees_tasksTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.employees_tasksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees_projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesProjectDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees_tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTree
            // 
            this.adminTree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminTree.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminTree.Location = new System.Drawing.Point(13, 13);
            this.adminTree.Name = "adminTree";
            treeNode1.Name = "clients";
            treeNode1.Text = "Клиенты";
            treeNode2.Name = "employees";
            treeNode2.Text = "Сотрудники";
            treeNode3.Name = "departs";
            treeNode3.Text = "Отделы";
            treeNode4.Name = "projects";
            treeNode4.Text = "Проекты";
            treeNode5.Name = "jobs";
            treeNode5.Text = "Должности";
            treeNode6.Name = "statuses";
            treeNode6.Text = "Статусы";
            treeNode7.Name = "tasks";
            treeNode7.Text = "Задачи";
            treeNode8.Name = "emp_proj";
            treeNode8.Text = "Выполнение проектов";
            treeNode9.Name = "emp_tasks";
            treeNode9.Text = "Выполнение задач";
            treeNode10.Name = "tables";
            treeNode10.Text = "Таблицы";
            this.adminTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.adminTree.Size = new System.Drawing.Size(232, 194);
            this.adminTree.TabIndex = 0;
            this.adminTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.adminTree_AfterSelect);
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid.Location = new System.Drawing.Point(251, 13);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid.Size = new System.Drawing.Size(748, 615);
            this.dataGrid.TabIndex = 1;
//            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
          //  this.dataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGrid_CellPainting);
            this.dataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGrid_CellValidating);
//            this.dataGrid.MouseHover += new System.EventHandler(this.dataGrid_MouseHover);
            // 
            // completeProjects
            // 
            this.completeProjects.BackColor = System.Drawing.Color.Orange;
            this.completeProjects.FlatAppearance.BorderSize = 0;
            this.completeProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeProjects.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeProjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.completeProjects.Location = new System.Drawing.Point(6, 64);
            this.completeProjects.Name = "completeProjects";
            this.completeProjects.Size = new System.Drawing.Size(220, 30);
            this.completeProjects.TabIndex = 4;
            this.completeProjects.Text = "Получить список";
            this.completeProjects.UseVisualStyleBackColor = false;
            this.completeProjects.Click += new System.EventHandler(this.completeProjects_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.completeProjects);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выполнение пректов";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(7, 31);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(219, 24);
            this.date.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jobs);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Medium", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(13, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сотрудники";
            // 
            // jobs
            // 
            this.jobs.BackColor = System.Drawing.Color.Orange;
            this.jobs.FlatAppearance.BorderSize = 0;
            this.jobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobs.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jobs.Location = new System.Drawing.Point(6, 52);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(220, 30);
            this.jobs.TabIndex = 5;
            this.jobs.Text = "Получить список";
            this.jobs.UseVisualStyleBackColor = false;
            this.jobs.Click += new System.EventHandler(this.jobs_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(20, 353);
            this.name.MaxLength = 100;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(219, 24);
            this.name.TabIndex = 6;
            // 
            // search
            // 
            this.search.Controls.Add(this.search_box);
            this.search.Font = new System.Drawing.Font("Montserrat Medium", 8.25F);
            this.search.Location = new System.Drawing.Point(13, 426);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(232, 58);
            this.search.TabIndex = 7;
            this.search.TabStop = false;
            this.search.Text = "Поиск";
            this.search.Visible = false;
            this.search.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.search_box.Location = new System.Drawing.Point(7, 21);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(219, 24);
            this.search_box.TabIndex = 0;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(13, 598);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(232, 30);
            this.exit.TabIndex = 8;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Orange;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(13, 490);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(232, 30);
            this.save.TabIndex = 9;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Orange;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(13, 526);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(232, 30);
            this.add.TabIndex = 10;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Orange;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(13, 562);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 30);
            this.delete.TabIndex = 11;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // projectCompanyDataSet
            // 
            this.projectCompanyDataSet.DataSetName = "ProjectCompanyDataSet";
            this.projectCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.departmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.employees_projectsTableAdapter = this.employees_projectsTableAdapter;
            this.tableAdapterManager.employees_tasksTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.jobsTableAdapter = this.jobsTableAdapter;
            this.tableAdapterManager.projectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.statusesTableAdapter = this.statusesTableAdapter;
            this.tableAdapterManager.tasksTableAdapter = this.tasksTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectCompany.ProjectCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employees_projectsTableAdapter
            // 
            this.employees_projectsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // statusesTableAdapter
            // 
            this.statusesTableAdapter.ClearBeforeFill = true;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // employees_projectsBindingSource
            // 
            this.employees_projectsBindingSource.DataMember = "employees_projects";
            this.employees_projectsBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "jobs";
            this.jobsBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            this.projectsBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "statuses";
            this.statusesBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "tasks";
            this.tasksBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // employeesProjectDateBindingSource
            // 
            this.employeesProjectDateBindingSource.DataMember = "EmployeesProjectDate";
            this.employeesProjectDateBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // employeesProjectDateTableAdapter
            // 
            this.employeesProjectDateTableAdapter.ClearBeforeFill = true;
            // 
            // employeesJobsBindingSource
            // 
            this.employeesJobsBindingSource.DataMember = "EmployeesJobs";
            this.employeesJobsBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // employeesJobsTableAdapter
            // 
            this.employeesJobsTableAdapter.ClearBeforeFill = true;
            // 
            // employees_tasksBindingSource
            // 
            this.employees_tasksBindingSource.DataMember = "employees_tasks";
            this.employees_tasksBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // employees_tasksTableAdapter
            // 
            this.employees_tasksTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1019, 705);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.name);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.adminTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Административная панель";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees_projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesProjectDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees_tasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView adminTree;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ProjectCompanyDataSet projectCompanyDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ProjectCompanyDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private ProjectCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ProjectCompanyDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private ProjectCompanyDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private ProjectCompanyDataSetTableAdapters.employees_projectsTableAdapter employees_projectsTableAdapter;
        private System.Windows.Forms.BindingSource employees_projectsBindingSource;
        private ProjectCompanyDataSetTableAdapters.jobsTableAdapter jobsTableAdapter;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private ProjectCompanyDataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ProjectCompanyDataSetTableAdapters.statusesTableAdapter statusesTableAdapter;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private ProjectCompanyDataSetTableAdapters.tasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private System.Windows.Forms.Button completeProjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.BindingSource employeesProjectDateBindingSource;
        private ProjectCompanyDataSetTableAdapters.EmployeesProjectDateTableAdapter employeesProjectDateTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource employeesJobsBindingSource;
        private ProjectCompanyDataSetTableAdapters.EmployeesJobsTableAdapter employeesJobsTableAdapter;
        private System.Windows.Forms.Button jobs;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox search;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.BindingSource employees_tasksBindingSource;
        private ProjectCompanyDataSetTableAdapters.employees_tasksTableAdapter employees_tasksTableAdapter;
    }
}