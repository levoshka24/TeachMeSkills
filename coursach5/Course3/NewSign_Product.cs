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
using Course3;
namespace Course3
{
    public partial class NewSign_Product : Form
    {
        DataBase database = new DataBase();
        public NewSign_Product()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void New_Product_Postavka_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            
            var TypeOfProduct = textBox_product.Text;

            string querystring = $"insert into TypeOfProduct(TypeOfProduct) values('{TypeOfProduct}')";
            SqlCommand comand = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            //метод ExecuteNonOuery() возвращает число затронутых строк соответсвенно если затронул строку то 1 и добавил иначе 0 и нет
            if (comand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись создана", "Успешно");
                
                this.Hide();
                var main_frm = new Form1();
                main_frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Не успешно");
            }
            database.closeConnection();
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_product.Text = "";
        }
    }
}
