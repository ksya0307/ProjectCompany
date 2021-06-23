
namespace ProjectCompany
{
    partial class Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.projects = new System.Windows.Forms.Button();
            this.comboProjects = new System.Windows.Forms.ComboBox();
            this.addTask = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.addProject = new System.Windows.Forms.Button();
            this.projectCompanyDataSet = new ProjectCompany.ProjectCompanyDataSet();
            this.projectsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsViewTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.projectsViewTableAdapter();
            this.tableAdapterManager = new ProjectCompany.ProjectCompanyDataSetTableAdapters.TableAdapterManager();
            this.getTasksByProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTasksByProjectTableAdapter = new ProjectCompany.ProjectCompanyDataSetTableAdapters.getTasksByProjectTableAdapter();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTasksByProjectBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGrid.Location = new System.Drawing.Point(237, 48);
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
            this.dataGrid.Size = new System.Drawing.Size(758, 506);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // projects
            // 
            this.projects.BackColor = System.Drawing.Color.Orange;
            this.projects.FlatAppearance.BorderSize = 0;
            this.projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projects.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projects.Location = new System.Drawing.Point(13, 12);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(218, 30);
            this.projects.TabIndex = 3;
            this.projects.Text = "Проекты";
            this.projects.UseVisualStyleBackColor = false;
            this.projects.Click += new System.EventHandler(this.projects_Click);
            // 
            // comboProjects
            // 
            this.comboProjects.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboProjects.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboProjects.FormattingEnabled = true;
            this.comboProjects.Location = new System.Drawing.Point(237, 12);
            this.comboProjects.Name = "comboProjects";
            this.comboProjects.Size = new System.Drawing.Size(758, 30);
            this.comboProjects.TabIndex = 4;
            this.comboProjects.SelectedIndexChanged += new System.EventHandler(this.comboProjects_SelectedIndexChanged);
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.Orange;
            this.addTask.FlatAppearance.BorderSize = 0;
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTask.Location = new System.Drawing.Point(12, 48);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(218, 30);
            this.addTask.TabIndex = 5;
            this.addTask.Text = "Добавить задачу";
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // upd
            // 
            this.upd.BackColor = System.Drawing.Color.Orange;
            this.upd.FlatAppearance.BorderSize = 0;
            this.upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.upd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upd.Location = new System.Drawing.Point(13, 184);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(218, 30);
            this.upd.TabIndex = 7;
            this.upd.Text = "Обновить";
            this.upd.UseVisualStyleBackColor = false;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Orange;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(13, 220);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(219, 30);
            this.delete.TabIndex = 8;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(12, 524);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(219, 30);
            this.exit.TabIndex = 9;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addProject
            // 
            this.addProject.BackColor = System.Drawing.Color.Orange;
            this.addProject.FlatAppearance.BorderSize = 0;
            this.addProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProject.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProject.Location = new System.Drawing.Point(13, 84);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(218, 30);
            this.addProject.TabIndex = 10;
            this.addProject.Text = "Добавить проект";
            this.addProject.UseVisualStyleBackColor = false;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // projectCompanyDataSet
            // 
            this.projectCompanyDataSet.DataSetName = "ProjectCompanyDataSet";
            this.projectCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsViewBindingSource
            // 
            this.projectsViewBindingSource.DataMember = "projectsView";
            this.projectsViewBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // projectsViewTableAdapter
            // 
            this.projectsViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.departmentsTableAdapter = null;
            this.tableAdapterManager.employees_projectsTableAdapter = null;
            this.tableAdapterManager.employees_tasksTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.projectsTableAdapter = null;
            this.tableAdapterManager.statusesTableAdapter = null;
            this.tableAdapterManager.tasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectCompany.ProjectCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // getTasksByProjectBindingSource
            // 
            this.getTasksByProjectBindingSource.DataMember = "getTasksByProject";
            this.getTasksByProjectBindingSource.DataSource = this.projectCompanyDataSet;
            // 
            // getTasksByProjectTableAdapter
            // 
            this.getTasksByProjectTableAdapter.ClearBeforeFill = true;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Orange;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(13, 120);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(218, 58);
            this.edit.TabIndex = 6;
            this.edit.Text = "Редактировать задачу";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Visible = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1015, 581);
            this.Controls.Add(this.addProject);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.comboProjects);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проектная организация";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTasksByProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button projects;
        private System.Windows.Forms.ComboBox comboProjects;
        private ProjectCompanyDataSet projectCompanyDataSet;
        private System.Windows.Forms.BindingSource projectsViewBindingSource;
        private ProjectCompanyDataSetTableAdapters.projectsViewTableAdapter projectsViewTableAdapter;
        private ProjectCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.BindingSource getTasksByProjectBindingSource;
        private ProjectCompanyDataSetTableAdapters.getTasksByProjectTableAdapter getTasksByProjectTableAdapter;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.Button edit;
    }
}