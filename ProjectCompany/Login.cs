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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            theLogin.TabIndex = 0;
            thePassword.TabIndex = 1;
            SignIn.TabIndex = 2;

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SHA256pwd sha = new SHA256pwd();
            if (theLogin.Text == "" || thePassword.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("select ID, login, password, job from dbo.employees " +
                    "where login='" + theLogin.Text + "' and password='" + sha.SHA256HexHashString(thePassword.Text) + "';", con);
                SqlDataReader reader = cmd.ExecuteReader();
                string login = "";
                int job=0, employee_id=0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        theLogin.Focus();
                        employee_id = reader.GetInt32(0);
                        login = reader.GetString(1).Trim(' ');
                        job = reader.GetInt32(3);
                    }
                    reader.Close();
                    cmd.Dispose();
                    switch (job)
                    {
                        case 1017:
                            this.Hide();
                            Admin admin = new Admin();
                            admin.Show();
                            break;
                        case 1016:
                            this.Hide();
                            Manager manager = new Manager();
                            manager.Show();
                            break;
                        default: this.Hide();
                            Employee employee = new Employee(employee_id);
                            employee.Show();
                            break;

                    }
                    

                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль,\n" +
                        "пожалуйста,повторите попытку ",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();

            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
