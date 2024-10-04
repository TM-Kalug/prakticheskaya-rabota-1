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
    public partial class otr : Form
    {
        public otr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int unit;
            double length;
            if (!int.TryParse(textBox1.Text, out unit) || !double.TryParse(textBox2.Text, out length))
            {
                MessageBox.Show("Пожалуйста, введие корректные данные.");
                return;
            }
            double result = 0;

            switch (unit)
            {
                case 1: // дециметр
                    result = length / 10;
                    break;
                case 2: // километр
                    result = length * 1000;
                    break;
                case 3: // метр
                    result = length; // Нет преобразования
                    break;
                case 4: // миллиметр
                    result = length / 1000;
                    break;
                case 5: // сантиметр
                    result = length / 100;
                    break;
                default:
                    MessageBox.Show("Неверный номер единицы.");
                    return;
            }
            // Присвоение результата в Label
            label3.Text = $"Длина отрезка в метрах: {result}";
        }
    }
}
