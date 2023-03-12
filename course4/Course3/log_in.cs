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
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 50;
            textBox_login.MaxLength = 50;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var loginuser = textBox_login.Text;
            var passworduser = textBox_password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user,login_user,password_user from registerkps_db where login_user = '{loginuser}' and password_user = '{passworduser}'";
            SqlCommand comand = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = comand;
            adapter.Fill(table);
            if (table.Rows.Count == 2)
            {
                MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();

            }
            else
            {
                MessageBox.Show(" Такого аккаунта не существует", "Неуспешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }
    }
}
