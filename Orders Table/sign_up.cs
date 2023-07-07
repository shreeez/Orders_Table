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

namespace Orders_Table
{
    public partial class sign_up : Form
    {

        DataBase dataBase = new DataBase();
        public sign_up()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            passwordTextBox.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
            loginTextBox.Text = "";
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_in log_In = new log_in();
            log_In.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            passwordTextBox.PasswordChar = default(char);
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            pictureBox4.Visible = false;
        }

        private void createAccButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            if (!checkUser())
            {
                string sqlcom = $"INSERT INTO Register (login_user, password_user) VALUES ('{login}', '{password}')";

                SqlCommand command = new SqlCommand(sqlcom, dataBase.getSqlConnection());
                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!!", "Успех!");
                    log_in frm_log = new log_in();
                    this.Hide();
                    frm_log.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!", "Чета не получилося!");
                }
                dataBase.closeConnection();                
            }
        }

        private Boolean checkUser()
        {
            var loginUser = loginTextBox.Text;
            var password = passwordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string sqlStr = $"SELECT * FROM  Register WHERE login_user = '{loginUser}' AND password_user = '{password}'";

            SqlCommand command = new SqlCommand(sqlStr, dataBase.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Внимание!");
                return true;
            }
            return false;
        }
    }
}
