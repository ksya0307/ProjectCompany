
namespace ProjectCompany
{
    partial class EditTask
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.statusComboEdit = new System.Windows.Forms.ComboBox();
            this.nameEdit = new System.Windows.Forms.TextBox();
            this.start_dateEdit = new System.Windows.Forms.DateTimePicker();
            this.end_dateEdit = new System.Windows.Forms.DateTimePicker();
            this.real_end_dateEdit = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Статус:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Реальная дата окончания выполнения задачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Дата окончания выполнения задачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дата начала выполнения задачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LimeGreen;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(12, 336);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(314, 31);
            this.save.TabIndex = 21;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // statusComboEdit
            // 
            this.statusComboEdit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusComboEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusComboEdit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboEdit.FormattingEnabled = true;
            this.statusComboEdit.Location = new System.Drawing.Point(12, 304);
            this.statusComboEdit.Name = "statusComboEdit";
            this.statusComboEdit.Size = new System.Drawing.Size(314, 26);
            this.statusComboEdit.TabIndex = 29;
//            this.statusComboEdit.SelectionChangeCommitted += new System.EventHandler(this.statusComboEdit_SelectionChangeCommitted);
            this.statusComboEdit.SelectedValueChanged += new System.EventHandler(this.statusComboEdit_SelectedValueChanged);
            // 
            // nameEdit
            // 
            this.nameEdit.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.nameEdit.Location = new System.Drawing.Point(12, 35);
            this.nameEdit.Name = "nameEdit";
            this.nameEdit.Size = new System.Drawing.Size(314, 24);
            this.nameEdit.TabIndex = 30;
            // 
            // start_dateEdit
            // 
            this.start_dateEdit.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.start_dateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_dateEdit.Location = new System.Drawing.Point(12, 96);
            this.start_dateEdit.Name = "start_dateEdit";
            this.start_dateEdit.Size = new System.Drawing.Size(315, 24);
            this.start_dateEdit.TabIndex = 31;
            // 
            // end_dateEdit
            // 
            this.end_dateEdit.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.end_dateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_dateEdit.Location = new System.Drawing.Point(12, 157);
            this.end_dateEdit.Name = "end_dateEdit";
            this.end_dateEdit.Size = new System.Drawing.Size(315, 24);
            this.end_dateEdit.TabIndex = 32;
            // 
            // real_end_dateEdit
            // 
            this.real_end_dateEdit.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.real_end_dateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.real_end_dateEdit.Location = new System.Drawing.Point(12, 218);
            this.real_end_dateEdit.Name = "real_end_dateEdit";
            this.real_end_dateEdit.Size = new System.Drawing.Size(315, 24);
            this.real_end_dateEdit.TabIndex = 33;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.statusLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusLbl.Location = new System.Drawing.Point(82, 254);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(63, 20);
            this.statusLbl.TabIndex = 34;
            this.statusLbl.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Изменить:";
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(342, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.real_end_dateEdit);
            this.Controls.Add(this.end_dateEdit);
            this.Controls.Add(this.start_dateEdit);
            this.Controls.Add(this.nameEdit);
            this.Controls.Add(this.statusComboEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox statusComboEdit;
        private System.Windows.Forms.TextBox nameEdit;
        private System.Windows.Forms.DateTimePicker start_dateEdit;
        private System.Windows.Forms.DateTimePicker end_dateEdit;
        private System.Windows.Forms.DateTimePicker real_end_dateEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label2;
    }
}