using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskk1
{
    public partial class tab : Form
    {
        public tab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Генерируем таблицу умножения от 1 до 10
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    // Формируем строку с результатом умножения
                    string line = $"{i} * {j} = {i * j}";
                    // Добавляем результат в текстовое поле 
                    textBox2.AppendText(line + Environment.NewLine);
                }
                textBox2.AppendText(Environment.NewLine); // добавляю пустую строку между таблицами
            }
        }
    }
}
