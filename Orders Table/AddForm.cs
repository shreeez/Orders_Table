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
    public partial class AddForm : Form
    {

        DataBase dataBase = new DataBase();
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveAddNewNoteButton_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = nameAddtextBox.Text;
            var orderName = numberOrderAddtextBox.Text;
            var comment = commentAddtextBox.Text;
            int count;

            if (int.TryParse(countAddtextBox.Text, out count))
            {
                var addQuery = $"INSERT INTO TestOrders (name, order_id, comment, count_of) VALUES ('{name}', '{orderName}', '{comment}', '{count}')";
                var command = new SqlCommand(addQuery, dataBase.getSqlConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успех!");
            }
            else
            {
                MessageBox.Show("Запись не удалось создать!!!", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBase.closeConnection();
        }
    }
}
