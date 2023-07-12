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
    public partial class MainForm : Form
    {

        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        
        DataBase dataBase = new DataBase();

        int selectedRow;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColomns();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColomns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("order_id", "Заказ");
            dataGridView1.Columns.Add("comment", "Комментарий");
            dataGridView1.Columns.Add("count_of", "Колличество");
            dataGridView1.Columns.Add("isNew", string.Empty);
        }

        private void ClearFields()
        {
            nameTextBox.Text = "";
            IdTextBox.Text = "";
            commentTextBox.Text = "";
            countTextBox.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(0), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = "SELECT * FROM TestOrders";

            SqlCommand command = new SqlCommand(queryString, dataBase.getSqlConnection());

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();

        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            var name = nameTextBox.Text;
            var order_id = IdTextBox.Text;
            var comment = commentTextBox.Text;
            int count;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(countTextBox.Text, out count))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, order_id, comment, count);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь цифровой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangeNoteButton_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                nameTextBox.Text = row.Cells[1].Value.ToString();
                IdTextBox.Text = row.Cells[2].Value.ToString();
                commentTextBox.Text = row.Cells[3].Value.ToString();
                countTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchString = $"SELECT * FROM TestOrders WHERE CONCAT (id, name, order_id, comment, count_of) LIKE '%{searchTextBox.Text}%'";
            SqlCommand command = new SqlCommand(searchString, dataBase.getSqlConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
        }
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void deliteButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void Update1()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed) continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM TestOrders WHERE id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getSqlConnection());

                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var orderId = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var comment = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var count = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQury = $"UPDATE TestOrders SET name = '{name}', order_id = '{orderId}', comment = '{comment}', count_of = {count} WHERE id = '{id}'";

                    var command = new SqlCommand(changeQury, dataBase.getSqlConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Update1();
        }

        private void cltarButton1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
