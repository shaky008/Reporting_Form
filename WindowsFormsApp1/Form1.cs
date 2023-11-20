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
            loadData();
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
            form.ShowDialog();

        }

        private void SignedBtn_Click(object sender, EventArgs e)
        {
            lockData();
        }

        private void saveData()
        {
            string filePath = "info.txt";
            if(File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath, true);

                sw.WriteLine(NameTextBox.Text);
                sw.WriteLine(IdTextBox.Text);
                sw.WriteLine(EmailTextBox.Text);
                sw.WriteLine(FacultyName.Text);
                sw.WriteLine(dateTimePicker2.Value.ToString());
                sw.WriteLine(CourseNameAndNum.Text);
                sw.WriteLine(AssignmentNumOrExam.Text);
                sw.WriteLine(DepartmentStudent.Text);
                sw.WriteLine(TermOrSemester.Text);
                sw.WriteLine(ViolationReasonBox.Text);
                sw.WriteLine(checkBox1.Checked);
                sw.WriteLine(checkBox2.Checked);
                sw.WriteLine(FacultyMemberName.Text);
                sw.WriteLine(FacultyDate.Value);
                sw.WriteLine("===");
                sw.Close();
            }
          
        }

        private void lockData()
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
        }

        private void loadData()
        {
            string filepath = "info.txt";
            if (File.Exists(filepath))
            {
                try
                {
                    StreamReader sr = new StreamReader(filepath);
                    NameTextBox.Text = sr.ReadLine();
                    IdTextBox.Text = sr.ReadLine();
                    EmailTextBox.Text = sr.ReadLine();
                    FacultyName.Text = sr.ReadLine();
                    dateTimePicker2.Value = DateTime.Parse(sr.ReadLine());
                    CourseNameAndNum.Text = sr.ReadLine();
                    AssignmentNumOrExam.Text = sr.ReadLine();
                    DepartmentStudent.Text = sr.ReadLine();
                    TermOrSemester.Text = sr.ReadLine();
                    ViolationReasonBox.Text = sr.ReadLine();
                    checkBox1.Checked = bool.Parse(sr.ReadLine());
                    checkBox2.Checked = bool.Parse(sr.ReadLine());
                    FacultyMemberName.Text = sr.ReadLine();
                    FacultyDate.Value = DateTime.Parse(sr.ReadLine());
                    sr.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("File Your Form");
                }

            }
            else
            {
                MessageBox.Show("No file detected, File your form");
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveData();
        }
    }
}
