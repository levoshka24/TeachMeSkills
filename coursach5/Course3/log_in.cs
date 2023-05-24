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
    public partial class log_in : Form
    {
        DataBase database = new DataBase();
        public log_in()
        {
            InitializeComponent();
            // позиц по центру экрана
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void log_in_Load(object sender, EventArgs e)
        {
            //шифр нашего пароля тюе присвоение значения *
            textBox_password.PasswordChar = '*';
            // макс симв логин и пароль
            textBox_password.MaxLength = 50;
            textBox_login.MaxLength = 50;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // считываем в переменную значения с текстбоксов
            var loginuser = textBox_login.Text;
            var passworduser = textBox_password.Text;
            // создаем экз класса адаптер и тэйбл (нужны для того чтобы работать с таблицей в бд)
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            // проверяем есть ли в таблице есть строка со значениями текстбоксов
            string querystring = $"select id_user,login_user,password_user from register where login_user = '{loginuser}' and password_user = '{passworduser}'";
            SqlCommand comand = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = comand;
            adapter.Fill(table);
            // проверка
            // если есть строка создаем иначе не сущ такого аккаунта
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //создаем экз формы 1 потом вызываем методы класса для перехода на форму
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();

            }
            else
            {
                MessageBox.Show(" Такого аккаунта не существует", "Неуспешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // обработка события при нажати на ссылку - создаем экз формы регистрации и обращаеся к методу класса и применяем его к экземпляру класса логика в том что при нажатии текущая форма закроется и откроется форма регистрации
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // обработка кнопки очистки
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
