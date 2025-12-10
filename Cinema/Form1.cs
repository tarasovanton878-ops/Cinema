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
    // Главная форма приложения (стартовый экран)
    public partial class Form1 : Form
    {
        // Конструктор главной формы
        public Form1()
        {
            InitializeComponent(); // Стандартный метод инициализации компонентов формы
        }

        // Обработчик нажатия кнопки 2 (предположительно, переход к форме с расписанием или бронированием)
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Создание экземпляра третьей формы (например, "Расписание сеансов")
            form3.Show();              // Отображение формы Form3 как немодального окна
        }

        // Обработчик нажатия кнопки 1 (предположительно, переход к форме с выбором фильмов)
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Создание экземпляра второй формы (например, "Список фильмов")
            form2.Show();              // Отображение формы Form2 как немодального окна
        }

        // Обработчик события загрузки главной формы
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}