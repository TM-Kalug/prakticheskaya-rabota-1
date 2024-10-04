using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskk1
{
    public partial class days : Form
        { 
        private string[] raspisanie = new string[7];
        public days()
        {
            InitializeComponent();
            InitializeRaspisanie();
            FillComboBox();
        }
        private void InitializeRaspisanie()
        {
            raspisanie[0] = "Понедельник: Пойти на работу - 7:00; Получить аванс - 11:00; Положть деньги на счет в банке - 11:30; Купить молоко - 18:00";
            raspisanie[1] = "Вторник: Пойти на работу - 7:00; Вернуть книгу в библиотеку - 11:30; Сходить в церковь - 18:00; !!!Купить хлеб - 19:00!!!";
            raspisanie[2] = "Среда: Пойти на работу - 7:00; Проголосовать - 11:30; !!! День рождения друга - 20:00 !!!";
            raspisanie[3] = "Четвегр: Пойти на работу - 7:00; Заплатить штраф - 11:30; Приготовить что-то вкусное на ужин - 19:00";
            raspisanie[4] = "Пятница: Пойти на работу - 7:00; Уволиться = 11:00; Сходить на почту за посылкой - 18:00; Купить чипсы по акции - 19:00; !!!Поздравить маму с днем рождения (НЕ ЗАБЫТЬ)!!!-20:00";
            raspisanie[5] = "Суббота: Сходить в больницу на прием - 10:40; Начать чинить микроволновку - 13:00; Прочитать пару глав книги - 19:00";
            raspisanie[6] = "Воскресение: Поиграть на гитаре - 10:30; Продолжить чинить микроволновку - 11:30; Встреча с друзьями - 16:00; Посмотреть какой-нибудь фильм - 19:00";
        }

        private void FillComboBox()
        {
            comboBox1.Items.Add("Понедельник");
            comboBox1.Items.Add("Вторник");
            comboBox1.Items.Add("Среда");
            comboBox1.Items.Add("Четверг");
            comboBox1.Items.Add("Пятница");
            comboBox1.Items.Add("Суббота");
            comboBox1.Items.Add("Воскресенье");
            comboBox1.SelectedIndex = 0;
        }


     
        private void days_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex; // получаем индекс выбранного дня 
            label1.Text = raspisanie[selectedIndex]; // показываем расписание для этого дня
        }
    }
}
