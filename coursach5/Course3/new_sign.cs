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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Course3
{
    public partial class new_sign : Form
    {
        DataBase database = new DataBase();
        public new_sign()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ComboboxLoad()
        {
            string queryString = $"select * from TypeOfProduct ";
            // считываем в отдельную переменную запрос в бд при помощи класса sqlcommand в конструктор передаем наш запрос и открываем связь с ней и при помощи класса дата ридер заносим в комбобох значения с определенных столбцоы

            // передаем запрос в бд
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            // открываем свзяь с нашей базай данных
            database.openConnection();
            // и делается это все при помощи дата ридера
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["TypeOfProduct"].ToString());

            }
            reader.Close();
            string queryString2 = $"select * from Postavka ";
            // передаем запрос в бд
            SqlCommand command2 = new SqlCommand(queryString2, database.getConnection());
            // открываем свзяь с нашей базай данных
            database.openConnection();
            // и делается это все при помощи дата ридера
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2["Postavka"].ToString());
            }
            reader2.Close();
            //обращаемся к свойствам чтоб нельзя было ничего вводить в combobox
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void SaveBd()
        {
            database.openConnection();
            //заносим значения с текстбоксов для занесения данных в таблицу
            var type = comboBox1.Text;
            var count = textBox_kolvo.Text;
            var postavka = comboBox2.Text;
            var price = textBox_price.Text;
            Regex reg = new Regex(@"^([\d.,-]+)$");
            // создаем регулярки для проверки введенных значений с текстбоксов


            if (!(reg.IsMatch(count) && reg.IsMatch(price)))
            {
                MessageBox.Show("Вы ввели неккоректные данные");
            }
            else
            {
                var addQuery = $"insert into main_db (type_of,count_of,postavka,price) values ('{type}','{count}','{postavka}','{price}')";
                //подключение к бд свзяваемся с ней и передаем ей запрос наш
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!");
                this.Hide();
            }
        }
        private void new_sign_Load(object sender, EventArgs e)
        {
            ComboboxLoad();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            
            textBox_kolvo.Text = "";
            
            textBox_price.Text = "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveBd();
            var frm_main = new Form1();
            frm_main.ShowDialog();

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_add_typeofproduct_Click(object sender, EventArgs e)
        {
            
           
            var frm = new New_Ptoduct2();
            frm.Show();
            this.Hide();
        }

        private void button_add_postavka_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new New_Postavka2();
            
            frm.Show();

        }
    }
}
