using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    // Вторая форма приложения (предположительно форма со списком фильмов и расписанием)
    public partial class Form2 : Form
    {
        // Конструктор формы Form2
        public Form2()
        {
            // Вызов стандартного метода инициализации компонентов формы
            // (кнопки, таблицы, лейблы и другие элементы управления)
            InitializeComponent();
        }

        // Обработчик события нажатия на кнопку 2
        // Предположительно кнопка для перехода к деталям расписания или покупки билетов
        private void button2_Click(object sender, EventArgs e)
        {
            // Создание нового экземпляра Form3 (например, форма "Бронирование" или "Детали сеанса")
            Form3 form3 = new Form3();

            // Открытие Form3 как немодального окна (можно работать с Form2 и Form3 одновременно)
            form3.Show();
        }

        // Обработчик события загрузки формы Form2
        // Выполняется один раз при первом открытии формы
        private void Form2_Load(object sender, EventArgs e)
        {
            // Загрузка данных из таблицы "Расписание" базы данных в локальный DataSet (cDataSet)
            // Используется TableAdapter (расписаниеTableAdapter) для связи с базой данных
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);
        }
    }
}