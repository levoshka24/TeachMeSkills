using Microsoft.Office.Interop.Access.Dao;
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
    public partial class NewSign_Postavka : Form
    {
        DataBase database = new DataBase();
        public NewSign_Postavka()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var postavchik = textBox_postavchik.Text;

            string querystring = $"insert into Postavka(Postavka) values('{postavchik}')";
            SqlCommand comand = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            //метод ExecuteNonOuery() возвращает число затронутых строк соответсвенно если затронул строку то 1 и добавил иначе 0 и нет
            if (comand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись создана", "Успешно");
                
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Не успешно");
            }
            database.closeConnection();
            
        }
    }
}
