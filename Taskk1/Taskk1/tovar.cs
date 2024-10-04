using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskk1
{
    public partial class tovar : Form
    {
        public tovar()
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
            // получим начения из теккстовых полей
            if (decimal.TryParse(textBox2.Text, out decimal price) && decimal.TryParse(textBox3.Text, out decimal amountPaid))
                {
                // Проверка, что сумма , заплаченная покупателем, больше или равна цене товара
                if (amountPaid >= price)
                {
                    // Рассчет здачи
                    decimal change = amountPaid - price;
                    // Отображение резуьлтата в метке
                    label3.Text = $"Сдача: {change:F2} руб.";
                }
                else
                {
                    label3.Text = "Недостаточно средств для покупки.";
                }
                }
                else
                {
                    label3.Text = "Введите корректные значения.";
                }
            }
        }
    }
