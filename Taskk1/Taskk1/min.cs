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
    public partial class min : Form
    {
        public min()
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
            // получаем значения из текстовых полей
            if (double.TryParse(textBox2.Text, out double num1) && double.TryParse(textBox3.Text, out double num2))
            {
                // находим минимальное число
                double minNum = Math.Min(num1, num2);
                // отображаем результат в метке
                label3.Text = $"Минимальное число: {minNum}";
            }
            else
            {
                label3.Text = "Введите корректные значения.";
            }
        }
    }
}
