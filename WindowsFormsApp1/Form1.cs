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
        string filePath = "info.txt";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            if (Properties.Settings.Default.Form1LockState)
            {
                LockData();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();

        }

        private void SignedBtn_Click(object sender, EventArgs e)
        {
            LockData();
            Properties.Settings.Default.Form1LockState = true;
            Properties.Settings.Default.Save();
        }

        private void SaveData()
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

        private void LockData()
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

        private void LoadData()
        {
           
            if (File.Exists(filePath))
            {
                try
                {
                    StreamReader sr = new StreamReader(filePath);
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
            SaveData();
        }

        
    }
}

//reference
//https://www.youtube.com/watch?v=7to8KHsXspE&t=199s