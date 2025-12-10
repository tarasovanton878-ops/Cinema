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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.cDataSet.Расписание);

        }
    }
}
