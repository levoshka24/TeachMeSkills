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

        }
    }
}
