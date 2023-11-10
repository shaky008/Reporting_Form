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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignedStudent_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.BackColor = Color.Gray;

            textBox2.ReadOnly = true;
            textBox2.BackColor = Color.Gray;

            dateTimePicker1.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void SignedFaculty_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;  
            textBox3.BackColor = Color.Gray;

            dateTimePicker2.Enabled = false;
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog(this);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog(this);
        }
    }
}
