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

namespace Course3
{
    // enum нужен нам для состояние данных в таблице
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }
        // метод в котором мы создадм колонки для нашей таблицы
        private void CreateColumns()
        {
            // это для красивого отображения в гридвью т.е создаем колонки
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("type_of", "Тип товара");
            dataGridView1.Columns.Add("count_of", "Количество");
            dataGridView1.Columns.Add("postavka", "Поставщик");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        // метод в которой будем передавать параметры которые не разу не исп и они будут добавляться в нашу таблицу
        // idata record позволяет нам обращаться к знач столбцов чтоб обратиться к ним
        public void ReadSingleRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetInt32(2),record.GetString(3),record.GetInt32(4),RowState.ModifiedNew);
        }
        // метод который будет выводить данные в таблицу
        public  void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            // тут будем уже делать выборку в таблице и выводить данные
            string queryString = $"select * from main_db ";
            // передаем запрос в бд
            SqlCommand command = new SqlCommand(queryString,database.getConnection());
            // открываем свзяь с нашей базай данных
            database.openConnection();
            // и делается это все при помощи дата ридера
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // считывает данные с бд и выводит
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // т.к точка входа идет через лоад то вызываем наши методы для создания колонок в таблице и вывода данных в таблицу
            CreateColumns();
            RefreshDataGrid(dataGridView1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // занесение данных в гридвью в бд когда вводит их пользователь
            selectedRow=e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_type_of_product.Text = row.Cells[1].Value.ToString();
                textBox_kolvo.Text = row.Cells[2].Value.ToString();
                textBox_postavka.Text = row.Cells[3].Value.ToString();
                textBox_price.Text = row.Cells[4].Value.ToString();
               

            }
        }
        //реализация поиска
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            // стандартная выборка данных
            string searchString = $"select * from main_db where concat(id,type_of,count_of,postavka,price) like '%" + textBox_search.Text + "%'";
            // общаемся с бд
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void deleteRow()
        {
            //передаем индекс колонки для удаления
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;

        }
        private void Update()
        {
            database.openConnection();
            for(int index=0;index<dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if(rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from main_db where id = {id}";
                    var command = new SqlCommand(deleteQuery,database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var count = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var postavka = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var changeQuery = $"update main_db set type_of = '{type}', count_of = '{count}',postavka = '{postavka}',price = '{price}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery,database.getConnection());
                    command.ExecuteNonQuery();
                }
               
            }
            database.closeConnection();
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
           RefreshDataGrid(dataGridView1);
        }

        private void button_new_sign_Click(object sender, EventArgs e)
        {
            new_sign form = new new_sign();
            form.Show();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            //поиск данных
            Search(dataGridView1);
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            deleteRow();
        }
        //создаем метод изменить записис будем изменять значения с тексбоксов и зансоить их в ячейки
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox_id.Text;
            var type = textBox_type_of_product.Text;
            var count = textBox_kolvo.Text;
            var postavka = textBox_postavka.Text;
            var price = textBox_price.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                //само изенения значений пржде мы считали значения и уже добавляем в таблицу
                dataGridView1.Rows[selectedRowIndex].SetValues(id,type,count,postavka,price);
                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
        }
        private void button_change_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}
