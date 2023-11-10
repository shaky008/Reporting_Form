using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StudentNum_Click(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog(this);
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignedBtn_Click(object sender, EventArgs e)
        {
            foreach (Control contorl in this.Controls)
            {
                if (contorl is TextBox textbox)
                {
                    textbox.ReadOnly = true;
                    textbox.BackColor = Color.Gray;
                }

                if (contorl is RichTextBox textbox1)
                {
                    textbox1.ReadOnly = true;
                    textbox1.BackColor = Color.Gray;
                }

                if (contorl is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Enabled = false;
                }

                if (contorl is CheckBox checkbox)
                {
                    checkbox.Enabled = false;
                }
            }
            StreamWriter sw = new StreamWriter("info.txt");
            sw.WriteLine();
        }

    }
}
