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

        private void new_sign_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_of_product.Text = "";
            textBox_kolvo.Text = "";
            textBox_postavka.Text = "";
            textBox_price.Text = "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            database.openConnection();
            //заносим значения с текстбоксов для занесения данных в таблицу
            var type = textBox_of_product.Text;
            var count = textBox_kolvo.Text;
            var postavka = textBox_postavka.Text;
            var price = textBox_price.Text;

            var addQuery = $"insert into main_db (type_of,count_of,postavka,price) values ('{type}','{count}','{postavka}','{price}')";
            //подключение к бд
            var command = new SqlCommand(addQuery,database.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно создана!");

        }
    }
}
