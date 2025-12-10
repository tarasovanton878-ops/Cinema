using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema
{
    public partial class Form3 : Form
    {
        OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C.accdb");
        public Form3()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            comboBox1.Items.Add("Понедельник");
            comboBox1.Items.Add("Вторник");
            comboBox1.Items.Add("Среда");
            comboBox1.Items.Add("Четверг");
            comboBox1.Items.Add("Пятница");
            comboBox1.Items.Add("Суббота");
            comboBox1.Items.Add("Воскресенье");
            comboBox2.Items.Add("Фильм 1");
            comboBox2.Items.Add("Фильм 2");
            comboBox2.Items.Add("Мультфильм 1");
            comboBox2.Items.Add("Мультфильм 2");
            comboBox3.Items.Add("Покупка");
            comboBox3.Items.Add("Бронь");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FI = textBox1.Text;
            string NT = textBox2.Text;
            string N = comboBox1.SelectedItem.ToString();
            string S = comboBox2.SelectedItem.ToString();
            string P = comboBox3.SelectedItem.ToString();

            string query = "INSERT INTO Посетители VALUES ('" + FI + "', '" + NT + "', '" + N + "', '" + S + "', '" + P + "')";
            dbConnection.Open();

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

                if (dbCommand.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Ошибка выполнения запроса", "Внимание!");
                }
                else
                {
                    MessageBox.Show("Спасибо! В ближайшее время с Вами свяжется администратор для уточнения информации.", "Внимание!");
                }
                dbConnection.Close();
        }
    }
}
