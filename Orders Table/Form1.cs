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

        private void ChangeNoteButton_Click(object sender, EventArgs e)
        {

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
        }
    }
}
