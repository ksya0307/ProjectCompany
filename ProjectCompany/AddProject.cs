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
    public partial class AddProject : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public AddProject()
        {
            InitializeComponent();
        }

        private void cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar));
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

            name.TabIndex = 0;
            decrBox.TabIndex = 1;
            cost.TabIndex = 7;
            add.TabIndex = 8;

            start_date.Format = DateTimePickerFormat.Custom;
            start_date.CustomFormat = "d/MM/yyyy";

            end_date.Format = DateTimePickerFormat.Custom;
            end_date.CustomFormat = "d/MM/yyyy";

            real_end_date.Format = DateTimePickerFormat.Custom;
            real_end_date.CustomFormat = "d/MM/yyyy";


            con.Open();
            adapter = new SqlDataAdapter("select ID, company from clients", con);
            DataTable clients = new DataTable();
            adapter.Fill(clients);
            clientCombo.DataSource = clients;
            clientCombo.DisplayMember = "company";
            clientCombo.ValueMember = "ID";
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

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(decrBox.Text) || String.IsNullOrEmpty(cost.Text))
            {
                errorProvider1.SetError(name, "Заполните обязательное поле");
            }
            else
            {
                DataRowView drvStatuses = statusCombo.SelectedItem as DataRowView;
                int statusID = Convert.ToInt32(drvStatuses.Row["ID"]);

                DataRowView drvClients = clientCombo.SelectedItem as DataRowView;
                int clientID = Convert.ToInt32(drvClients.Row["ID"]);

                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd = new SqlCommand("insertProject", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                    cmd.Parameters["@name"].Value = name.Text;

                    cmd.Parameters.Add("@description", SqlDbType.NVarChar);
                    cmd.Parameters["@description"].Value = decrBox.Text;

                    cmd.Parameters.Add("@start_date", SqlDbType.Date);
                    cmd.Parameters["@start_date"].Value = start_date.Value.Date;

                    cmd.Parameters.Add("@end_date", SqlDbType.Date);
                    cmd.Parameters["@end_date"].Value = end_date.Value.Date;

                    cmd.Parameters.Add("@real_end_date", SqlDbType.Date);
                    cmd.Parameters["@real_end_date"].Value = real_end_date.Value.Date;

                    cmd.Parameters.Add("@client", SqlDbType.Int);
                    cmd.Parameters["@client"].Value = clientID;

                    cmd.Parameters.Add("@status", SqlDbType.Int);
                    cmd.Parameters["@status"].Value = statusID;

                    cmd.Parameters.Add("@cost", SqlDbType.Int);
                    cmd.Parameters["@cost"].Value = cost.Text;


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Проект добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
