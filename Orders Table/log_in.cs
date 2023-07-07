using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_Table
{
    public partial class log_in : Form
    {

        DataBase dataBase = new DataBase();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void log_in_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            pictureBox4.Visible = false;
        }

        private void AccButton_Click(object sender, EventArgs e)
        {
            var loginUser = loginTextBox.Text;
            var passwordUser = passwordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string sqlStr = "SELECT id_user, login_user, password_user From Register " +
                $"WHERE login_user = '{loginUser}' and password_user = '{passwordUser}'";

            using (SqlCommand command = new SqlCommand(sqlStr, dataBase.getSqlConnection()))
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm frm1 = new MainForm();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунта не существует!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                passwordTextBox.PasswordChar = default(char);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
