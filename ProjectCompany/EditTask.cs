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

namespace ProjectCompany
{
    public partial class EditTask : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int projectID;
        string name = "", start_date = "", end_date = "", real_end_date = "", status = "", id = "";
        public EditTask(string idTask, string nameTask, string start_dateTask, string end_dateTask, string real_end_dateTask, int projectTask, string statusTask)
        {
            projectID = projectTask;
            id = idTask;
            name = nameTask;
            start_date = start_dateTask;
            end_date = end_dateTask;
            real_end_date = real_end_dateTask;
            projectID = projectTask;
            status = statusTask;


            InitializeComponent();
            nameEdit.Validating += name_Validating;
        }


        private void statusComboEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            statusComboEdit.DisplayMember = status;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameEdit.Text))
            {
                errorProvider1.SetError(nameEdit, "Заполните обязательное поле Название");
            }
            else
            {
                DataRowView drvStatuse = statusComboEdit.SelectedItem as DataRowView;
                int statusID = Convert.ToInt32(drvStatuse.Row["ID"]);

                con.Open();
                cmd = new SqlCommand("updateTask", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                cmd.Parameters["@name"].Value = nameEdit.Text;

                cmd.Parameters.Add("@start_date", SqlDbType.Date);
                cmd.Parameters["@start_date"].Value = start_dateEdit.Value.Date;

                cmd.Parameters.Add("@end_date", SqlDbType.Date);
                cmd.Parameters["@end_date"].Value = end_dateEdit.Value.Date;

                cmd.Parameters.Add("@real_end_date", SqlDbType.Date);
                cmd.Parameters["@real_end_date"].Value = real_end_dateEdit.Value.Date;

                cmd.Parameters.Add("@project", SqlDbType.Int);
                cmd.Parameters["@project"].Value = projectID;

                cmd.Parameters.Add("@status", SqlDbType.Int);
                cmd.Parameters["@status"].Value = statusID;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = Convert.ToInt32(id);


                if(cmd.ExecuteNonQuery() == 1)
                {
                    
                    MessageBox.Show("Задача сохранена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                con.Close();
                this.Close();
            }
        }

        
   
        private void name_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(nameEdit.Text))
            {
                errorProvider1.SetError(nameEdit, "Заполните обязательное поле Название");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            start_dateEdit.Format = DateTimePickerFormat.Custom;
            start_dateEdit.CustomFormat = "d/MM/yyyy";

            end_dateEdit.Format = DateTimePickerFormat.Custom;
            end_dateEdit.CustomFormat = "d/MM/yyyy";

            real_end_dateEdit.Format = DateTimePickerFormat.Custom;
            real_end_dateEdit.CustomFormat = "d/MM/yyyy";

            nameEdit.Text = name;
            start_dateEdit.Text = start_date;
            end_dateEdit.Text = end_date;
            real_end_dateEdit.Text = real_end_date;
            statusLbl.Text = status;

            con.Open();
            adapter = new SqlDataAdapter("select ID, name from statuses", con);
            DataTable statuses = new DataTable();
            adapter.Fill(statuses);
            statusComboEdit.DataSource = statuses;
            statusComboEdit.DisplayMember = "name";
            statusComboEdit.ValueMember = "ID";
            adapter.Dispose();
            con.Close();

        }
    }
}
