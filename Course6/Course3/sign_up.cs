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
    public partial class sign_up : Form
    {
        DataBase database = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '*';
            textBox_password2.MaxLength = 50;
            textBox_login2.MaxLength = 50;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            var loginuser = textBox_login2.Text;
            var passworduser = textBox_password2.Text;

            string querystring = $"insert into registerkps_db(login_user,password_user) values('{loginuser}','{passworduser}')";
            SqlCommand comand = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            if (comand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успешно");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            database.closeConnection();
        }
        private Boolean checkuser()
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user,login_user,password_user from registerkps_db where login_user = '{loginUser}' and password_user = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;

            }
            else
            {
                return false;

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
        }
    }
}