using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            textBox2.ReadOnly = false;
            textBox2.BackColor = Color.Gray;

            richTextBox2.ReadOnly = false;
            richTextBox2.BackColor = Color.Gray;

            richTextBox1.ReadOnly = false;
            richTextBox1.BackColor = Color.Gray;

            dateTimePicker1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

            textBox1.ReadOnly = false;
            textBox1.BackColor = Color.Gray;

            richTextBox3.ReadOnly = false;
            richTextBox3.BackColor = Color.Gray;

            textBox3.ReadOnly = false;
            textBox3.BackColor = Color.Gray;

            dateTimePicker2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog(this);
        }

       

       
    }
}
