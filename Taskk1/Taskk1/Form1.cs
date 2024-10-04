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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            days days = new days();
            days.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            otr otr = new otr();
            otr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab tab = new tab();
            tab.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tovar tovar = new tovar();
            tovar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            min min = new min();
            min.Show();
            this.Hide();
        }
    }
}
